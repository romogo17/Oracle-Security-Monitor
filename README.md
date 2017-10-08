

# Oracle-Security-Monitor

## Agregar las siguientes lineas al init
```
log_archive_start=true 
log_archive_dest_1=C:\oraclexe\app\oracle\admin\XE\Archive
log_archive_format='arc%t_%s_%r.arc'
```

## Querys necesarios para la ejecucion

Conectarse como `sys/root as sysdba`

``` sql
ALTER SYSTEM SET log_archive_dest_1 = 'LOCATION=C:\oraclexe\app\oracle\admin\XE\Archive';
alter system set log_archive_format = 'arc%t_%s_%r.arc' scope=spfile;
ALTER SYSTEM SET audit_trail=db,extended SCOPE=SPFILE;

shutdown abort;

startup;
```

Conectarse como `system/manager as sysdba`

``` sql
GRANT sysdba TO dev;
GRANT SELECT ON V_$LOG TO dev;
GRANT SELECT ON V_$LOGFILE TO dev;
GRANT SELECT ON V_$LOG_HISTORY TO dev;
GRANT SELECT ON V_$ARCHIVE_DEST TO dev;
GRANT SELECT ON dba_audit_trail TO dev;
```

Conectarse como `dev/dev`

``` sql
CREATE OR REPLACE FUNCTION get_logfiles_info
  RETURN SYS_REFCURSOR IS
  cr SYS_REFCURSOR;
  BEGIN
    OPEN cr FOR
    SELECT
	a.status, 
	a.group#, 
	a.archived, 
	a.sequence#, 
	b.member 
    FROM
	v$log a, 
	v$logfile b 
    WHERE a.group# = b.group#
    ORDER BY a.group#;
    RETURN CR;
  END;
/


CREATE OR REPLACE FUNCTION get_loggroups_info
  RETURN SYS_REFCURSOR IS
  cr SYS_REFCURSOR;
  BEGIN
    OPEN cr FOR
    SELECT
	a.status, 
	a.group#, 
	a.archived, 
	a.sequence#, 
	a.first_change# 
    FROM
	v$log a
    ORDER BY a.group#;
    RETURN CR;
  END;
/

create or replace function date_to_unix_ts( PDate in date ) return number is

   l_unix_ts number;

begin

   l_unix_ts := ( PDate - date '1970-01-01' ) * 60 * 60 * 24;
   return l_unix_ts;

end;
/

CREATE OR REPLACE FUNCTION get_avg_switch_minutes
  RETURN NUMBER IS
  MM NUMBER;
  BEGIN
    WITH SWITCHMINUTES AS 
    (
      select BASE.MINUTES, ROW_NUMBER() OVER (ORDER BY BASE.MINUTES DESC) AS ROWNUMBER
      from (select TRUNC(date_to_unix_ts(first_time)/60,2) as MINUTES FROM v$log_history) BASE
    )
    SELECT TRUNC(AVG(AA.MINUTES-BB.MINUTES),2) AS AVG_SWITCH_MINUTES INTO MM
    FROM SWITCHMINUTES AA, SWITCHMINUTES BB
    WHERE AA.ROWNUMBER = BB.ROWNUMBER-1;
    RETURN MM;
  END;
/


CREATE OR REPLACE FUNCTION get_arc_dest
  RETURN VARCHAR2 IS
  DEST VARCHAR2(255);
  BEGIN
    select destination INTO DEST from v$archive_dest where status = 'VALID' and rownum <= 1; 
    RETURN DEST;
  END;
/


CREATE OR REPLACE FUNCTION get_role_users(keyword IN VARCHAR2)
  RETURN SYS_REFCURSOR IS
  cr SYS_REFCURSOR;
  term varchar2(255) := CONCAT('%', CONCAT(UPPER(keyword), '%'));
  BEGIN
    OPEN cr FOR select USERNAME from USER_ROLE_PRIVS where granted_role LIKE term;    
    RETURN CR;
  END;
/


CREATE OR REPLACE FUNCTION get_role_roles(keyword IN VARCHAR2)
  RETURN SYS_REFCURSOR IS
  cr SYS_REFCURSOR;
  term varchar2(255) := CONCAT('%', CONCAT(UPPER(keyword), '%'));
  BEGIN
    OPEN cr FOR select GRANTED_ROLE from ROLE_ROLE_PRIVS where role like term;
    RETURN CR;
  END;
/

CREATE OR REPLACE FUNCTION get_role_privs(keyword IN VARCHAR2)
  RETURN SYS_REFCURSOR IS
  cr SYS_REFCURSOR;
  term varchar2(255) := CONCAT('%', CONCAT(UPPER(keyword), '%'));
  BEGIN
    OPEN cr FOR select TABLE_NAME, PRIVILEGE from ROLE_TAB_PRIVS  where role like term;
    RETURN CR;
  END;
/

CREATE OR REPLACE FUNCTION get_role_sys_privs(keyword IN VARCHAR2)
  RETURN SYS_REFCURSOR IS
  cr SYS_REFCURSOR;
  term varchar2(255) := CONCAT('%', CONCAT(UPPER(keyword), '%'));
  BEGIN
    OPEN cr FOR select PRIVILEGE from ROLE_SYS_PRIVS  where role like term;
    RETURN CR;
  END;
/


-------------------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION get_user_roles(keyword IN VARCHAR2)
  RETURN SYS_REFCURSOR IS
  cr SYS_REFCURSOR;
  term varchar2(255) := CONCAT('%', CONCAT(UPPER(keyword), '%'));
  BEGIN
    OPEN cr FOR select GRANTED_ROLE from USER_ROLE_PRIVS WHERE USERNAME LIKE term;  
    RETURN CR;
  END;
/


CREATE OR REPLACE FUNCTION get_user_privs(keyword IN VARCHAR2)
  RETURN SYS_REFCURSOR IS
  cr SYS_REFCURSOR;
  term varchar2(255) := CONCAT('%', CONCAT(UPPER(keyword), '%'));
  BEGIN
    OPEN cr FOR select TABLE_NAME, PRIVILEGE from USER_TAB_PRIVS WHERE GRANTEE LIKE term;
    RETURN CR;
  END;
/


CREATE OR REPLACE FUNCTION get_user_sys_privs(keyword IN VARCHAR2)
  RETURN SYS_REFCURSOR IS
  cr SYS_REFCURSOR;
  term varchar2(255) := CONCAT('%', CONCAT(UPPER(keyword), '%'));
  BEGIN
    OPEN cr FOR select PRIVILEGE from USER_SYS_PRIVS WHERE USERNAME LIKE term;
    RETURN CR;
  END;
/

-------------------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION get_audit_user(keyword IN VARCHAR2)
  RETURN SYS_REFCURSOR IS
  cr SYS_REFCURSOR;
  term varchar2(255) := CONCAT('%', CONCAT(UPPER(keyword), '%'));
  BEGIN
    OPEN cr FOR
      SELECT username,
             cast (extended_timestamp AS TIMESTAMP),
             owner,
             obj_name,
             action_name
      FROM   dba_audit_trail
      WHERE  owner LIKE term
      ORDER BY timestamp DESC;
    RETURN CR;
  END;
/

```

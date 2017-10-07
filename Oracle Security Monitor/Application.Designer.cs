namespace Oracle_Security_Monitor
{
    using System;
    using System.Windows.Forms;
    using LiveCharts;
    using LiveCharts.Configurations;
    using LiveCharts.Wpf;
    using Oracle.ManagedDataAccess.Client;
    using Oracle.ManagedDataAccess.Types;
    using System.Data;
    using System.Configuration;
    using System.Windows.Media;
    using System.IO;
    using System.Reflection;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Threading;
    using System.Linq;
    using System.Xml;

    partial class Application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarHWMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_loginfo = new System.Windows.Forms.TabPage();
            this.lbl_asm = new System.Windows.Forms.Label();
            this.lbl_asmt = new System.Windows.Forms.Label();
            this.dataGrid_logs = new System.Windows.Forms.DataGridView();
            this.tab_archive = new System.Windows.Forms.TabPage();
            this.dataGrid_archives = new System.Windows.Forms.DataGridView();
            this.tabPage_roles = new System.Windows.Forms.TabPage();
            this.usersWithRoleLbl = new System.Windows.Forms.Label();
            this.dataGrid_roleUsers = new System.Windows.Forms.DataGridView();
            this.asignedSysPrivsLbl = new System.Windows.Forms.Label();
            this.dataGrid_roleSysAsignedPrivs = new System.Windows.Forms.DataGridView();
            this.asignedPrivsLbl = new System.Windows.Forms.Label();
            this.dataGrid_roleAsignedPrivs = new System.Windows.Forms.DataGridView();
            this.searchRoleBtn = new System.Windows.Forms.Button();
            this.roleAsignedRolesLbl = new System.Windows.Forms.Label();
            this.roleTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGrid_roleAsignedRoles = new System.Windows.Forms.DataGridView();
            this.tabPage_usuarios = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid_userSysPrivs = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGrid_userPrivs = new System.Windows.Forms.DataGridView();
            this.usuarioSearchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.usuariosTitle = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGrid_userRoles = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_loginfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_logs)).BeginInit();
            this.tab_archive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_archives)).BeginInit();
            this.tabPage_roles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_roleUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_roleSysAsignedPrivs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_roleAsignedPrivs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_roleAsignedRoles)).BeginInit();
            this.tabPage_usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_userSysPrivs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_userPrivs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_userRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarHWMToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // cambiarHWMToolStripMenuItem
            // 
            this.cambiarHWMToolStripMenuItem.Name = "cambiarHWMToolStripMenuItem";
            this.cambiarHWMToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem});
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.archiveToolStripMenuItem.Text = "Archive";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // myLayout
            // 
            this.myLayout.AutoScroll = true;
            this.myLayout.Location = new System.Drawing.Point(0, -1);
            this.myLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.myLayout.Name = "myLayout";
            this.myLayout.Size = new System.Drawing.Size(759, 210);
            this.myLayout.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tab_loginfo);
            this.tabControl1.Controls.Add(this.tab_archive);
            this.tabControl1.Controls.Add(this.tabPage_roles);
            this.tabControl1.Controls.Add(this.tabPage_usuarios);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 526);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 18;
            // 
            // tab_loginfo
            // 
            this.tab_loginfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.tab_loginfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tab_loginfo.CausesValidation = false;
            this.tab_loginfo.Controls.Add(this.lbl_asm);
            this.tab_loginfo.Controls.Add(this.lbl_asmt);
            this.tab_loginfo.Controls.Add(this.dataGrid_logs);
            this.tab_loginfo.Controls.Add(this.myLayout);
            this.tab_loginfo.ForeColor = System.Drawing.SystemColors.Control;
            this.tab_loginfo.Location = new System.Drawing.Point(4, 4);
            this.tab_loginfo.Margin = new System.Windows.Forms.Padding(0);
            this.tab_loginfo.Name = "tab_loginfo";
            this.tab_loginfo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_loginfo.Size = new System.Drawing.Size(759, 518);
            this.tab_loginfo.TabIndex = 0;
            this.tab_loginfo.Text = "Logs";
            // 
            // lbl_asm
            // 
            this.lbl_asm.AutoSize = true;
            this.lbl_asm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asm.Location = new System.Drawing.Point(21, 259);
            this.lbl_asm.Name = "lbl_asm";
            this.lbl_asm.Size = new System.Drawing.Size(72, 18);
            this.lbl_asm.TabIndex = 20;
            this.lbl_asm.Text = "0 minutes";
            // 
            // lbl_asmt
            // 
            this.lbl_asmt.AutoSize = true;
            this.lbl_asmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asmt.Location = new System.Drawing.Point(20, 226);
            this.lbl_asmt.Name = "lbl_asmt";
            this.lbl_asmt.Size = new System.Drawing.Size(201, 20);
            this.lbl_asmt.TabIndex = 19;
            this.lbl_asmt.Text = "Average Switch Minutes";
            // 
            // dataGrid_logs
            // 
            this.dataGrid_logs.AllowUserToAddRows = false;
            this.dataGrid_logs.AllowUserToDeleteRows = false;
            this.dataGrid_logs.AllowUserToOrderColumns = true;
            this.dataGrid_logs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_logs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_logs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_logs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_logs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_logs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_logs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_logs.Location = new System.Drawing.Point(8, 321);
            this.dataGrid_logs.MaximumSize = new System.Drawing.Size(992, 188);
            this.dataGrid_logs.Name = "dataGrid_logs";
            this.dataGrid_logs.ReadOnly = true;
            this.dataGrid_logs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_logs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_logs.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_logs.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_logs.Size = new System.Drawing.Size(745, 188);
            this.dataGrid_logs.TabIndex = 18;
            // 
            // tab_archive
            // 
            this.tab_archive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.tab_archive.Controls.Add(this.dataGrid_archives);
            this.tab_archive.Location = new System.Drawing.Point(4, 4);
            this.tab_archive.Name = "tab_archive";
            this.tab_archive.Padding = new System.Windows.Forms.Padding(3);
            this.tab_archive.Size = new System.Drawing.Size(759, 518);
            this.tab_archive.TabIndex = 1;
            this.tab_archive.Text = "Archives";
            // 
            // dataGrid_archives
            // 
            this.dataGrid_archives.AllowUserToAddRows = false;
            this.dataGrid_archives.AllowUserToDeleteRows = false;
            this.dataGrid_archives.AllowUserToOrderColumns = true;
            this.dataGrid_archives.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_archives.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_archives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_archives.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_archives.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_archives.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid_archives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_archives.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid_archives.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_archives.Location = new System.Drawing.Point(6, 6);
            this.dataGrid_archives.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.dataGrid_archives.Name = "dataGrid_archives";
            this.dataGrid_archives.ReadOnly = true;
            this.dataGrid_archives.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_archives.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid_archives.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_archives.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGrid_archives.Size = new System.Drawing.Size(747, 506);
            this.dataGrid_archives.TabIndex = 19;
            // 
            // tabPage_roles
            // 
            this.tabPage_roles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.tabPage_roles.Controls.Add(this.usersWithRoleLbl);
            this.tabPage_roles.Controls.Add(this.dataGrid_roleUsers);
            this.tabPage_roles.Controls.Add(this.asignedSysPrivsLbl);
            this.tabPage_roles.Controls.Add(this.dataGrid_roleSysAsignedPrivs);
            this.tabPage_roles.Controls.Add(this.asignedPrivsLbl);
            this.tabPage_roles.Controls.Add(this.dataGrid_roleAsignedPrivs);
            this.tabPage_roles.Controls.Add(this.searchRoleBtn);
            this.tabPage_roles.Controls.Add(this.roleAsignedRolesLbl);
            this.tabPage_roles.Controls.Add(this.roleTitle);
            this.tabPage_roles.Controls.Add(this.textBox1);
            this.tabPage_roles.Controls.Add(this.dataGrid_roleAsignedRoles);
            this.tabPage_roles.Location = new System.Drawing.Point(4, 4);
            this.tabPage_roles.Name = "tabPage_roles";
            this.tabPage_roles.Size = new System.Drawing.Size(759, 518);
            this.tabPage_roles.TabIndex = 2;
            this.tabPage_roles.Text = "Roles";
            // 
            // usersWithRoleLbl
            // 
            this.usersWithRoleLbl.AutoSize = true;
            this.usersWithRoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersWithRoleLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usersWithRoleLbl.Location = new System.Drawing.Point(404, 300);
            this.usersWithRoleLbl.Name = "usersWithRoleLbl";
            this.usersWithRoleLbl.Size = new System.Drawing.Size(204, 18);
            this.usersWithRoleLbl.TabIndex = 29;
            this.usersWithRoleLbl.Text = "Usuarios con el Rol Asignado";
            // 
            // dataGrid_roleUsers
            // 
            this.dataGrid_roleUsers.AllowUserToAddRows = false;
            this.dataGrid_roleUsers.AllowUserToDeleteRows = false;
            this.dataGrid_roleUsers.AllowUserToOrderColumns = true;
            this.dataGrid_roleUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_roleUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGrid_roleUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_roleUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_roleUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_roleUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGrid_roleUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_roleUsers.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGrid_roleUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_roleUsers.Location = new System.Drawing.Point(404, 321);
            this.dataGrid_roleUsers.MaximumSize = new System.Drawing.Size(992, 188);
            this.dataGrid_roleUsers.Name = "dataGrid_roleUsers";
            this.dataGrid_roleUsers.ReadOnly = true;
            this.dataGrid_roleUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_roleUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGrid_roleUsers.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_roleUsers.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGrid_roleUsers.Size = new System.Drawing.Size(345, 188);
            this.dataGrid_roleUsers.TabIndex = 28;
            // 
            // asignedSysPrivsLbl
            // 
            this.asignedSysPrivsLbl.AutoSize = true;
            this.asignedSysPrivsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignedSysPrivsLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.asignedSysPrivsLbl.Location = new System.Drawing.Point(404, 73);
            this.asignedSysPrivsLbl.Name = "asignedSysPrivsLbl";
            this.asignedSysPrivsLbl.Size = new System.Drawing.Size(268, 18);
            this.asignedSysPrivsLbl.TabIndex = 27;
            this.asignedSysPrivsLbl.Text = "Privilegios de Sistema Asignados al Rol";
            // 
            // dataGrid_roleSysAsignedPrivs
            // 
            this.dataGrid_roleSysAsignedPrivs.AllowUserToAddRows = false;
            this.dataGrid_roleSysAsignedPrivs.AllowUserToDeleteRows = false;
            this.dataGrid_roleSysAsignedPrivs.AllowUserToOrderColumns = true;
            this.dataGrid_roleSysAsignedPrivs.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_roleSysAsignedPrivs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGrid_roleSysAsignedPrivs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_roleSysAsignedPrivs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_roleSysAsignedPrivs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_roleSysAsignedPrivs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGrid_roleSysAsignedPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_roleSysAsignedPrivs.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGrid_roleSysAsignedPrivs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_roleSysAsignedPrivs.Location = new System.Drawing.Point(404, 94);
            this.dataGrid_roleSysAsignedPrivs.MaximumSize = new System.Drawing.Size(992, 188);
            this.dataGrid_roleSysAsignedPrivs.Name = "dataGrid_roleSysAsignedPrivs";
            this.dataGrid_roleSysAsignedPrivs.ReadOnly = true;
            this.dataGrid_roleSysAsignedPrivs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_roleSysAsignedPrivs.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGrid_roleSysAsignedPrivs.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_roleSysAsignedPrivs.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGrid_roleSysAsignedPrivs.Size = new System.Drawing.Size(345, 188);
            this.dataGrid_roleSysAsignedPrivs.TabIndex = 26;
            // 
            // asignedPrivsLbl
            // 
            this.asignedPrivsLbl.AutoSize = true;
            this.asignedPrivsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignedPrivsLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.asignedPrivsLbl.Location = new System.Drawing.Point(12, 300);
            this.asignedPrivsLbl.Name = "asignedPrivsLbl";
            this.asignedPrivsLbl.Size = new System.Drawing.Size(190, 18);
            this.asignedPrivsLbl.TabIndex = 25;
            this.asignedPrivsLbl.Text = "Privilegios Asignados al Rol";
            // 
            // dataGrid_roleAsignedPrivs
            // 
            this.dataGrid_roleAsignedPrivs.AllowUserToAddRows = false;
            this.dataGrid_roleAsignedPrivs.AllowUserToDeleteRows = false;
            this.dataGrid_roleAsignedPrivs.AllowUserToOrderColumns = true;
            this.dataGrid_roleAsignedPrivs.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_roleAsignedPrivs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGrid_roleAsignedPrivs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_roleAsignedPrivs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_roleAsignedPrivs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_roleAsignedPrivs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGrid_roleAsignedPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_roleAsignedPrivs.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGrid_roleAsignedPrivs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_roleAsignedPrivs.Location = new System.Drawing.Point(12, 321);
            this.dataGrid_roleAsignedPrivs.MaximumSize = new System.Drawing.Size(992, 188);
            this.dataGrid_roleAsignedPrivs.Name = "dataGrid_roleAsignedPrivs";
            this.dataGrid_roleAsignedPrivs.ReadOnly = true;
            this.dataGrid_roleAsignedPrivs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_roleAsignedPrivs.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGrid_roleAsignedPrivs.RowHeadersVisible = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_roleAsignedPrivs.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGrid_roleAsignedPrivs.Size = new System.Drawing.Size(345, 188);
            this.dataGrid_roleAsignedPrivs.TabIndex = 24;
            // 
            // searchRoleBtn
            // 
            this.searchRoleBtn.Location = new System.Drawing.Point(151, 38);
            this.searchRoleBtn.Name = "searchRoleBtn";
            this.searchRoleBtn.Size = new System.Drawing.Size(75, 23);
            this.searchRoleBtn.TabIndex = 23;
            this.searchRoleBtn.Text = "Buscar";
            this.searchRoleBtn.UseVisualStyleBackColor = true;
            this.searchRoleBtn.Click += new System.EventHandler(this.searchRoleBtn_Click);
            // 
            // roleAsignedRolesLbl
            // 
            this.roleAsignedRolesLbl.AutoSize = true;
            this.roleAsignedRolesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleAsignedRolesLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.roleAsignedRolesLbl.Location = new System.Drawing.Point(12, 73);
            this.roleAsignedRolesLbl.Name = "roleAsignedRolesLbl";
            this.roleAsignedRolesLbl.Size = new System.Drawing.Size(120, 18);
            this.roleAsignedRolesLbl.TabIndex = 22;
            this.roleAsignedRolesLbl.Text = "Roles Asignados";
            // 
            // roleTitle
            // 
            this.roleTitle.AutoSize = true;
            this.roleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.roleTitle.Location = new System.Drawing.Point(8, 15);
            this.roleTitle.Name = "roleTitle";
            this.roleTitle.Size = new System.Drawing.Size(36, 20);
            this.roleTitle.TabIndex = 21;
            this.roleTitle.Text = "Rol";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 21);
            this.textBox1.TabIndex = 20;
            // 
            // dataGrid_roleAsignedRoles
            // 
            this.dataGrid_roleAsignedRoles.AllowUserToAddRows = false;
            this.dataGrid_roleAsignedRoles.AllowUserToDeleteRows = false;
            this.dataGrid_roleAsignedRoles.AllowUserToOrderColumns = true;
            this.dataGrid_roleAsignedRoles.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_roleAsignedRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGrid_roleAsignedRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_roleAsignedRoles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_roleAsignedRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_roleAsignedRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGrid_roleAsignedRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_roleAsignedRoles.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGrid_roleAsignedRoles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_roleAsignedRoles.Location = new System.Drawing.Point(12, 94);
            this.dataGrid_roleAsignedRoles.MaximumSize = new System.Drawing.Size(992, 188);
            this.dataGrid_roleAsignedRoles.Name = "dataGrid_roleAsignedRoles";
            this.dataGrid_roleAsignedRoles.ReadOnly = true;
            this.dataGrid_roleAsignedRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_roleAsignedRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGrid_roleAsignedRoles.RowHeadersVisible = false;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_roleAsignedRoles.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGrid_roleAsignedRoles.Size = new System.Drawing.Size(345, 188);
            this.dataGrid_roleAsignedRoles.TabIndex = 19;
            // 
            // tabPage_usuarios
            // 
            this.tabPage_usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.tabPage_usuarios.Controls.Add(this.label2);
            this.tabPage_usuarios.Controls.Add(this.dataGrid_userSysPrivs);
            this.tabPage_usuarios.Controls.Add(this.label3);
            this.tabPage_usuarios.Controls.Add(this.dataGrid_userPrivs);
            this.tabPage_usuarios.Controls.Add(this.usuarioSearchBtn);
            this.tabPage_usuarios.Controls.Add(this.label4);
            this.tabPage_usuarios.Controls.Add(this.usuariosTitle);
            this.tabPage_usuarios.Controls.Add(this.textBox2);
            this.tabPage_usuarios.Controls.Add(this.dataGrid_userRoles);
            this.tabPage_usuarios.Location = new System.Drawing.Point(4, 4);
            this.tabPage_usuarios.Name = "tabPage_usuarios";
            this.tabPage_usuarios.Size = new System.Drawing.Size(759, 518);
            this.tabPage_usuarios.TabIndex = 3;
            this.tabPage_usuarios.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(405, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Privilegios de Sistema Asignados al Usuario";
            // 
            // dataGrid_userSysPrivs
            // 
            this.dataGrid_userSysPrivs.AllowUserToAddRows = false;
            this.dataGrid_userSysPrivs.AllowUserToDeleteRows = false;
            this.dataGrid_userSysPrivs.AllowUserToOrderColumns = true;
            this.dataGrid_userSysPrivs.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_userSysPrivs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGrid_userSysPrivs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_userSysPrivs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_userSysPrivs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_userSysPrivs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGrid_userSysPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_userSysPrivs.DefaultCellStyle = dataGridViewCellStyle33;
            this.dataGrid_userSysPrivs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_userSysPrivs.Location = new System.Drawing.Point(405, 91);
            this.dataGrid_userSysPrivs.MaximumSize = new System.Drawing.Size(992, 188);
            this.dataGrid_userSysPrivs.Name = "dataGrid_userSysPrivs";
            this.dataGrid_userSysPrivs.ReadOnly = true;
            this.dataGrid_userSysPrivs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_userSysPrivs.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dataGrid_userSysPrivs.RowHeadersVisible = false;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_userSysPrivs.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dataGrid_userSysPrivs.Size = new System.Drawing.Size(345, 188);
            this.dataGrid_userSysPrivs.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Privilegios Asignados al Usuario";
            // 
            // dataGrid_userPrivs
            // 
            this.dataGrid_userPrivs.AllowUserToAddRows = false;
            this.dataGrid_userPrivs.AllowUserToDeleteRows = false;
            this.dataGrid_userPrivs.AllowUserToOrderColumns = true;
            this.dataGrid_userPrivs.AllowUserToResizeRows = false;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_userPrivs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGrid_userPrivs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_userPrivs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_userPrivs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_userPrivs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dataGrid_userPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_userPrivs.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataGrid_userPrivs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_userPrivs.Location = new System.Drawing.Point(13, 318);
            this.dataGrid_userPrivs.MaximumSize = new System.Drawing.Size(992, 188);
            this.dataGrid_userPrivs.Name = "dataGrid_userPrivs";
            this.dataGrid_userPrivs.ReadOnly = true;
            this.dataGrid_userPrivs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_userPrivs.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dataGrid_userPrivs.RowHeadersVisible = false;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_userPrivs.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dataGrid_userPrivs.Size = new System.Drawing.Size(345, 188);
            this.dataGrid_userPrivs.TabIndex = 35;
            // 
            // usuarioSearchBtn
            // 
            this.usuarioSearchBtn.Location = new System.Drawing.Point(152, 35);
            this.usuarioSearchBtn.Name = "usuarioSearchBtn";
            this.usuarioSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.usuarioSearchBtn.TabIndex = 34;
            this.usuarioSearchBtn.Text = "Buscar";
            this.usuarioSearchBtn.UseVisualStyleBackColor = true;
            this.usuarioSearchBtn.Click += new System.EventHandler(this.usuarioSearchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Roles Asignados";
            // 
            // usuariosTitle
            // 
            this.usuariosTitle.AutoSize = true;
            this.usuariosTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.usuariosTitle.Location = new System.Drawing.Point(9, 12);
            this.usuariosTitle.Name = "usuariosTitle";
            this.usuariosTitle.Size = new System.Drawing.Size(71, 20);
            this.usuariosTitle.TabIndex = 32;
            this.usuariosTitle.Text = "Usuario";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 21);
            this.textBox2.TabIndex = 31;
            // 
            // dataGrid_userRoles
            // 
            this.dataGrid_userRoles.AllowUserToAddRows = false;
            this.dataGrid_userRoles.AllowUserToDeleteRows = false;
            this.dataGrid_userRoles.AllowUserToOrderColumns = true;
            this.dataGrid_userRoles.AllowUserToResizeRows = false;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_userRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.dataGrid_userRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_userRoles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_userRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_userRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dataGrid_userRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_userRoles.DefaultCellStyle = dataGridViewCellStyle43;
            this.dataGrid_userRoles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGrid_userRoles.Location = new System.Drawing.Point(13, 91);
            this.dataGrid_userRoles.MaximumSize = new System.Drawing.Size(992, 188);
            this.dataGrid_userRoles.Name = "dataGrid_userRoles";
            this.dataGrid_userRoles.ReadOnly = true;
            this.dataGrid_userRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_userRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.dataGrid_userRoles.RowHeadersVisible = false;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGrid_userRoles.RowsDefaultCellStyle = dataGridViewCellStyle45;
            this.dataGrid_userRoles.Size = new System.Drawing.Size(345, 188);
            this.dataGrid_userRoles.TabIndex = 30;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(787, 549);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Application";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Monitor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_loginfo.ResumeLayout(false);
            this.tab_loginfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_logs)).EndInit();
            this.tab_archive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_archives)).EndInit();
            this.tabPage_roles.ResumeLayout(false);
            this.tabPage_roles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_roleUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_roleSysAsignedPrivs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_roleAsignedPrivs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_roleAsignedRoles)).EndInit();
            this.tabPage_usuarios.ResumeLayout(false);
            this.tabPage_usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_userSysPrivs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_userPrivs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_userRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        /********************************************************************************/


        private bool FetchLogGroups()
        {
            this.loggroups = new List<LogGroup>();
            DataSet ds = db_getLogGroups();

            bool flag = false;
            if (ds.Tables.Count == 0) flag = true;
            else if (!(ds.Tables[0].Rows.Count > 0)) flag = true;
            if (!flag)
            {
                DataTable dt = ds.Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    loggroups.Add(new LogGroup
                    {
                        FirstChange = dt.Rows[i].Field<decimal>("FIRST_CHANGE#"),
                        Status = dt.Rows[i].Field<string>("STATUS"),
                        Archived = dt.Rows[i].Field<string>("ARCHIVED"),
                        Group = Convert.ToDouble(Math.Round(dt.Rows[i].Field<decimal>("GROUP#"))),
                        Sequence = Convert.ToDouble(Math.Round(dt.Rows[i].Field<decimal>("SEQUENCE#")))
                    });
                }
            }
            return !flag;
        }
        private bool FetchLogFiles()
        {
            this.logfiles = db_getLogFiles();

            bool flag = false;
            if (logfiles == null) flag = true;

            return !flag;
        }
        private bool FetchAvgSwitchMinutes()
        {
            this.avgswmin = db_getAvgSwitchMinutes();

            bool flag = false;
            if (avgswmin == -1) flag = true;

            return !flag;
        }
        private bool FetchArcDest()
        {
            this.arcdest = db_getArcDest();

            bool flag = false;
            if (arcdest == "") flag = true;

            return !flag;
        }

        private void DisplayGroups()
        {
            if (this.loggroups == null) return;

            myLayout.Controls.Clear();
            foreach (LogGroup lf in loggroups)
            {
                this.myLayout.Controls.Add(new Lf_Panel(lf));
            }
        }
        private void DisplayFiles()
        {
            if (this.logfiles == null) return;
            dataGrid_logs.DataSource = logfiles.Tables[0];
        }
        private void DisplayAvgSwitchMinutes()
        {
            if (this.avgswmin == -1) return;
            lbl_asm.Text = Math.Round(avgswmin / 60, 2) + " hours";
        }
        private void DisplayArcFiles()
        {
            if (this.arcdest == "") return;


            DirectoryInfo info = new DirectoryInfo(arcdest);
            FileInfo[] files = info.GetFiles().OrderBy(p => p.CreationTime).ToArray();
            /*foreach (FileInfo file in files)
            {
                //dataGrid_archives.Rows.Add({ });
                System.Console.WriteLine("File is {0} \tCreated {1}", file.Name, file.CreationTime);
            }*/
            //var names = files.Select(file => file.Name).ToArray();
            //System.Console.WriteLine("Columns {0}", dataGrid_archives.Columns.ToString());
            dataGrid_archives.DataSource = files;
            dataGrid_archives.Columns["Exists"].Visible = false;
            dataGrid_archives.Columns["IsReadOnly"].Visible = false;
            dataGrid_archives.Columns["DirectoryName"].Visible = false;
            dataGrid_archives.Columns["CreationTimeUtc"].Visible = false;
            dataGrid_archives.Columns["LastWriteTimeUtc"].Visible = false;
            dataGrid_archives.Columns["FullName"].Visible = false;
            dataGrid_archives.Columns["LastAccessTime"].Visible = false;
            dataGrid_archives.Columns["LastAccessTimeUtc"].Visible = false;

            //dataGrid_archives.Columns.Remove()
        }

        private DataSet db_getLogGroups()
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet data = new DataSet("alerta");

                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "get_loggroups_info";
                objCmd.CommandType = CommandType.StoredProcedure;

                // Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                //objCmd.Parameters.Add("return_value", OracleDbType.Int32, sgaSize, System.Data.ParameterDirection.Input);

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    OracleDataAdapter a = new OracleDataAdapter(objCmd);
                    a.TableMappings.Add("MyTable", "sample_table"); // possible need for this
                    a.Fill(data);

                    //return sqlInfo;
                    //System.Console.WriteLine("Memory Usage is {0}", retParam.Value);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
                return data;
            }
        }
        private DataSet db_getLogFiles()
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet data = new DataSet("logfiles");

                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "get_logfiles_info";
                objCmd.CommandType = CommandType.StoredProcedure;

                // Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                //objCmd.Parameters.Add("return_value", OracleDbType.Int32, sgaSize, System.Data.ParameterDirection.Input);

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    OracleDataAdapter a = new OracleDataAdapter(objCmd);
                    a.TableMappings.Add("MyTable", "sample_table"); // possible need for this
                    a.Fill(data);

                    //return sqlInfo;
                    //System.Console.WriteLine("Memory Usage is {0}", retParam.Value);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
                return data;
            }
        }
        private decimal db_getAvgSwitchMinutes()
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                decimal data = 0;

                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "get_avg_switch_minutes";
                objCmd.CommandType = CommandType.StoredProcedure;

                // Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.Decimal, ParameterDirection.ReturnValue);
                //objCmd.Parameters.Add("return_value", OracleDbType.Int32, sgaSize, System.Data.ParameterDirection.Input);

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();


                    data = (decimal)((OracleDecimal)retParam.Value);

                    //return sqlInfo;
                    //System.Console.WriteLine("Memory Usage is {0}", retParam.Value);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
                return data;
            }
        }
        private string db_getArcDest()
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                string data = "";

                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "get_arc_dest";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("return_value", OracleDbType.Varchar2, ParameterDirection.ReturnValue);
                objCmd.Parameters["return_value"].Size = 255;

                // Set parameters

                OracleParameter retParam = objCmd.Parameters["return_value"];

                //objCmd.Parameters.Add("return_value", OracleDbType.Int32, sgaSize, System.Data.ParameterDirection.Input);

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    data = (string)((OracleString)retParam.Value);

                    //return sqlInfo;
                    //System.Console.WriteLine("Return is {0} - {1}", retParam.Value, data);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
                return data;
            }
        }
        private DataSet db_getRoleUsers(string keyword)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet data = new DataSet("alerta");

                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "GET_ROLE_USERS";
                objCmd.CommandType = CommandType.StoredProcedure;
                //objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, ParameterDirection.Input);

                // Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, System.Data.ParameterDirection.Input);

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    OracleDataAdapter a = new OracleDataAdapter(objCmd);
                    a.TableMappings.Add("MyTable", "sample_table"); // possible need for this
                    a.Fill(data);

                    //return sqlInfo;
                    //System.Console.WriteLine("Memory Usage is {0}", retParam.Value);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
                return data;
            }
        }
        private DataSet db_getRoleRoles(string keyword)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet data = new DataSet("alerta");

                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "GET_ROLE_ROLES";
                objCmd.CommandType = CommandType.StoredProcedure;
                //objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, ParameterDirection.Input);

                // Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, System.Data.ParameterDirection.Input);

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    OracleDataAdapter a = new OracleDataAdapter(objCmd);
                    a.TableMappings.Add("MyTable", "sample_table"); // possible need for this
                    a.Fill(data);

                    //return sqlInfo;
                    //System.Console.WriteLine("Memory Usage is {0}", retParam.Value);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
                return data;
            }
        }
        private DataSet db_getRolePrivs(string keyword)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet data = new DataSet("alerta");

                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "GET_ROLE_PRIVS";
                objCmd.CommandType = CommandType.StoredProcedure;
                //objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, ParameterDirection.Input);

                // Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, System.Data.ParameterDirection.Input);

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    OracleDataAdapter a = new OracleDataAdapter(objCmd);
                    a.TableMappings.Add("MyTable", "sample_table"); // possible need for this
                    a.Fill(data);

                    //return sqlInfo;
                    //System.Console.WriteLine("Memory Usage is {0}", retParam.Value);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
                return data;
            }
        }
        private DataSet db_getRoleSysPrivs(string keyword)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet data = new DataSet("alerta");

                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "GET_ROLE_SYS_PRIVS";
                objCmd.CommandType = CommandType.StoredProcedure;
                //objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, ParameterDirection.Input);

                // Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, System.Data.ParameterDirection.Input);

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    OracleDataAdapter a = new OracleDataAdapter(objCmd);
                    a.TableMappings.Add("MyTable", "sample_table"); // possible need for this
                    a.Fill(data);

                    //return sqlInfo;
                    //System.Console.WriteLine("Memory Usage is {0}", retParam.Value);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
                return data;
            }
        }
        private DataSet db_getUserRoles(string keyword)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet data = new DataSet("alerta");

                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "GET_USER_ROLES";
                objCmd.CommandType = CommandType.StoredProcedure;
                //objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, ParameterDirection.Input);

                // Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, System.Data.ParameterDirection.Input);

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    OracleDataAdapter a = new OracleDataAdapter(objCmd);
                    a.TableMappings.Add("MyTable", "sample_table"); // possible need for this
                    a.Fill(data);

                    //return sqlInfo;
                    //System.Console.WriteLine("Memory Usage is {0}", retParam.Value);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
                return data;
            }
        }
        private DataSet db_getUserPrivs(string keyword)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet data = new DataSet("alerta");

                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "GET_USER_PRIVS";
                objCmd.CommandType = CommandType.StoredProcedure;
                //objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, ParameterDirection.Input);

                // Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, System.Data.ParameterDirection.Input);

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    OracleDataAdapter a = new OracleDataAdapter(objCmd);
                    a.TableMappings.Add("MyTable", "sample_table"); // possible need for this
                    a.Fill(data);

                    //return sqlInfo;
                    //System.Console.WriteLine("Memory Usage is {0}", retParam.Value);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
                return data;
            }
        }
        private DataSet db_getUserSysPrivs(string keyword)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet data = new DataSet("alerta");

                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "GET_USER_SYS_PRIVS";
                objCmd.CommandType = CommandType.StoredProcedure;
                //objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, ParameterDirection.Input);

                // Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                objCmd.Parameters.Add("keyword", OracleDbType.Varchar2, keyword, System.Data.ParameterDirection.Input);

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    OracleDataAdapter a = new OracleDataAdapter(objCmd);
                    a.TableMappings.Add("MyTable", "sample_table"); // possible need for this
                    a.Fill(data);

                    //return sqlInfo;
                    //System.Console.WriteLine("Memory Usage is {0}", retParam.Value);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
                return data;
            }
        }

        /********************************************************************************/

        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem cambiarHWMToolStripMenuItem;
        private MenuStrip menuStrip1;
        private FlowLayoutPanel myLayout;

        List<LogGroup> loggroups;
        DataSet logfiles;
        private decimal avgswmin = -1;
        private string arcdest = "";
        private decimal hwm;
        private TabControl tabControl1;
        private TabPage tab_loginfo;
        private TabPage tab_archive;
        private DataGridView dataGrid_logs;
        private Label lbl_asm;
        private Label lbl_asmt;
        private DataGridView dataGrid_archives;



        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, true);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem archiveToolStripMenuItem;
        private ToolStripMenuItem backupToolStripMenuItem;
        private TabPage tabPage_roles;
        private Label asignedPrivsLbl;
        private DataGridView dataGrid_roleAsignedPrivs;
        private Button searchRoleBtn;
        private Label roleAsignedRolesLbl;
        private Label roleTitle;
        private TextBox textBox1;
        private DataGridView dataGrid_roleAsignedRoles;
        private Label usersWithRoleLbl;
        private DataGridView dataGrid_roleUsers;
        private Label asignedSysPrivsLbl;
        private DataGridView dataGrid_roleSysAsignedPrivs;
        private TabPage tabPage_usuarios;
        private Label label2;
        private DataGridView dataGrid_userSysPrivs;
        private Label label3;
        private DataGridView dataGrid_userPrivs;
        private Button usuarioSearchBtn;
        private Label label4;
        private Label usuariosTitle;
        private TextBox textBox2;
        private DataGridView dataGrid_userRoles;
    }

}

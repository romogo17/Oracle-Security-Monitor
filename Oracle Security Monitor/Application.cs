using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;
using System.IO;

namespace Oracle_Security_Monitor
{
    public partial class Application : Form
    {
        public Application()
        {
            hwm = Decimal.Parse(ConfigurationManager.AppSettings["highWaterMark"]) / 100;
            InitializeComponent();

            if (FetchLogGroups()) { DisplayGroups(); }
            if (FetchLogFiles()) { DisplayFiles(); }
            if (FetchAvgSwitchMinutes()) { DisplayAvgSwitchMinutes(); }
            if (FetchArcDest()) { DisplayArcFiles(); }

            Thread.Sleep(500);
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //System.Windows.Forms.MessageBox.Show("Directory found: " + fbd.SelectedPath, "Message");
                    if (arcdest != "")
                    {
                        DirectoryCopy(arcdest, fbd.SelectedPath, true);
                        System.Windows.Forms.MessageBox.Show(
                            "Backup files copied into " + fbd.SelectedPath, 
                            "Backup successfull",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void searchRoleBtn_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            //System.Console.WriteLine("Keyword is {0}", keyword);
            dataGrid_roleUsers.DataSource = db_getRoleUsers(keyword).Tables[0];
            dataGrid_roleAsignedRoles.DataSource = db_getRoleRoles(keyword).Tables[0];
            dataGrid_roleAsignedPrivs.DataSource = db_getRolePrivs(keyword).Tables[0];
            dataGrid_roleSysAsignedPrivs.DataSource = db_getRoleSysPrivs(keyword).Tables[0];
        }

        private void usuarioSearchBtn_Click(object sender, EventArgs e)
        {
            string keyword = textBox2.Text;
            //System.Console.WriteLine("Keyword is {0}", keyword);
            dataGrid_userRoles.DataSource = db_getUserRoles(keyword).Tables[0];
            dataGrid_userPrivs.DataSource = db_getUserPrivs(keyword).Tables[0];
            dataGrid_userSysPrivs.DataSource = db_getUserSysPrivs(keyword).Tables[0];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;
using LiveCharts;
using LiveCharts.Configurations;
using System.IO;
using System.Reflection;
using Oracle_Security_Monitor.Properties;

namespace Oracle_Security_Monitor
{
    class Lf_Panel : Panel
    {
      
        LiveCharts.WinForms.SolidGauge solidGauge;
        private Label lf_status;
        private Label lf_group;
        private Label lf_arc;
        private Label lf_sequence;
        public LogGroup lf;
        private PictureBox picturebox;


        public Lf_Panel(LogGroup lf)
        {
            this.lf = lf;
            this.lf_status = new Label();
            this.lf_group = new Label();
            this.lf_arc = new Label();
            this.lf_sequence = new Label();
            this.solidGauge = new LiveCharts.WinForms.SolidGauge();
            this.picturebox = new PictureBox();
            this.SuspendLayout();

            this.addControls();

            this.Location = new System.Drawing.Point(3, 3);
            this.Size = new System.Drawing.Size(230, 160);
            this.TabIndex = 2;

            this.configureControls();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void configureControls()
        {
            // 
            // lf_status
            // 
            lf_status.AutoSize = true;
            lf_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lf_status.ForeColor = System.Drawing.SystemColors.ControlDark;
            lf_status.Location = new System.Drawing.Point(130, 20);
            lf_status.Size = new System.Drawing.Size(55, 20);
            lf_status.TabIndex = 2;
            lf_status.Text = lf.Status;

            // 
            // picturebox
            // 
            picturebox.Dock = DockStyle.Fill;
            switch (lf.Status)
            {
                case "CURRENT": picturebox.Image = Resources.c_group; break;
                case "ACTIVE": picturebox.Image = Resources.a_group; break;
                case "INACTIVE": picturebox.Image = Resources.i_group; break;
                default: break;
            }


            // 
            // lf_group
            // 
            lf_group.AutoSize = true;
            lf_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lf_group.ForeColor = System.Drawing.SystemColors.ControlDark;
            lf_group.Location = new System.Drawing.Point(130, 40);
            lf_group.Size = new System.Drawing.Size(57, 18);
            lf_group.TabIndex = 3;
            lf_group.Text = "Group: " + lf.Group;

            // 
            // lf_arc
            // 
            lf_arc.AutoSize = true;
            lf_arc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lf_arc.ForeColor = System.Drawing.SystemColors.ControlDark;
            lf_arc.Location = new System.Drawing.Point(130, 60);
            lf_arc.Size = new System.Drawing.Size(84, 18);
            lf_arc.TabIndex = 4;
            lf_arc.Text = "ARC: " + lf.Archived;

            // 
            // lf_sequence
            // 
            lf_sequence.AutoSize = true;
            lf_sequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lf_sequence.ForeColor = System.Drawing.SystemColors.ControlDark;
            lf_sequence.Location = new System.Drawing.Point(130, 80);
            lf_sequence.Size = new System.Drawing.Size(77, 18);
            lf_sequence.TabIndex = 5;
            lf_sequence.Text = "Sequence: " + lf.Sequence;

        }

        private void addControls()
        {
            this.Controls.Add(lf_status);
            this.Controls.Add(lf_group);
            this.Controls.Add(lf_arc);
            this.Controls.Add(lf_sequence);
            this.Controls.Add(picturebox);
        }
    }
}

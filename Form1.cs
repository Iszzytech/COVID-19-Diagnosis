using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID_19_DIAGNOSTIC_SYSTEM
{
    public partial class Form1 : Form
    {
        int progress = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

            ProgressBar1.Value = progress;
            this.timer1.Start();
            label_value.Visible = true;
            Time_txt.Visible = true;
            ProgressBar1.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ProgressBar1.Increment(1);
            Time_txt.Text = ProgressBar1.ProgressPercentText;
            progress += 1;
            if (progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide();
                RegLogPage regPage = new RegLogPage();
                regPage.ShowDialog();
            }
            else if (progress == 50)
            {

                label_value.Text = "Initializing Diagnosis Checker....";
                timer1.Interval = 100;
            }
            else if (progress == 70)
            {
                label_value.Text = "Finishing Up Report Engine.....";
                timer1.Interval = 50;
            }
            else if (progress == 95)
            {
                label_value.Text = "Completed!!!";
            }
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

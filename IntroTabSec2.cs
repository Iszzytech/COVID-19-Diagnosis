using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID_19_DIAGNOSTIC_SYSTEM
{
    public partial class IntroTabSec2 : UserControl
    {
        private static IntroTabSec2 _instance;
        public static IntroTabSec2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new IntroTabSec2();
                return _instance;
            }
        }
        public IntroTabSec2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IntroTabSec2_Load(object sender, EventArgs e)
        {
            btn2.Enabled = false;
            //Message Construct
            StringBuilder MessageBuilder = new StringBuilder();
            StringBuilder MessageBuilder2 = new StringBuilder();
            StringBuilder MessageBuilder3 = new StringBuilder();


            MessageBuilder.Append("\t\u2022 Checkup is not a diagnosis.");
            MessageBuilder.Append(Environment.NewLine);
            label3.Text = MessageBuilder.ToString();
            MessageBuilder2.Append("\t\u2022 If this is an emergency, call your local emergency");
            MessageBuilder2.Append(Environment.NewLine);
            MessageBuilder2.Append("number immediately.");
            label6.Text = MessageBuilder2.ToString();
            MessageBuilder3.Append("\t\u2022 Your data is safe.");
            label7.Text = MessageBuilder3.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (gunaCheckBox1.Checked == false)
            {
                btn2.Enabled = false;
            }
            else
            {
                btn2.Enabled = true;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            IntroTab First = new IntroTab();
            First.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(First);
            First.BringToFront();
            
            

            //if (!Dashboard.Instance.panelCont.Controls.Contains(IntroTab.Instance))
            //  {

            //     Dashboard.Instance.panelCont.Controls.Add(IntroTab.Instance);
            //    IntroTab.Instance.Dock = DockStyle.Fill;
            //    IntroTab.Instance.BringToFront();
            //  }
            //   else { IntroTab.Instance.BringToFront(); }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // To make reference to a public function on the dashboard form from the userControl Tab 
            Dashboard das = (Dashboard)this.FindForm();
            das.returnVal();
            UCpatients1 patAge = new UCpatients1();
            patAge.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(patAge);
            patAge.BringToFront();
        }
    }
}

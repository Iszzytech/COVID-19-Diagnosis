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
    public partial class RegLogPage : Form
    {
        public RegLogPage()
        {
            InitializeComponent();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            login_btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#000525");
            signup_btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#098DFF");
            signuptab1.BringToFront();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            login_btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#098DFF");
            signup_btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#000525");
            login1.BringToFront();
        }

        private void signuptab1_Load(object sender, EventArgs e)
        {

        }
    }
}

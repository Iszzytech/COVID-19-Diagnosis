using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COVID_19_DIAGNOSTIC_SYSTEM.connection;

namespace COVID_19_DIAGNOSTIC_SYSTEM
{
    public partial class symptomNew : UserControl
    {
        public static string getDiagnosis;
        public symptomNew()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string fever = "";
            string cough = "";
            string breath = "";
            string ID = login.getEmail;
            if (feverYes.Checked)
            {
                fever = feverYes.Text;
            
            }

            if (feverNo.Checked)
            {
                fever = feverNo.Text;

            }

            if (coughYes.Checked)
            {
                cough = coughYes.Text;

            }

            if (coughNo.Checked)
            {
                cough = coughNo.Text;

            }

            if (breathYes.Checked)
            {
                breath = breathYes.Text;

            }

            if (breathNo.Checked)
            {
               breath = breathNo.Text;

            }

            

            string mySQL = string.Empty;

            mySQL = "UPDATE symptom_diagnosis SET fever = '" + fever + "', cough = '" + cough + "', shortness_of_breath = '" + breath + "'  WHERE email_id = '" + ID + "'";
            ServerConnection.executeSQL(mySQL);

            symptomTab3 sym2 = new symptomTab3();
            sym2.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(sym2);
            sym2.BringToFront();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            symptomTab2 sym1 = new symptomTab2();
            sym1.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(sym1);
            sym1.BringToFront();
        }
    }
}

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
    public partial class symptomTab1 : UserControl
    {
        public symptomTab1()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string strCheckValue = "";
            string strAbsValue = "";
            string ID = login.getEmail;

            if (checkbox_cancer.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_cancer.Text;
            }

            if (checkbox_immune.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_immune.Text;
            }

            if (checkbox_obesity.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_obesity.Text;
            }

            if (checkbox_nursingHome.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_nursingHome.Text;
            }

            if (checkbox_none1.Checked)
            {
                symptomTab2 symd2 = new symptomTab2();
                symd2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(symd2);
                symd2.BringToFront();
            }

            //ABSENT DATA


            if (!checkbox_cancer.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_cancer.Text;
            }

            if (!checkbox_immune.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_immune.Text;
            }

            if (!checkbox_obesity.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_obesity.Text;
            }

            if (!checkbox_nursingHome.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_nursingHome.Text;
            }

          

            strCheckValue = strCheckValue.TrimStart(',');
            strAbsValue = strAbsValue.TrimStart(',');

            string mySQL = string.Empty;
            mySQL += "INSERT INTO symptom_diagnosis(email_id, stage1) values ('" + ID + "','" + strCheckValue + "')";
            mySQL += "INSERT INTO absent_symptoms(email_id, absent_symptoms) values ('" + ID + "','" + strAbsValue + "')";
            ServerConnection.executeSQL(mySQL);

            symptomTab2 sym2 = new symptomTab2();
            sym2.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(sym2);
            sym2.BringToFront();


        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            string ID = login.getEmail;


            string mySQL = string.Empty;
            mySQL += "DELETE FROM symptom_diagnosis WHERE email_id = '" + ID + "'";
            mySQL += "DELETE FROM absent_symptoms WHERE email_id = '" + ID + "'";
            ServerConnection.executeSQL(mySQL);


            Dashboard dash = (Dashboard)this.FindForm();
            dash.hideVal2();
            UC_Patients newtab = new UC_Patients();
            newtab.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(newtab);
            newtab.BringToFront();


        }
    }
}

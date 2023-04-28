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
    public partial class symptomTab2 : UserControl
    {
        public symptomTab2()
        {
            InitializeComponent();
        }

        private void btn_nxt_Click(object sender, EventArgs e)
        {
            string strCheckValue = "";
            string strAbsValue = "";
            string ID = login.getEmail;

            if (checkbox_diabetes.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_diabetes.Text;
            }

            if (checkbox_cardio.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_cardio.Text;
            }

            if (checkbox_chroniclung.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_chroniclung.Text;
            }

            if (checkbox_chronicliver.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_chronicliver.Text;
            }

            if (checkbox_chronickidney.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_chronickidney.Text;
            }

            if (checkbox_none2.Checked)
            {
                symptomNew symd2 = new symptomNew();
                symd2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(symd2);
                symd2.BringToFront();
            }

            //ABSENT DATA


            if (!checkbox_diabetes.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_diabetes.Text;
            }

            if (!checkbox_cardio.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_cardio.Text;
            }

            if (!checkbox_chroniclung.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_chroniclung.Text;
            }

            if (!checkbox_chronicliver.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_chronicliver.Text;
            }

            if (!checkbox_chronickidney.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_chronickidney.Text;
            }

         

            strCheckValue = strCheckValue.TrimStart(',');
            strAbsValue = strAbsValue.TrimStart(',');

            string mySQL = string.Empty;
          
            mySQL += "UPDATE symptom_diagnosis SET stage2 = '" + strCheckValue + "' WHERE email_id = '" + ID + "'";
            mySQL += "UPDATE absent_symptoms SET absent_symptoms2 = '" + strAbsValue + "' WHERE email_id = '" + ID + "'";
            ServerConnection.executeSQL(mySQL);

            symptomNew sym2 = new symptomNew();
            sym2.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(sym2);
            sym2.BringToFront();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
 
      
            string ID = login.getEmail;

       


            string mySQL = string.Empty;

            mySQL += "DELETE FROM symptom_diagnosis WHERE email_id = '" + ID + "'";
            mySQL += "DELETE FROM absent_symptoms WHERE email_id = '" + ID + "'";
            ServerConnection.executeSQL(mySQL);

            symptomTab1 sym1 = new symptomTab1();
            sym1.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(sym1);
            sym1.BringToFront();
        }
    }
}

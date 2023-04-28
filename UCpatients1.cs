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
    public partial class UCpatients1 : UserControl
    {
        public UCpatients1()
        {
            InitializeComponent();
        }

        private void UCpatients1_Load(object sender, EventArgs e)
        {

            

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string sex;
            sex = label1.Text;
            string uniqueID = login.getEmail;
          //  MessageBoxButtons btn = MessageBoxButtons.OK;

            // INSERTING THE QUERIES
            string mySQL2 = string.Empty;
            //BSDate,customer,cust_contact,bird_quantity,feedType,feedQuant,waterQuant,eggCap,bagEggCap,mortality,price
            mySQL2 = "UPDATE patient_tab SET patient_sex ='" + sex + "' WHERE email_id ='" + uniqueID + "'";

            COVID_19_DIAGNOSTIC_SYSTEM.connection.ServerConnection.executeSQL(mySQL2);
            UC_Patients patAge = new UC_Patients();
            patAge.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(patAge);
            patAge.BringToFront();


        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string sex;
            sex = label2.Text;
            string uniqueID = login.getEmail;
            //  MessageBoxButtons btn = MessageBoxButtons.OK;

            // INSERTING THE QUERIES
            string mySQL2 = string.Empty;
            //BSDate,customer,cust_contact,bird_quantity,feedType,feedQuant,waterQuant,eggCap,bagEggCap,mortality,price
            mySQL2 = "UPDATE patient_tab SET patient_sex ='" + sex + "' WHERE email_id ='" + uniqueID + "'";

            COVID_19_DIAGNOSTIC_SYSTEM.connection.ServerConnection.executeSQL(mySQL2);
            UC_Patients patAge = new UC_Patients();
            patAge.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(patAge);
            patAge.BringToFront();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Dashboard dash = (Dashboard)this.FindForm();
            dash.hideVal();
            IntroTabSec2 newtab = new IntroTabSec2();
            newtab.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(newtab);
            newtab.BringToFront();
        }
    }
}

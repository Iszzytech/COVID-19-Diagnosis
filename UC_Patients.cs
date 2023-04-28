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
    public partial class UC_Patients : UserControl
    {
        public UC_Patients()
        {
            InitializeComponent();
        }

        private void slider_transparent_Scroll(object sender, ScrollEventArgs e)
        {
            label_TR_value.Text = slider_transparent.Value.ToString();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            UCpatients1 patAge = new UCpatients1();
            patAge.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(patAge);
            patAge.BringToFront();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string age;
            age = label_TR_value.Text;

            string uniqueID = login.getEmail;
            //  MessageBoxButtons btn = MessageBoxButtons.OK;

            // INSERTING THE QUERIES
            string mySQL2 = string.Empty;
            //BSDate,customer,cust_contact,bird_quantity,feedType,feedQuant,waterQuant,eggCap,bagEggCap,mortality,price
            mySQL2 = "UPDATE patient_tab SET age ='" + age + "' WHERE email_id ='" + uniqueID + "'";
            COVID_19_DIAGNOSTIC_SYSTEM.connection.ServerConnection.executeSQL(mySQL2);
            Dashboard das = (Dashboard)this.FindForm();
            das.returnVal2();
            symptomTab1  symp1 = new symptomTab1();
            symp1.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(symp1);
            symp1.BringToFront();
        }
    }
}
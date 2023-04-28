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
    public partial class symptom5Tab : UserControl
    {
        public symptom5Tab()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string answer = label1.Text;
            string uniqueID = login.getEmail;
            //  MessageBoxButtons btn = MessageBoxButtons.OK;

            // INSERTING THE QUERIES
            string mySQL2 = string.Empty;
            //BSDate,customer,cust_contact,bird_quantity,feedType,feedQuant,waterQuant,eggCap,bagEggCap,mortality,price
            mySQL2 = "UPDATE symptom_diagnosis SET breathing_fast ='" + answer + "' WHERE email_id ='" + uniqueID + "'";

            COVID_19_DIAGNOSTIC_SYSTEM.connection.ServerConnection.executeSQL(mySQL2);
            symptomTab6 patAge = new symptomTab6();
            patAge.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(patAge);
            patAge.BringToFront();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string answer = label2.Text;
            string uniqueID = login.getEmail;
            //  MessageBoxButtons btn = MessageBoxButtons.OK;

            // INSERTING THE QUERIES
            string mySQL2 = string.Empty;
            //BSDate,customer,cust_contact,bird_quantity,feedType,feedQuant,waterQuant,eggCap,bagEggCap,mortality,price
            mySQL2 = "UPDATE symptom_diagnosis SET breathing_fast ='" + answer + "' WHERE email_id ='" + uniqueID + "'";

            COVID_19_DIAGNOSTIC_SYSTEM.connection.ServerConnection.executeSQL(mySQL2);
            symptomTab6 patAge = new symptomTab6();
            patAge.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(patAge);
            patAge.BringToFront();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            symptomTab4 patAge = new symptomTab4();
            patAge.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(patAge);
            patAge.BringToFront();
        }
    }
}

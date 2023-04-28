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
    public partial class symptomTab3 : UserControl
    {
        public symptomTab3()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string fever = "";
            string ID = login.getEmail;

            if (radA.Checked)
            {
                fever = radA.Text;
            }

            if (radB.Checked)
            {
                fever = radB.Text;
            }

            if (radC.Checked)
            {
                fever = radC.Text;
            }

            if (radD.Checked)
            {
                symptomTab4 symd2 = new symptomTab4();
                symd2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(symd2);
                symd2.BringToFront();
            }
            string mySQL = string.Empty;

            mySQL = "UPDATE symptom_diagnosis SET fever_temp = '" + fever + "' WHERE email_id = '" + ID + "'";
            ServerConnection.executeSQL(mySQL);

            symptomTab4 sym2 = new symptomTab4();
            sym2.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(sym2);
            sym2.BringToFront();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            symptomNew sym1 = new symptomNew();
            sym1.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(sym1);
            sym1.BringToFront();
        }
    }
}

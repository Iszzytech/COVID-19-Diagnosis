using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COVID_19_DIAGNOSTIC_SYSTEM.connection;

namespace COVID_19_DIAGNOSTIC_SYSTEM
{
    public partial class Dashboard : Form
    {
        //Creating Instance Object
        static Dashboard _obj;

        public static Dashboard Instance
        {
            get
            {

                if (_obj == null)
                {
                    _obj = new Dashboard();

                }
                return _obj;

            }

        }

        public Panel panelCont
        {
            get { return panel5; }
            set { panel5 = value; }
        }

        public Label sessionID
        {
            get { return sessionemailID; }
            set { sessionemailID = value; }
        }
        public Label patientLab
        {
            get { return labelPatients; }
            set { labelPatients = value; }
        }

        public Guna.UI.WinForms.GunaCircleButton  colorInd2
        {
            get { return ColorIndicator2; }
            set { ColorIndicator2 = value; }
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            sessionemailID.Text = login.getEmail;
            ColorIndicator1.Visible = true;
            labelStage.ForeColor = System.Drawing.ColorTranslator.FromHtml("#007ABB");

            DataTable CustomerData = ServerConnection.executeSQL("SELECT fullname FROM patient_tab WHERE email_id = '" + sessionemailID.Text + "'");
            foreach (DataRow dr in CustomerData.Rows)
            {
                user.Text = (dr["fullname"].ToString());
            }
            bunifuTransition1.ShowSync(display, false, BunifuAnimatorNS.Animation.Scale);
            display.Visible = true;
        }

        public void returnVal()
        {
            ColorIndicator2.Visible = true;
            labelPatients.ForeColor = System.Drawing.ColorTranslator.FromHtml("#007ABB");

        }

        public void returnVal2()
        {
            ColorIndicator3.Visible = true;
            label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#007ABB");

        }

        public void returnVal3()
        {
            ColorIndicator4.Visible = true;
            label3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#007ABB");

        }

        public void hideVal()
        {
            ColorIndicator2.Visible = false;
            labelPatients.ForeColor = System.Drawing.ColorTranslator.FromHtml("#696969");
        }
        public void hideVal2()
        {
            ColorIndicator3.Visible = false;
            label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#696969");
        }
        private void labelStage_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void result1_Load(object sender, EventArgs e)
        {

        }

        private void introTab1_Load(object sender, EventArgs e)
        {

        }
    }
}

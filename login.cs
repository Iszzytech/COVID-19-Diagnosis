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
    public partial class login : UserControl
    {
        public static string getEmail;
        public login()
        {
            InitializeComponent();
        }

        private void textbox_email_Enter(object sender, EventArgs e)
        {
            if (textbox_email.Text == "Email Address")
            {
                textbox_email.Text = "";
                textbox_email.ForeColor = System.Drawing.ColorTranslator.FromHtml("#098DFF");
            }
        }

        private void textbox_email_Leave(object sender, EventArgs e)
        {
            if (textbox_email.Text == "")
            {
                textbox_email.Text = "Email Address";
                textbox_email.ForeColor = System.Drawing.ColorTranslator.FromHtml("#098DFF");
            }
        }

        private void textbox_password_Enter(object sender, EventArgs e)
        {
            if (textbox_password.Text == "Password")
            {
                textbox_password.Text = "";
                textbox_password.ForeColor = System.Drawing.ColorTranslator.FromHtml("#098DFF");
            }
        }

        private void textbox_password_Leave(object sender, EventArgs e)
        {
            if (textbox_password.Text == "")
            {
                textbox_password.Text = "Password";
                textbox_password.ForeColor = System.Drawing.ColorTranslator.FromHtml("#098DFF");
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            String email = textbox_email.Text;
            String passW = textbox_password.Text;

            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(passW))
            {
                string mySQL = string.Empty;

                mySQL += "SELECT * FROM patient_tab ";
                mySQL += "WHERE email_id = '" + email + "'";
                mySQL += "AND password = '" + passW + "'";

                DataTable userData = ServerConnection.executeSQL(mySQL);

                if (userData.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful", "Redirecting to Dashboard");
                    getEmail = textbox_email.Text;

                    this.ParentForm.Hide();
                    Dashboard Dash = new Dashboard();
                    Dash.Show();
                }
                else
                {
                    MessageBox.Show("Email or Password is incorrect", "Try again!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textbox_password.Focus();
                    textbox_password.SelectAll();

                }


            }
        }
    }
}

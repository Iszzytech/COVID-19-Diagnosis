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
    public partial class signuptab : UserControl
    {
        public signuptab()
        {
            InitializeComponent();
        }

        private void textbox_fullname_Enter(object sender, EventArgs e)
        {
            if (textbox_fullname.Text == "Full Name")
            {
                textbox_fullname.Text = "";
                textbox_fullname.ForeColor = System.Drawing.ColorTranslator.FromHtml("#098DFF");
            }
        }

        private void textbox_fullname_Leave(object sender, EventArgs e)
        {
            if (textbox_fullname.Text == "")
            {
                textbox_fullname.Text = "Full Name";
                textbox_fullname.ForeColor = System.Drawing.ColorTranslator.FromHtml("#098DFF");
            }
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
            String fullname;
            String email;
            String password;

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Error;

            fullname = textbox_fullname.Text;
            email = textbox_email.Text;
            password = textbox_password.Text;

            if (string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("Please enter your full name", "Field Missing", btn, ico);
                textbox_fullname.Select();
                return;

            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email", "Field Missing", btn, ico);
                textbox_email.Select();
                return;

            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password", "Field Missing", btn, ico);
                textbox_password.Select();
                return;

            }

            //----------------------- TO CHECK IF USER EXIST --------------------
            string mySQL = "SELECT email_id FROM patient_tab WHERE email_id = '" + email + "'";
            DataTable checkDuplicates = COVID_19_DIAGNOSTIC_SYSTEM.connection.ServerConnection.executeSQL(mySQL);

            if (checkDuplicates.Rows.Count > 0)
            {
                MessageBox.Show("Email Already Exist ", "Please try using another email", btn, ico);
                textbox_email.SelectAll();
                return;
            }
            else
            {
                string mySQL2 = string.Empty;

                mySQL2 += "INSERT INTO patient_tab (fullname, email_id, password) ";
                mySQL2 += "VALUES ('" + fullname + "','" + email + "','" + password + "')";

                COVID_19_DIAGNOSTIC_SYSTEM.connection.ServerConnection.executeSQL(mySQL2);
                MessageBox.Show("User registered successfully ", "Go to login page", btn, MessageBoxIcon.Information);
            }
        }
    }
}

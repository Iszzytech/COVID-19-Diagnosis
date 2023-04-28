namespace COVID_19_DIAGNOSTIC_SYSTEM
{
    partial class RegLogPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_btn = new Guna.UI.WinForms.GunaButton();
            this.signup_btn = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signuptab1 = new COVID_19_DIAGNOSTIC_SYSTEM.signuptab();
            this.login1 = new COVID_19_DIAGNOSTIC_SYSTEM.login();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 100);
            this.panel1.TabIndex = 5;
            // 
            // login_btn
            // 
            this.login_btn.AnimationHoverSpeed = 0.07F;
            this.login_btn.AnimationSpeed = 0.03F;
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(37)))));
            this.login_btn.BaseColor = System.Drawing.Color.Transparent;
            this.login_btn.BorderColor = System.Drawing.Color.Black;
            this.login_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.login_btn.FocusedColor = System.Drawing.Color.Empty;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Image = null;
            this.login_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.login_btn.Location = new System.Drawing.Point(262, 27);
            this.login_btn.Name = "login_btn";
            this.login_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.login_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.login_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.login_btn.OnHoverImage = null;
            this.login_btn.OnPressedColor = System.Drawing.Color.Black;
            this.login_btn.Size = new System.Drawing.Size(220, 46);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Login";
            this.login_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.AnimationHoverSpeed = 0.07F;
            this.signup_btn.AnimationSpeed = 0.03F;
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.signup_btn.BaseColor = System.Drawing.Color.Transparent;
            this.signup_btn.BorderColor = System.Drawing.Color.Black;
            this.signup_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.signup_btn.FocusedColor = System.Drawing.Color.Empty;
            this.signup_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.Image = null;
            this.signup_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.signup_btn.Location = new System.Drawing.Point(42, 27);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.signup_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.signup_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.signup_btn.OnHoverImage = null;
            this.signup_btn.OnPressedColor = System.Drawing.Color.Black;
            this.signup_btn.Size = new System.Drawing.Size(220, 46);
            this.signup_btn.TabIndex = 2;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.signuptab1);
            this.panel2.Controls.Add(this.login1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 355);
            this.panel2.TabIndex = 6;
            // 
            // signuptab1
            // 
            this.signuptab1.BackColor = System.Drawing.Color.White;
            this.signuptab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signuptab1.Location = new System.Drawing.Point(0, 0);
            this.signuptab1.Name = "signuptab1";
            this.signuptab1.Size = new System.Drawing.Size(524, 355);
            this.signuptab1.TabIndex = 1;
            this.signuptab1.Load += new System.EventHandler(this.signuptab1_Load);
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.White;
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(524, 355);
            this.login1.TabIndex = 0;
            // 
            // RegLogPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegLogPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegLogPage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton login_btn;
        private Guna.UI.WinForms.GunaButton signup_btn;
        private System.Windows.Forms.Panel panel2;
        private login login1;
        private signuptab signuptab1;
    }
}
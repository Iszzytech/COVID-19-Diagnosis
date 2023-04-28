namespace COVID_19_DIAGNOSTIC_SYSTEM
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ProgressBar1 = new Guna.UI.WinForms.GunaProgressBar();
            this.Time_txt = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(743, 475);
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.gunaPictureBox1;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.ProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.ProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.ProgressBar1.Location = new System.Drawing.Point(316, 442);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(122)))), ((int)(((byte)(186)))));
            this.ProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(148)))), ((int)(((byte)(218)))));
            this.ProgressBar1.Radius = 2;
            this.ProgressBar1.Size = new System.Drawing.Size(402, 10);
            this.ProgressBar1.TabIndex = 2;
            this.ProgressBar1.Visible = false;
            // 
            // Time_txt
            // 
            this.Time_txt.AutoSize = true;
            this.Time_txt.BackColor = System.Drawing.Color.Transparent;
            this.Time_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_txt.ForeColor = System.Drawing.Color.Black;
            this.Time_txt.Location = new System.Drawing.Point(318, 421);
            this.Time_txt.Name = "Time_txt";
            this.Time_txt.Size = new System.Drawing.Size(26, 17);
            this.Time_txt.TabIndex = 5;
            this.Time_txt.Text = "0%";
            this.Time_txt.Visible = false;
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.BackColor = System.Drawing.Color.Transparent;
            this.label_value.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_value.ForeColor = System.Drawing.Color.Black;
            this.label_value.Location = new System.Drawing.Point(366, 421);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(64, 16);
            this.label_value.TabIndex = 6;
            this.label_value.Text = "Loading...";
            this.label_value.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(171)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(743, 475);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.Time_txt);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal Guna.UI.WinForms.GunaProgressBar ProgressBar1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        internal System.Windows.Forms.Label label_value;
        internal System.Windows.Forms.Label Time_txt;
    }
}


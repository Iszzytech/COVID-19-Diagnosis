namespace COVID_19_DIAGNOSTIC_SYSTEM
{
    partial class OutlineTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutlineTab));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelStage = new System.Windows.Forms.Label();
            this.ColorIndicator = new Guna.UI.WinForms.GunaCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelStage
            // 
            this.labelStage.AutoSize = true;
            this.labelStage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStage.ForeColor = System.Drawing.Color.DimGray;
            this.labelStage.Location = new System.Drawing.Point(73, 13);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(101, 19);
            this.labelStage.TabIndex = 1;
            this.labelStage.Text = "Introduction";
            // 
            // ColorIndicator
            // 
            this.ColorIndicator.AnimationHoverSpeed = 0.07F;
            this.ColorIndicator.AnimationSpeed = 0.03F;
            this.ColorIndicator.BaseColor = System.Drawing.Color.DimGray;
            this.ColorIndicator.BorderColor = System.Drawing.Color.Black;
            this.ColorIndicator.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ColorIndicator.FocusedColor = System.Drawing.Color.Empty;
            this.ColorIndicator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ColorIndicator.ForeColor = System.Drawing.Color.White;
            this.ColorIndicator.Image = null;
            this.ColorIndicator.ImageSize = new System.Drawing.Size(52, 52);
            this.ColorIndicator.Location = new System.Drawing.Point(183, 16);
            this.ColorIndicator.Name = "ColorIndicator";
            this.ColorIndicator.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.ColorIndicator.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ColorIndicator.OnHoverForeColor = System.Drawing.Color.White;
            this.ColorIndicator.OnHoverImage = null;
            this.ColorIndicator.OnPressedColor = System.Drawing.Color.Black;
            this.ColorIndicator.Size = new System.Drawing.Size(16, 16);
            this.ColorIndicator.TabIndex = 2;
            this.ColorIndicator.Click += new System.EventHandler(this.gunaCircleButton1_Click);
            // 
            // OutlineTab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ColorIndicator);
            this.Controls.Add(this.labelStage);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OutlineTab";
            this.Size = new System.Drawing.Size(209, 45);
            this.Load += new System.EventHandler(this.OutlineTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStage;
        private Guna.UI.WinForms.GunaCircleButton ColorIndicator;
    }
}

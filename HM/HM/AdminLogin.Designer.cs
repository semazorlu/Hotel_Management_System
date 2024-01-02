namespace HM
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContinueLbl = new System.Windows.Forms.Label();
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ClosePic);
            this.panel1.Controls.Add(this.ContinueLbl);
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Controls.Add(this.PasswordTb);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 497);
            this.panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // LoginBtn
            // 
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(201, 327);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(205, 40);
            this.LoginBtn.TabIndex = 18;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordTb
            // 
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.DefaultText = "";
            this.PasswordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTb.Location = new System.Drawing.Point(136, 266);
            this.PasswordTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '\0';
            this.PasswordTb.PlaceholderText = "Password";
            this.PasswordTb.SelectedText = "";
            this.PasswordTb.Size = new System.Drawing.Size(347, 38);
            this.PasswordTb.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(130, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hotel Management System";
            // 
            // ContinueLbl
            // 
            this.ContinueLbl.AutoSize = true;
            this.ContinueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ContinueLbl.Location = new System.Drawing.Point(266, 380);
            this.ContinueLbl.Name = "ContinueLbl";
            this.ContinueLbl.Size = new System.Drawing.Size(74, 25);
            this.ContinueLbl.TabIndex = 19;
            this.ContinueLbl.Text = "Cancel";
            this.ContinueLbl.Click += new System.EventHandler(this.ContinueLbl_Click);
            // 
            // ClosePic
            // 
            this.ClosePic.BackColor = System.Drawing.Color.White;
            this.ClosePic.Image = ((System.Drawing.Image)(resources.GetObject("ClosePic.Image")));
            this.ClosePic.Location = new System.Drawing.Point(548, 3);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.Size = new System.Drawing.Size(47, 52);
            this.ClosePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePic.TabIndex = 20;
            this.ClosePic.TabStop = false;
            this.ClosePic.Click += new System.EventHandler(this.ClosePic_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 521);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ContinueLbl;
        private System.Windows.Forms.PictureBox ClosePic;
    }
}
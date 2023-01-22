namespace C3AIOOP
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pic_c3 = new System.Windows.Forms.PictureBox();
            this.pic_mdrrmo = new System.Windows.Forms.PictureBox();
            this.lbl_mdrrmo = new System.Windows.Forms.Label();
            this.pnl_bot = new System.Windows.Forms.Panel();
            this.lbl_copyright = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mdrrmo)).BeginInit();
            this.pnl_bot.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.pnl_top.Controls.Add(this.pic_c3);
            this.pnl_top.Controls.Add(this.pic_mdrrmo);
            this.pnl_top.Controls.Add(this.lbl_mdrrmo);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(800, 103);
            this.pnl_top.TabIndex = 0;
            // 
            // pic_c3
            // 
            this.pic_c3.Image = ((System.Drawing.Image)(resources.GetObject("pic_c3.Image")));
            this.pic_c3.Location = new System.Drawing.Point(622, 0);
            this.pic_c3.Name = "pic_c3";
            this.pic_c3.Size = new System.Drawing.Size(81, 103);
            this.pic_c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_c3.TabIndex = 3;
            this.pic_c3.TabStop = false;
            // 
            // pic_mdrrmo
            // 
            this.pic_mdrrmo.Image = ((System.Drawing.Image)(resources.GetObject("pic_mdrrmo.Image")));
            this.pic_mdrrmo.Location = new System.Drawing.Point(84, 4);
            this.pic_mdrrmo.Name = "pic_mdrrmo";
            this.pic_mdrrmo.Size = new System.Drawing.Size(102, 95);
            this.pic_mdrrmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mdrrmo.TabIndex = 2;
            this.pic_mdrrmo.TabStop = false;
            // 
            // lbl_mdrrmo
            // 
            this.lbl_mdrrmo.AutoSize = true;
            this.lbl_mdrrmo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mdrrmo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_mdrrmo.Location = new System.Drawing.Point(192, 20);
            this.lbl_mdrrmo.Name = "lbl_mdrrmo";
            this.lbl_mdrrmo.Size = new System.Drawing.Size(424, 63);
            this.lbl_mdrrmo.TabIndex = 2;
            this.lbl_mdrrmo.Text = "Atimonan Disaster Risk Reduction Management Office\r\nand\r\nCommand, Control and Coo" +
    "rdinate Center";
            this.lbl_mdrrmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_bot
            // 
            this.pnl_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.pnl_bot.Controls.Add(this.lbl_copyright);
            this.pnl_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bot.Location = new System.Drawing.Point(0, 404);
            this.pnl_bot.Name = "pnl_bot";
            this.pnl_bot.Size = new System.Drawing.Size(800, 46);
            this.pnl_bot.TabIndex = 1;
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.AutoSize = true;
            this.lbl_copyright.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_copyright.Location = new System.Drawing.Point(220, 16);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(368, 13);
            this.lbl_copyright.TabIndex = 0;
            this.lbl_copyright.Text = "© 2000  C3 - Project Operator - 1.0.0.0 - SkyeTech - All Rights Reserved.";
            this.lbl_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_user.Location = new System.Drawing.Point(374, 197);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(61, 13);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "Username:";
            // 
            // txt_user
            // 
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user.Location = new System.Drawing.Point(219, 213);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(371, 22);
            this.txt_user.TabIndex = 1;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Location = new System.Drawing.Point(219, 254);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(371, 22);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_password.Location = new System.Drawing.Point(374, 238);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(59, 13);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password:";
            // 
            // btn_login
            // 
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_login.Location = new System.Drawing.Point(367, 282);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.pnl_bot);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mdrrmo)).EndInit();
            this.pnl_bot.ResumeLayout(false);
            this.pnl_bot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bot;
        private System.Windows.Forms.PictureBox pic_c3;
        private System.Windows.Forms.PictureBox pic_mdrrmo;
        private System.Windows.Forms.Label lbl_mdrrmo;
        private System.Windows.Forms.Label lbl_copyright;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_login;
    }
}


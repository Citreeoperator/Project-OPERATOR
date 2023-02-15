namespace C3AIOOP
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.menu_1 = new System.Windows.Forms.MenuStrip();
            this.mainmenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyrepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quarterrepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cctvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cctvformToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cctvdatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situationalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quezonOperationAndWarningSitRepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endorsementReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atimonanDRRMOGCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_dateandtime = new System.Windows.Forms.Label();
            this.pnl_bot = new System.Windows.Forms.Panel();
            this.btn_light = new System.Windows.Forms.Button();
            this.btn_dark = new System.Windows.Forms.Button();
            this.tmr_time = new System.Windows.Forms.Timer(this.components);
            this.pnl_main = new System.Windows.Forms.Panel();
            this.otherToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eZCopyPasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_1.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.pnl_bot.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_1
            // 
            this.menu_1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menu_1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainmenuToolStripMenuItem,
            this.cctvToolStripMenuItem,
            this.situationalReportToolStripMenuItem,
            this.endorsementReportsToolStripMenuItem,
            this.otherToolsToolStripMenuItem});
            this.menu_1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu_1.Location = new System.Drawing.Point(0, 53);
            this.menu_1.Name = "menu_1";
            this.menu_1.Size = new System.Drawing.Size(1920, 24);
            this.menu_1.TabIndex = 0;
            this.menu_1.Text = "menuStrip1";
            // 
            // mainmenuToolStripMenuItem
            // 
            this.mainmenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.dailyrepToolStripMenuItem,
            this.quarterrepToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.logoutToolStripMenuItem,
            this.toolStripSeparator3,
            this.ExitToolStripMenuItem});
            this.mainmenuToolStripMenuItem.Name = "mainmenuToolStripMenuItem";
            this.mainmenuToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.mainmenuToolStripMenuItem.Text = "Main Menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.homeToolStripMenuItem.Text = "Dashboard Report";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // dailyrepToolStripMenuItem
            // 
            this.dailyrepToolStripMenuItem.Name = "dailyrepToolStripMenuItem";
            this.dailyrepToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.dailyrepToolStripMenuItem.Text = "Monthly Report Dashboard";
            this.dailyrepToolStripMenuItem.Visible = false;
            this.dailyrepToolStripMenuItem.Click += new System.EventHandler(this.dailyrepToolStripMenuItem_Click);
            // 
            // quarterrepToolStripMenuItem
            // 
            this.quarterrepToolStripMenuItem.Enabled = false;
            this.quarterrepToolStripMenuItem.Name = "quarterrepToolStripMenuItem";
            this.quarterrepToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.quarterrepToolStripMenuItem.Text = "Quarterly Report Dashboard";
            this.quarterrepToolStripMenuItem.Click += new System.EventHandler(this.quarterrepToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(216, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(216, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(216, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // cctvToolStripMenuItem
            // 
            this.cctvToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cctvformToolStripMenuItem1,
            this.cctvdatabaseToolStripMenuItem});
            this.cctvToolStripMenuItem.Name = "cctvToolStripMenuItem";
            this.cctvToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.cctvToolStripMenuItem.Text = "CCTV Review Request";
            // 
            // cctvformToolStripMenuItem1
            // 
            this.cctvformToolStripMenuItem1.Name = "cctvformToolStripMenuItem1";
            this.cctvformToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.cctvformToolStripMenuItem1.Text = "Request Form";
            this.cctvformToolStripMenuItem1.Click += new System.EventHandler(this.cctvformToolStripMenuItem1_Click);
            // 
            // cctvdatabaseToolStripMenuItem
            // 
            this.cctvdatabaseToolStripMenuItem.Name = "cctvdatabaseToolStripMenuItem";
            this.cctvdatabaseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cctvdatabaseToolStripMenuItem.Text = "Request Database";
            this.cctvdatabaseToolStripMenuItem.Click += new System.EventHandler(this.cctvdatabaseToolStripMenuItem_Click);
            // 
            // situationalReportToolStripMenuItem
            // 
            this.situationalReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quezonOperationAndWarningSitRepToolStripMenuItem});
            this.situationalReportToolStripMenuItem.Name = "situationalReportToolStripMenuItem";
            this.situationalReportToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.situationalReportToolStripMenuItem.Text = "Situational Report";
            // 
            // quezonOperationAndWarningSitRepToolStripMenuItem
            // 
            this.quezonOperationAndWarningSitRepToolStripMenuItem.Name = "quezonOperationAndWarningSitRepToolStripMenuItem";
            this.quezonOperationAndWarningSitRepToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.quezonOperationAndWarningSitRepToolStripMenuItem.Text = "Quezon Operation and Warning SitRep";
            this.quezonOperationAndWarningSitRepToolStripMenuItem.Click += new System.EventHandler(this.quezonOperationAndWarningSitRepToolStripMenuItem_Click);
            // 
            // endorsementReportsToolStripMenuItem
            // 
            this.endorsementReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atimonanDRRMOGCToolStripMenuItem});
            this.endorsementReportsToolStripMenuItem.Name = "endorsementReportsToolStripMenuItem";
            this.endorsementReportsToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.endorsementReportsToolStripMenuItem.Text = "Endorsement Reports";
            // 
            // atimonanDRRMOGCToolStripMenuItem
            // 
            this.atimonanDRRMOGCToolStripMenuItem.Name = "atimonanDRRMOGCToolStripMenuItem";
            this.atimonanDRRMOGCToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.atimonanDRRMOGCToolStripMenuItem.Text = "Atimonan DRRMO GC";
            this.atimonanDRRMOGCToolStripMenuItem.Click += new System.EventHandler(this.atimonanDRRMOGCToolStripMenuItem_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Controls.Add(this.lbl_dateandtime);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1920, 53);
            this.pnl_top.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(410, 50);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "    Command, Control and Coordinate Center\r\n    Project Operator";
            // 
            // lbl_dateandtime
            // 
            this.lbl_dateandtime.AutoSize = true;
            this.lbl_dateandtime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_dateandtime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateandtime.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_dateandtime.Location = new System.Drawing.Point(1768, 0);
            this.lbl_dateandtime.Name = "lbl_dateandtime";
            this.lbl_dateandtime.Size = new System.Drawing.Size(152, 50);
            this.lbl_dateandtime.TabIndex = 0;
            this.lbl_dateandtime.Text = "MMMM dd, yyyy\r\nHH:mm:ss";
            // 
            // pnl_bot
            // 
            this.pnl_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.pnl_bot.Controls.Add(this.btn_light);
            this.pnl_bot.Controls.Add(this.btn_dark);
            this.pnl_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bot.Location = new System.Drawing.Point(0, 1012);
            this.pnl_bot.Name = "pnl_bot";
            this.pnl_bot.Size = new System.Drawing.Size(1920, 28);
            this.pnl_bot.TabIndex = 2;
            // 
            // btn_light
            // 
            this.btn_light.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.btn_light.FlatAppearance.BorderSize = 0;
            this.btn_light.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_light.Image = ((System.Drawing.Image)(resources.GetObject("btn_light.Image")));
            this.btn_light.Location = new System.Drawing.Point(1870, -9);
            this.btn_light.Name = "btn_light";
            this.btn_light.Size = new System.Drawing.Size(47, 43);
            this.btn_light.TabIndex = 1;
            this.btn_light.UseVisualStyleBackColor = false;
            this.btn_light.Click += new System.EventHandler(this.btn_light_Click);
            // 
            // btn_dark
            // 
            this.btn_dark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.btn_dark.FlatAppearance.BorderSize = 0;
            this.btn_dark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dark.Image = ((System.Drawing.Image)(resources.GetObject("btn_dark.Image")));
            this.btn_dark.Location = new System.Drawing.Point(1817, -9);
            this.btn_dark.Name = "btn_dark";
            this.btn_dark.Size = new System.Drawing.Size(47, 43);
            this.btn_dark.TabIndex = 0;
            this.btn_dark.UseVisualStyleBackColor = false;
            this.btn_dark.Click += new System.EventHandler(this.btn_dark_Click);
            // 
            // tmr_time
            // 
            this.tmr_time.Enabled = true;
            this.tmr_time.Tick += new System.EventHandler(this.tmr_time_Tick);
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(29)))));
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 77);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1920, 935);
            this.pnl_main.TabIndex = 3;
            // 
            // otherToolsToolStripMenuItem
            // 
            this.otherToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eZCopyPasterToolStripMenuItem});
            this.otherToolsToolStripMenuItem.Name = "otherToolsToolStripMenuItem";
            this.otherToolsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.otherToolsToolStripMenuItem.Text = "Other Tools";
            // 
            // eZCopyPasterToolStripMenuItem
            // 
            this.eZCopyPasterToolStripMenuItem.Name = "eZCopyPasterToolStripMenuItem";
            this.eZCopyPasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eZCopyPasterToolStripMenuItem.Text = "EZ Copy Paster";
            this.eZCopyPasterToolStripMenuItem.Click += new System.EventHandler(this.eZCopyPasterToolStripMenuItem_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1040);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_bot);
            this.Controls.Add(this.menu_1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_1;
            this.MaximizeBox = false;
            this.Name = "dashboard";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C3 - Project Operator";
            this.menu_1.ResumeLayout(false);
            this.menu_1.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_bot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_1;
        private System.Windows.Forms.ToolStripMenuItem mainmenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyrepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cctvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cctvformToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cctvdatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situationalReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quezonOperationAndWarningSitRepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endorsementReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bot;
        private System.Windows.Forms.Label lbl_dateandtime;
        private System.Windows.Forms.Timer tmr_time;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btn_dark;
        private System.Windows.Forms.Button btn_light;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atimonanDRRMOGCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quarterrepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eZCopyPasterToolStripMenuItem;
    }
}
namespace C3AIOOP
{
    partial class loadingscreen
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
            this.pb_loading = new System.Windows.Forms.ProgressBar();
            this.tmr_loading = new System.Windows.Forms.Timer(this.components);
            this.lbl_random = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pb_loading
            // 
            this.pb_loading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_loading.Location = new System.Drawing.Point(0, 67);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(512, 23);
            this.pb_loading.TabIndex = 0;
            // 
            // tmr_loading
            // 
            this.tmr_loading.Enabled = true;
            this.tmr_loading.Tick += new System.EventHandler(this.tmr_loading_Tick);
            // 
            // lbl_random
            // 
            this.lbl_random.AutoSize = true;
            this.lbl_random.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_random.Location = new System.Drawing.Point(12, 51);
            this.lbl_random.Name = "lbl_random";
            this.lbl_random.Size = new System.Drawing.Size(52, 13);
            this.lbl_random.TabIndex = 1;
            this.lbl_random.Text = "Loading:";
            // 
            // loadingscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(512, 90);
            this.Controls.Add(this.lbl_random);
            this.Controls.Add(this.pb_loading);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loadingscreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loadingscreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_loading;
        private System.Windows.Forms.Timer tmr_loading;
        private System.Windows.Forms.Label lbl_random;
    }
}
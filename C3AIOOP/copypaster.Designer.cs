namespace C3AIOOP
{
    partial class copypaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(copypaster));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_open_path = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_destinationpath = new System.Windows.Forms.Button();
            this.txt_output_path = new System.Windows.Forms.TextBox();
            this.lbl_selectfile = new System.Windows.Forms.Label();
            this.lbl_outfile = new System.Windows.Forms.Label();
            this.btn_initiate = new System.Windows.Forms.Button();
            this.pb_progressbar = new System.Windows.Forms.ProgressBar();
            this.tmr_progress = new System.Windows.Forms.Timer(this.components);
            this.bg_worker = new System.ComponentModel.BackgroundWorker();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(800, 37);
            this.pnl_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "EZ CopyPaste Tool";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(763, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(36, 34);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 1;
            // 
            // txt_open_path
            // 
            this.txt_open_path.Location = new System.Drawing.Point(63, 166);
            this.txt_open_path.Name = "txt_open_path";
            this.txt_open_path.Size = new System.Drawing.Size(485, 22);
            this.txt_open_path.TabIndex = 2;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(554, 165);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "Open File";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_destinationpath
            // 
            this.btn_destinationpath.Location = new System.Drawing.Point(635, 242);
            this.btn_destinationpath.Name = "btn_destinationpath";
            this.btn_destinationpath.Size = new System.Drawing.Size(120, 23);
            this.btn_destinationpath.TabIndex = 5;
            this.btn_destinationpath.Text = "Change Destination";
            this.btn_destinationpath.UseVisualStyleBackColor = true;
            this.btn_destinationpath.Click += new System.EventHandler(this.btn_destinationpath_Click);
            // 
            // txt_output_path
            // 
            this.txt_output_path.Location = new System.Drawing.Point(63, 242);
            this.txt_output_path.Name = "txt_output_path";
            this.txt_output_path.Size = new System.Drawing.Size(485, 22);
            this.txt_output_path.TabIndex = 4;
            // 
            // lbl_selectfile
            // 
            this.lbl_selectfile.AutoSize = true;
            this.lbl_selectfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_selectfile.Location = new System.Drawing.Point(63, 147);
            this.lbl_selectfile.Name = "lbl_selectfile";
            this.lbl_selectfile.Size = new System.Drawing.Size(61, 13);
            this.lbl_selectfile.TabIndex = 7;
            this.lbl_selectfile.Text = "Select File:";
            // 
            // lbl_outfile
            // 
            this.lbl_outfile.AutoSize = true;
            this.lbl_outfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_outfile.Location = new System.Drawing.Point(63, 226);
            this.lbl_outfile.Name = "lbl_outfile";
            this.lbl_outfile.Size = new System.Drawing.Size(111, 13);
            this.lbl_outfile.TabIndex = 8;
            this.lbl_outfile.Text = "Output Destination:";
            // 
            // btn_initiate
            // 
            this.btn_initiate.Location = new System.Drawing.Point(363, 311);
            this.btn_initiate.Name = "btn_initiate";
            this.btn_initiate.Size = new System.Drawing.Size(75, 23);
            this.btn_initiate.TabIndex = 9;
            this.btn_initiate.Text = "Initiate";
            this.btn_initiate.UseVisualStyleBackColor = true;
            this.btn_initiate.Click += new System.EventHandler(this.btn_initiate_Click);
            // 
            // pb_progressbar
            // 
            this.pb_progressbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb_progressbar.Location = new System.Drawing.Point(0, 390);
            this.pb_progressbar.Name = "pb_progressbar";
            this.pb_progressbar.Size = new System.Drawing.Size(800, 23);
            this.pb_progressbar.TabIndex = 10;
            // 
            // tmr_progress
            // 
            this.tmr_progress.Tick += new System.EventHandler(this.tmr_progress_Tick);
            // 
            // bg_worker
            // 
            this.bg_worker.WorkerReportsProgress = true;
            this.bg_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_worker_DoWork);
            this.bg_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bg_worker_ProgressChanged);
            this.bg_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_worker_RunWorkerCompleted);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(554, 242);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(75, 22);
            this.txt_quantity.TabIndex = 11;
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_quantity.Location = new System.Drawing.Point(551, 226);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(54, 13);
            this.lbl_quantity.TabIndex = 12;
            this.lbl_quantity.Text = "Quantity:";
            // 
            // copypaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.pb_progressbar);
            this.Controls.Add(this.btn_initiate);
            this.Controls.Add(this.lbl_outfile);
            this.Controls.Add(this.lbl_selectfile);
            this.Controls.Add(this.btn_destinationpath);
            this.Controls.Add(this.txt_output_path);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.txt_open_path);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "copypaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZCopy Paste Tool";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_open_path;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_destinationpath;
        private System.Windows.Forms.TextBox txt_output_path;
        private System.Windows.Forms.Label lbl_selectfile;
        private System.Windows.Forms.Label lbl_outfile;
        private System.Windows.Forms.Button btn_initiate;
        private System.Windows.Forms.ProgressBar pb_progressbar;
        private System.Windows.Forms.Timer tmr_progress;
        internal System.ComponentModel.BackgroundWorker bg_worker;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_quantity;
    }
}
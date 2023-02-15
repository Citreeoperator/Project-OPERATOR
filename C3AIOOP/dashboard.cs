using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3AIOOP
{
    public partial class dashboard : Form
    {
        //Form names
        login login = new login();
        about about = new about();
        cctvform cctvform = new cctvform();
        cctvreport cctvreport = new cctvreport();
        monthlysummary monthlysummary = new monthlysummary();
        sitrep sitrep = new sitrep();
        atimdrrmendorsement atimdrrmendorsement = new atimdrrmendorsement();
        quarterlyrep quarterlyrep = new quarterlyrep();
        copypaster copypaster = new copypaster();
        public dashboard()
        {
            InitializeComponent();
            monthlysummary.TopLevel = false;
            pnl_main.Controls.Add(monthlysummary);
            monthlysummary.BringToFront();
            monthlysummary.Show();
        }

        private void tmr_time_Tick(object sender, EventArgs e)
        {
            lbl_dateandtime.Text = DateTime.Now.ToString("MMMM dd, yyyy \nHH:mm:ss");
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monthlysummary.TopLevel = false;
            pnl_main.Controls.Add(monthlysummary);
            monthlysummary.BringToFront();
            monthlysummary.Show();
        }

        private void dailyrepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monthlysummary.TopLevel = false;
            pnl_main.Controls.Add(monthlysummary);
            monthlysummary.BringToFront();
            monthlysummary.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                login.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Nothing special here, go eat something good so you can do something.
            }
        }

        private void cctvformToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cctvform.TopLevel = false;
            pnl_main.Controls.Add(cctvform);
            cctvform.BringToFront();
            cctvform.Show();
        }

        private void cctvdatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cctvreport.TopLevel = false;
            pnl_main.Controls.Add(cctvreport);
            cctvreport.BringToFront();
            cctvreport.Show();
        }

        private void quezonOperationAndWarningSitRepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sitrep.TopLevel = false;
            pnl_main.Controls.Add(sitrep);
            sitrep.BringToFront();
            sitrep.Show();
        }

        private void btn_dark_Click(object sender, EventArgs e)
        {
            //enable dark mode
            this.BackColor = Color.FromArgb(64, 64, 64);
            btn_light.BackColor = Color.FromArgb(64, 64, 64);
            pnl_top.BackColor = Color.FromArgb(64, 64, 64);
            pnl_main.BackColor = Color.FromArgb(64, 64, 64);
            pnl_bot.BackColor = Color.FromArgb(64, 64, 64);
            lbl_dateandtime.ForeColor = Color.White;
            lbl_title.ForeColor = Color.White;
            btn_dark.Visible = false;
            btn_light.Visible = true;
        }

        private void btn_light_Click(object sender, EventArgs e)
        {
            //reset to original colors
            this.BackColor = Color.FromArgb(31, 50, 86);
            pnl_top.BackColor = Color.FromArgb(31, 50, 86);
            pnl_main.BackColor = Color.FromArgb(243, 122, 29);
            pnl_bot.BackColor = Color.FromArgb(31, 50, 86);
            lbl_dateandtime.ForeColor = Color.White;
            lbl_title.ForeColor = Color.White;
            btn_dark.Visible = true;
            btn_light.Visible = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show dialog
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //if yes, exit
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //if no, do nothing
            }
        }

        private void atimonanDRRMOGCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atimdrrmendorsement.TopLevel = false;
            pnl_main.Controls.Add(atimdrrmendorsement);
            atimdrrmendorsement.BringToFront();
            atimdrrmendorsement.Show();
        }

        private void quarterrepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quarterlyrep.TopLevel = false;
            pnl_main.Controls.Add(quarterlyrep);
            quarterlyrep.BringToFront();
            quarterlyrep.Show();
        }

        private void eZCopyPasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copypaster.Show();
        }
    }
}

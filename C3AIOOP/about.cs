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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
            versionchecker();
        }

        private void versionchecker()
        {
            lbl_version.Text = "Version: " + Application.ProductVersion;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

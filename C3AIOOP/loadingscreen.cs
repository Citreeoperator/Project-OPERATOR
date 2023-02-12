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
    public partial class loadingscreen : Form
    {
        public loadingscreen()
        {
            InitializeComponent();
        }

        private void tmr_loading_Tick(object sender, EventArgs e)
        {
            int i;
            int j;
            Random rnd = new Random();
            i = rnd.Next(1, 5);
            j = rnd.Next(1, 10000);
            string[] lines = System.IO.File.ReadAllLines(@"wordlist.txt");


            lbl_random.Text = "Loading components: c:/ProjectOPERATOR/" + lines[j];
            
            pb_loading.Increment(i);
            if (pb_loading.Value == 100)
            {
                tmr_loading.Stop();
                this.Hide();
                dashboard dashboard = new dashboard();
                dashboard.Show();
            }
        }
    }
}

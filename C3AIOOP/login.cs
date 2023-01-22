using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C3AIOOP
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            copyrightchecker();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(connectionsclass.myConnection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM logininformation WHERE infousername= '" + this.txt_user.Text + "' AND infopassword= '" + this.txt_pass.Text + "';", myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmd.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    this.Hide();
                    dashboard dashboard = new dashboard();
                    dashboard.Show();

                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Username or Password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "/n Please try again or contact System Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copyrightchecker()
        {
            lbl_copyright.Text = "© " + DateTime.Now.Year.ToString() + " C3 - Project Operator - " + Application.ProductVersion  + " - SkyeTech - All Rights Reserved.";
        }
    }
}

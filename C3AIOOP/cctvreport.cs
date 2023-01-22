using MySql.Data.MySqlClient;
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
    public partial class cctvreport : Form
    {
        public cctvreport()
        {
            InitializeComponent();
            DisplayValue();
        }

        private void DisplayValue()
        {
            MySqlConnection myConn = new MySqlConnection(connectionsclass.myConnection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM db_c3blackops.c3_request_form", myConn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridReports.DataSource = dt;
            dataGridReports.Update();
            dataGridReports.Refresh();
        }

        private void cctvreport_Load(object sender, EventArgs e)
        {
            DisplayValue();
            txt_search.Text = "";
            drop_searchfilter.Text = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConn = new MySqlConnection(connectionsclass.myConnection);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM db_c3blackops.c3_request_form WHERE " + drop_searchfilter.Text + " LIKE '%" + txt_search.Text + "%'", myConn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridReports.DataSource = dt;
                dataGridReports.Update();
                dataGridReports.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPlease try again." + " If the problem persists, please contact your system administrator.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonCSDL
{
    public partial class frm_Muon : Form
    {
        public frm_Muon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Muon_Load(object sender, EventArgs e)
        {
            if_dtgMuonSach.DataSource = getMuon().Tables[0];
            if_dtgMuonSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if_dtgMuonSach.Enabled = false;

            DataSet getMuon()
            {
                DataSet data = new DataSet();
                string query = "select * from Muon";
                using (SqlConnection conn = new SqlConnection(ConnectionString.con))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    conn.Close();
                    adapter.Fill(data);

                }
                return data;
            }
        }
    }
}

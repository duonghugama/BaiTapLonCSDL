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
    public partial class frm_Tra : Form
    {
        public frm_Tra()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Tra_Load(object sender, EventArgs e)
        {
            if_dtgTra.DataSource = getTra().Tables[0];
            if_dtgTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if_dtgTra.Enabled = false;
        }

        DataSet getTra()
        {
            DataSet data = new DataSet();
            string query = "select * from Tra";
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonCSDL
{
    public partial class frm_QuanLyDocGia : Form
    {
        SqlConnection conn = new SqlConnection(ConnectionString.con);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public frm_QuanLyDocGia()
        {
            InitializeComponent();
            


        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_QuanLyDocGia_Load(object sender, EventArgs e)
        {
            dtgQuanLyDocGia.DataSource = getQuanLyDocGia().Tables[0];
            dtgQuanLyDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgQuanLyDocGia.Enabled = false;
        }

        DataSet getQuanLyDocGia()
        {
            DataSet data = new DataSet();
            string query = "select * from DocGia";
            
            using (conn)
            {
                conn.Open();
                adapter = new SqlDataAdapter(query, conn);
                conn.Close();
                adapter.Fill(data);

            }
            return data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            conn.Open();
            cmd = new SqlCommand("insert into DocGia values ('"+ txtMaNM.Text + " ',' " + txtTenNM.Text + " " +
                ",' " + grB_GioiTinh.Text + ",' " + dtpNgaySinh.Text + ",' " + txtKhoa.Text + ",' " 
                + txtGhiChu.Text + " ') ", conn);
            cmd.ExecuteNonQuery();
              
                conn.Close();

            
            getQuanLyDocGia();

            
        }
    }
}

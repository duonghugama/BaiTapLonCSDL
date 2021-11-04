using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTapLonCSDL
{
    public partial class frm_QuanLyNhanVien : Form
    {
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection(ConnectionString.con);
            con.Open();
            string query = "delete from nhanvien where MaNV = '" + txtTim.Text + "'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvTaikhoan.DataSource = table;
            con.Close();
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           
            dgvTaikhoan.DataSource = getallnhanvien().Tables[0];
            
        }
        DataSet getallnhanvien()
        {
            DataSet data = new DataSet();
            string query = "select * from nhanvien";
            using (SqlConnection con = new SqlConnection(ConnectionString.con))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        

        private void btnXem_Click(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection(ConnectionString.con);
            con.Open();
            string query = "select * from nhanvien where MaNV = '"+txtTim.Text+"'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvTaikhoan.DataSource = table;
            con.Close();
        }
    }
}

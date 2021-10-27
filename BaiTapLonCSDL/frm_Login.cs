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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (checkUser(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                frm_TrangChu frm = new frm_TrangChu();
                frm.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Đăng nhập thất bại");
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DataSet GetUser()
        {
            DataSet dt = new DataSet();
            string query = "select * from nhanvien";
            using (SqlConnection con = new SqlConnection(ConnectionString.con))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dt);
                con.Close();
            }
            return dt;
        }
        bool checkUser(string userName, string Password)
        {
            DataSet dt = new DataSet();
            string query = "select * from nhanvien where TenDangNhap = N'"+ userName +"' And MatKhau = N'"+ Password +"'";
            using (SqlConnection con = new SqlConnection(ConnectionString.con))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dt);
                con.Close();
            }
            if (dt.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

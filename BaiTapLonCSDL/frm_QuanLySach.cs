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
    public partial class frm_QuanLySach : Form
    {
        SqlConnection con;
        SqlCommand command;
        string str = @"Data Source=2131204W\SQLEXPRESS;Initial Catalog=BaiTapLonHQT;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = con.CreateCommand();
            command.CommandText = "select * from sach";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        public frm_QuanLySach()
        {
            InitializeComponent();
            
        }

        

        private void btnXem_Click(object sender, EventArgs e)
        {
            txtMasach.Text = "";
            txtTensach.Text = "";
            TxtNXB.Text = "";
            txtMaloai.Text = "";
            txtGiasach.Text = "";
            txtSoluong.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "insert into sach values('"+txtMasach.Text+"','"+txtTensach.Text+ "','"+TxtNXB.Text+ "','"+txtGiasach.Text+ "','"+txtMaloai.Text+ "','"+txtSoluong.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
        }
        

        private void frm_QuanLySach_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasach.ReadOnly = true;
            txtMaloai.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMasach.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTensach.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            TxtNXB.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtMaloai.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtGiasach.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtSoluong.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "delete from sach where MaSach = '" +txtMasach.Text+ "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "update sach set tensach='"+txtTensach.Text+"',NXB = '"+TxtNXB.Text+"',giasach ='"+txtGiasach.Text+"',soluong = '"+txtSoluong.Text+"' where masach = '"+txtMasach.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}

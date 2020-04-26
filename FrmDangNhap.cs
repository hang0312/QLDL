using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=QLCongTyDuLich;Integrated Security=True");
            string sqlSelect = "Select * from DangNhap where TenDangNhap=N'" + txtDangNhap.Text + "'and MatKhau=N'" + txtMatKhau.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                this.Hide();
                Form main = new FrmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu. Bạn hãy nhập lại !");
                txtDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtDangNhap.Focus();
            }
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

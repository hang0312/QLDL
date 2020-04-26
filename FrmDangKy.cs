using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            txtMatKhau1.Enabled = false;
            txtTenDangNhap1.Enabled = false;
            btnLuu1.Enabled = false;
        }
        private void reset()
        {
            txtMatKhau1.Text = "";
            txtTenDangNhap1.Text = "";
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            btnLuu1.Enabled = true;
            txtMatKhau1.Enabled = true;
            txtTenDangNhap1.Enabled = true;
            txtTenDangNhap1.Focus();
            reset();
        }

        private void btnBoQua1_Click(object sender, EventArgs e)
        {
            btnLuu1.Enabled = false;
            reset();
            txtTenDangNhap1.Focus();
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap1.Focus();
                return;

            }
            if (txtMatKhau1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau1.Focus();
                return;

            }

            string a;
            a = "select TenDangNhap from DangNhap where TenDangNhap=N'" + txtTenDangNhap1.Text + "'";
            if (Functions.CheckKey(a))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap1.Focus();
                txtTenDangNhap1.Text = "";
                return;
            }
            a = "insert into DangNhap(TenDangNhap,MatKhau) values(N'" + txtTenDangNhap1.Text + "',N'" + txtMatKhau1.Text + "')";
            Functions.RunSql(a);
            MessageBox.Show("Đăng ký thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            btnLuu1.Enabled = false;
            reset();
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

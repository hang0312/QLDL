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
    public partial class FrmKhachHang : Form
    {
        DataTable tblKhachHang;
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            
            LoadDataToGridview();
            Functions.FillCombo("select MaQuocTich from QuocTich", cboQuocTich, "MaQuocTich");
            cboQuocTich.SelectedIndex = -1;
        }
        private void LoadDataToGridview()
        {
            string sql = "select * from KhachHang";
            tblKhachHang = Functions.LoadDataToTable(sql);
            dataGridView_KhachHang.DataSource = tblKhachHang;
        }
        private void ResetValues()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            cboQuocTich.Text = "";
            txtGhiChu.Text = "";
        }

        private void dataGridView_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhach.Text = dataGridView_KhachHang.CurrentRow.Cells["MaKhach"].Value.ToString();
            txtTenKhach.Text = dataGridView_KhachHang.CurrentRow.Cells["TenKhach"].Value.ToString();
            txtDiaChi.Text = dataGridView_KhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = dataGridView_KhachHang.CurrentRow.Cells["DienThoai"].Value.ToString();
            cboQuocTich.Text = dataGridView_KhachHang.CurrentRow.Cells["QuocTich"].Value.ToString();
            txtGhiChu.Text = dataGridView_KhachHang.CurrentRow.Cells["GhiChu"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            
            int count = 0;
            count = dataGridView_KhachHang.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridView_KhachHang.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                txtMaKhach.Text = "KH00" + (chuoi2 + 1).ToString();
            }
            else
                if (chuoi2 + 1 < 100)
            {
                txtMaKhach.Text = "KH0" + (chuoi2 + 1).ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã khách hàng");
                txtMaKhach.Focus();
                return;
            }
            if (txtTenKhach.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên khách hàng");
                txtTenKhach.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn cần nhập địa chỉ");
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Bạn cần nhập số điện thoại");
                txtDienThoai.Focus();
                return;
            }
            if (cboQuocTich.Text == "")
            {
                MessageBox.Show("Bạn cần chọn quốc tịch");
                cboQuocTich.Focus();
                return;
            }
            if (txtGhiChu.Text == "")
            {
                MessageBox.Show("Bạn cần nhập ghi chú");
                txtGhiChu.Focus();
                return;
            }
            sql = "select MaKhach from KhachHang where MaKhach= '" + txtMaKhach.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhach.Focus();
                txtMaKhach.Text = "";
                return;
            }
            sql = "insert into KhachHang values ('" + txtMaKhach.Text + "', N'" + txtTenKhach.Text + "', N'" + txtDiaChi.Text +
                "', " + txtDienThoai.Text + ", '" + cboQuocTich.Text + "', N'" + txtGhiChu.Text + "')";
            Functions.RunSql(sql);
            LoadDataToGridview();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "update KhachHang set TenKhach= N'" + txtTenKhach.Text + "', DiaChi= N'" + txtDiaChi.Text +
                "', DienThoai= " + txtDienThoai.Text + ", QuocTich= '" + cboQuocTich.Text + "', GhiChu= N'" + txtGhiChu.Text +
                "' where MaKhach= '" + txtMaKhach.Text + "'";
            Functions.RunSql(sql);
            LoadDataToGridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete from KhachHang where MaKhach= '" + txtMaKhach.Text + "'";
                Functions.RunSql(sql);
                LoadDataToGridview();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadDataToGridview();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

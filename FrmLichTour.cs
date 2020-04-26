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
    public partial class FrmLichTour : Form
    {
        
        DataTable tblLichTour;
        public FrmLichTour()
        {
            InitializeComponent();
        }

        private void FrmLichTour_Load(object sender, EventArgs e)
        {
            
            LoadDataToGridview();
            Functions.FillCombo("select MaCongTy from CongTy", cboMaCongTy, "MaCongTy");
            cboMaCongTy.SelectedIndex = -1;
        }
        private void LoadDataToGridview()
        {
            string sql = "select * from LichTour";
            tblLichTour = Functions.LoadDataToTable(sql);
            dataGridView_LichTour.DataSource = tblLichTour;
        }

        private void dataGridView_LichTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLichTour.Text = dataGridView_LichTour.CurrentRow.Cells["MaLichTour"].Value.ToString();
            cboMaCongTy.Text = dataGridView_LichTour.CurrentRow.Cells["MaCongTy"].Value.ToString();
            cboMaTour.Text = dataGridView_LichTour.CurrentRow.Cells["MaTour"].Value.ToString();
            cboMaHDV.Text = dataGridView_LichTour.CurrentRow.Cells["MaHDV"].Value.ToString();
            mskNgayKhoiHanh.Text = dataGridView_LichTour.CurrentRow.Cells["NgayKhoiHanh"].Value.ToString();
            txtSoNguoiDangKy.Text = dataGridView_LichTour.CurrentRow.Cells["SoNguoiDangKy"].Value.ToString();
            txtTongTien.Text = dataGridView_LichTour.CurrentRow.Cells["TongTien"].Value.ToString();
            txtDaKhoiHanh.Text = dataGridView_LichTour.CurrentRow.Cells["DaKhoiHanh"].Value.ToString();
        }
        private void ResetValues()
        {
            txtMaLichTour.Text = "";
            txtDaKhoiHanh.Text = "";
            txtSoNguoiDangKy.Text = "";
            txtTongTien.Text = "";
            cboMaCongTy.Text = "";
            cboMaHDV.Text = "";
            cboMaTour.Text = "";
            mskNgayKhoiHanh.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaLichTour.Enabled = false;
            int count = 0;
            count = dataGridView_LichTour.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridView_LichTour.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                txtMaLichTour.Text = "LT0" + (chuoi2 + 1).ToString();
            }
            else
                if (chuoi2 + 1 < 100)
            {
                txtMaLichTour.Text = "LT" + (chuoi2 + 1).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblLichTour.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLichTour.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete from LichTour where MaLichTour= '" + txtMaLichTour.Text + "'";
                Functions.RunSql(sql);
                LoadDataToGridview();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblLichTour.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLichTour.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "update LichTour set MaCongTy= '" + cboMaCongTy.Text + "', MaTour= '" + cboMaTour.Text + "', MaHDV= '" + cboMaHDV.Text +
                "', NgayKhoiHanh= '" + Functions.ConvertDateTime(mskNgayKhoiHanh.Text) + "', SoNguoiDangKy= " + txtSoNguoiDangKy.Text +
                ", TongTien= " + txtTongTien.Text + ", DaKhoiHanh= N'" + txtDaKhoiHanh.Text + "' where MaLichTour= '" + txtMaLichTour.Text + "'";
            Functions.RunSql(sql);
            LoadDataToGridview();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (cboMaCongTy.Text == "")
            {
                MessageBox.Show("Bạn cần chọn mã công ty");
                cboMaCongTy.Focus();
                return;
            }
            if (cboMaTour.Text == "")
            {
                MessageBox.Show("Bạn cần chọn mã tour");
                cboMaTour.Focus();
                return;
            }
            if (cboMaHDV.Text == "")
            {
                MessageBox.Show("Bạn cần chọn mã hướng dẫn viên");
                cboMaHDV.Focus();
                return;
            }
            if (mskNgayKhoiHanh.Text == "  /  /    ")
            {
                MessageBox.Show("Bạn cần nhập ngày khởi hành");
                mskNgayKhoiHanh.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgayKhoiHanh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày khởi hành", " Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mskNgayKhoiHanh.Text = "";
                mskNgayKhoiHanh.Focus();
                return;
            }
            if (txtSoNguoiDangKy.Text == "")
            {
                MessageBox.Show("Bạn cần nhập số người đăng ký");
                txtSoNguoiDangKy.Focus();
                return;
            }
            if (txtTongTien.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tổng tiền");
                txtTongTien.Focus();
                return;
            }
            if (txtDaKhoiHanh.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đã khởi hành ");
                txtDaKhoiHanh.Focus();
                return;
            }
            sql = "select MaLichTour from LichTour where MaLichTour= '" + txtMaLichTour.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã lịch tour này đã tồn tại, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLichTour.Focus();
                txtMaLichTour.Text = "";
                return;
            }
            sql = "insert into LichTour values ('" + txtMaLichTour.Text + "', '" + cboMaCongTy.Text + "', '" + cboMaTour.Text +
                    "', '" + cboMaHDV.Text + "', '" + Functions.ConvertDateTime(mskNgayKhoiHanh.Text) + "', " + txtSoNguoiDangKy.Text +
                    ", " + txtTongTien.Text + ", N'" + txtDaKhoiHanh.Text + "')";

            Functions.RunSql(sql);
            LoadDataToGridview();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sql;

            sql = "select * from LichTour where 1=1";
            if (cboMaCongTy.Text != "")
            {
                sql = sql + "and MaCongTy= '" + cboMaCongTy.SelectedValue + "'";
            }
            if (cboMaTour.Text != "")
            {
                sql = sql + "and MaTour= '" + cboMaTour.SelectedValue + "'";
            }
            if (cboMaHDV.Text != "")
            {
                sql = sql + "and MaHDV= '" + cboMaHDV.SelectedValue + "'";
            }
            tblLichTour = Functions.LoadDataToTable(sql);
            if (tblLichTour.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thỏa mãn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Có " + tblLichTour.Rows.Count + " bản ghi thỏa mãn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView_LichTour.DataSource = tblLichTour;
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

        private void cboMaCongTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.FillCombo("select distinct MaTour from LichTour where MaCongTy= '" + cboMaCongTy.SelectedValue + "'",
                cboMaTour, "MaTour");
            cboMaTour.SelectedIndex = -1;
        }

        private void cboMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.FillCombo("select distinct MaHDV from LichTour where MaCongTy= '" + cboMaCongTy.SelectedValue +
                "' and MaTour= '" + cboMaTour.SelectedValue + "'", cboMaHDV, "MaHDV");

            cboMaHDV.SelectedIndex = -1;
        }
    }
}

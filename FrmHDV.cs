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
    public partial class FrmHDV : Form
    {
        
        DataTable tblHDV;
        public FrmHDV()
        {
            InitializeComponent();
        }

        private void FrmHDV_Load(object sender, EventArgs e)
        {
            
            LoadDataToGridview();
            Functions.FillCombo("select MaCongTy from CongTy", cboMaCongTy, "MaCongTy");
            cboMaCongTy.SelectedIndex = -1;
            Functions.FillCombo("select MaTruongDT from TruongDaoTao", cboMaTruongDaoTao, "MaTruongDT");
            cboMaTruongDaoTao.SelectedIndex = -1;
            Functions.FillCombo("select MaTrinhDo from TrinhDo", cboMaTrinhDo, "MaTrinhDo");
            cboMaTrinhDo.SelectedIndex = -1;
            Functions.FillCombo("select MaTinh from Tinh", cboMaTinh, "MaTinh");
            cboMaTinh.SelectedIndex = -1;
        }
        private void LoadDataToGridview()
        {
            string sql = "select * from HuongDanVien";
            tblHDV = Functions.LoadDataToTable(sql);
            dataGridView_HDV.DataSource = tblHDV;
        }

        private void dataGridView_HDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHDV.Text = dataGridView_HDV.CurrentRow.Cells["MaHDV"].Value.ToString();
            txtTenHDV.Text = dataGridView_HDV.CurrentRow.Cells["TenHDV"].Value.ToString();
            cboMaCongTy.Text = dataGridView_HDV.CurrentRow.Cells["MaCongTy"].Value.ToString();
            mskNgaySinh.Text = dataGridView_HDV.CurrentRow.Cells["NgaySinh"].Value.ToString();
            if (dataGridView_HDV.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
                chkNam.Checked = true;
            else
                chkNam.Checked = false;

            cboMaTinh.Text = dataGridView_HDV.CurrentRow.Cells["MaTinh"].Value.ToString();
            cboMaTrinhDo.Text = dataGridView_HDV.CurrentRow.Cells["MaTrinhDo"].Value.ToString();
            cboMaTruongDaoTao.Text = dataGridView_HDV.CurrentRow.Cells["MaTruongDT"].Value.ToString();
            mskNgayVaoCongTy.Text = dataGridView_HDV.CurrentRow.Cells["NgayVaoCongTy"].Value.ToString();
        }
        private void resetValues()
        {
            txtMaHDV.Text = "";
            txtTenHDV.Text = "";
            cboMaCongTy.Text = "";
            mskNgaySinh.Text = "";
            chkNam.Checked = false;
            cboMaTinh.Text = "";
            cboMaTrinhDo.Text = "";
            cboMaTruongDaoTao.Text = "";
            mskNgayVaoCongTy.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetValues();
            txtMaHDV.Enabled = false;
            int count = 0;
            count = dataGridView_HDV.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridView_HDV.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
            {
                txtMaHDV.Text = "HDV0" + (chuoi2 + 1).ToString();
            }
            else
                if (chuoi2 + 1 < 100)
            {
                txtMaHDV.Text = "HDV" + (chuoi2 + 1).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHDV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHDV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete from HuongDanVien where MaHDV= '" + txtMaHDV.Text + "'";
                Functions.RunSql(sql);
                LoadDataToGridview();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblHDV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHDV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (chkNam.Checked == true)
                gt = "Nam";
            else gt = "Nữ";
            sql = "update HuongDanVien set TenHDV= N'" + txtTenHDV.Text +
                "', MaCongTy= '" + cboMaCongTy.Text + "', NgaySinh= '" + Functions.ConvertDateTime(mskNgaySinh.Text) + "', GioiTinh= N'" + gt +
                "', MaTinh= '" + cboMaTinh.Text + "', MaTrinhDo= '" + cboMaTrinhDo.Text + "', MaTruongDT= '" + cboMaTruongDaoTao.Text +
                "', NgayVaoCongTy= '" + Functions.ConvertDateTime(mskNgayVaoCongTy.Text) + "' where MaHDV= '" + txtMaHDV.Text + "'";
            Functions.RunSql(sql);
            LoadDataToGridview();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtTenHDV.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên hướng dẫn viên");
                txtTenHDV.Focus();
                return;
            }
            if (cboMaCongTy.Text == "")
            {
                MessageBox.Show("Bạn cần chọn mã công ty");

                return;
            }
            if (mskNgaySinh.Text == "  /  /    ")
            {
                MessageBox.Show("Bạn cần nhập ngày sinh");
                mskNgaySinh.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", " Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mskNgaySinh.Text = "";
                mskNgaySinh.Focus();
                return;
            }

            if (chkNam.Checked == true)
                gt = "Nam";
            else gt = "Nữ";

            if (cboMaTinh.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã tỉnh");
                cboMaTinh.Focus();
                return;
            }
            if (cboMaTrinhDo.Text == "")
            {
                MessageBox.Show("Bạn cần chọn mã trình độ");
                cboMaTrinhDo.Focus();
                return;
            }
            if (cboMaTruongDaoTao.Text == "")
            {
                MessageBox.Show("Bạn cần chọn mã trường đào tạo");

                return;
            }
            if (mskNgayVaoCongTy.Text == "")
            {
                MessageBox.Show("Bạn cần nhập ngày vào công ty");
                mskNgayVaoCongTy.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgayVaoCongTy.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày vào công ty", " Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mskNgayVaoCongTy.Text = "";
                mskNgayVaoCongTy.Focus();
                return;
            }
            sql = "select MaHDV from HuongDanVien where MaHDV= '" + txtMaHDV.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã HDV này đã tồn tại, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHDV.Focus();
                txtMaHDV.Text = "";
                return;
            }
            sql = "insert into HuongDanVien values ('" + txtMaHDV.Text + "', N'" + txtTenHDV.Text + "', '" + cboMaCongTy.Text +
                    "', '" + Functions.ConvertDateTime(mskNgaySinh.Text) + "', N'" + gt + "', '" + cboMaTinh.Text +
                    "', '" + cboMaTrinhDo.Text + "', '" + cboMaTruongDaoTao.Text + "', '" + Functions.ConvertDateTime(mskNgayVaoCongTy.Text) + "')";

            Functions.RunSql(sql);
            LoadDataToGridview();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetValues();
            LoadDataToGridview();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtTenHDV.Text == "") && (cboMaCongTy.Text == "") && (cboMaTruongDaoTao.Text == ""))
            {
                MessageBox.Show("Bạn cần nhập điều kiện tìm kiếm", "Yêu cầu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select * from HuongDanVien where 1=1";
            if (txtTenHDV.Text != "")
            {
                sql = sql + "and TenHDV like N'%" + txtTenHDV.Text + "%'";
            }
            if (cboMaCongTy.Text != "")
            {

                sql = sql + "and MaCongTY like N'%" + cboMaCongTy.Text + "%'";
            }
            if (cboMaTruongDaoTao.Text != "")
            {

                sql = sql + "and MaTruongDT like N'%" + cboMaTruongDaoTao.Text + "%'";
            }
            tblHDV = Functions.LoadDataToTable(sql);
            if (tblHDV.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thỏa mãn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Có " + tblHDV.Rows.Count + " bản ghi thỏa mãn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView_HDV.DataSource = tblHDV;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

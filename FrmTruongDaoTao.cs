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
    public partial class FrmTruongDaoTao : Form
    {
        DataTable tblTruongDaoTao;
        public FrmTruongDaoTao()
        {
            InitializeComponent();
        }

        private void FrmTruongDaoTao_Load(object sender, EventArgs e)
        {
            cboMaTruongDT.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            Load_DataGridView_TruongDT();
        }

        private void Load_DataGridView_TruongDT()
        {
            string sql;
            sql = "SELECT MaTruongDT, TenTruongDT, DiaChi, DienThoai FROM TruongDaoTao";
            tblTruongDaoTao = Functions.LoadDataToTable(sql);
            dataGridView_TruongDT.DataSource = tblTruongDaoTao;
            dataGridView_TruongDT.Columns[0].HeaderText = "Mã Trường ĐT";
            dataGridView_TruongDT.Columns[1].HeaderText = "Tên Trường ĐT";
            dataGridView_TruongDT.Columns[2].HeaderText = "Địa Chỉ";
            dataGridView_TruongDT.Columns[3].HeaderText = "Điện Thoại";
            dataGridView_TruongDT.Columns[0].Width = 100;
            dataGridView_TruongDT.Columns[1].Width = 100;
            dataGridView_TruongDT.Columns[2].Width = 50;
            dataGridView_TruongDT.Columns[3].Width = 30;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridView_TruongDT.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridView_TruongDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            Functions.FillCombo("select MaTruongDT from TruongDaoTao", cboMaTruongDT, "MaTruongDT");
            cboMaTruongDT.SelectedIndex = -1;
            cboMaTruongDT.Enabled = true;
            cboMaTruongDT.Focus();
        }
        private void ResetValues()
        {
            cboMaTruongDT.Text = "";
            txtTenTruongDT.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboMaTruongDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã Trường Đào tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaTruongDT.Focus();
                return;
            }
            if (txtTenTruongDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên Trường Đào tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTruongDT.Focus();
                return;
            }
            sql = "SELECT MaTruongDT FROM TruongDaoTao WHERE MaTruongDT=N'" + cboMaTruongDT.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Trường ĐT này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaTruongDT.Focus();
                cboMaTruongDT.Text = "";
                return;
            }
            sql = "INSERT INTO TruongDaoTao(MaTruongDT,TenTruongDT,DiaChi,DienThoai) VALUES(N'" + cboMaTruongDT.Text + "',N'" + txtTenTruongDT.Text + "',N'" + txtDiaChi.Text + "',N'" + txtDienThoai.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView_TruongDT();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            cboMaTruongDT.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTruongDaoTao.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMaTruongDT.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenTruongDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên Trường ĐT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTruongDT.Focus();
                return;
            }
            sql = "UPDATE TruongDaoTao SET TenTruongDT=N'" + txtTenTruongDT.Text.ToString() +"',DiaChi=N'" + txtDiaChi.Text.ToString()+ "',DienThoai=N'" + txtDienThoai.Text.ToString()
                 +"' WHERE MaTruongDT=N'" + cboMaTruongDT.SelectedValue + "'";
            Functions.RunSql(sql);
            Load_DataGridView_TruongDT();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTruongDaoTao.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMaTruongDT.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tableTruongDaoTao WHERE MaTruongDT=N'" + cboMaTruongDT.SelectedValue + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridView_TruongDT();
                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            cboMaTruongDT.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_TruongDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaTruongDT.Focus();
                return;
            }
            if (tblTruongDaoTao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cboMaTruongDT.Text = dataGridView_TruongDT.CurrentRow.Cells["MaTruongDT"].Value.ToString();
            txtTenTruongDT.Text = dataGridView_TruongDT.CurrentRow.Cells["TenTruongDT"].Value.ToString();
            txtDiaChi.Text = dataGridView_TruongDT.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = dataGridView_TruongDT.CurrentRow.Cells["DienThoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }
    }
}

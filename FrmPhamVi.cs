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
    public partial class FrmPhamVi : Form
    {
        DataTable tblPhamVi;
        public FrmPhamVi()
        {
            InitializeComponent();
        }

        private void FrmPhamVi_Load(object sender, EventArgs e)
        {
            txtMaPhamVi.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            Load_DataGridView_PhamVi();
        }

        private void Load_DataGridView_PhamVi()
        {
            string sql;
            sql = "SELECT MaPhamVi, TenPhamVi FROM PhamVi";
            tblPhamVi = Functions.LoadDataToTable(sql);
            dataGridView_PhamVi.DataSource = tblPhamVi;
            dataGridView_PhamVi.Columns[0].HeaderText = "Mã phạm vi";
            dataGridView_PhamVi.Columns[1].HeaderText = "Tên phạm vi";
            dataGridView_PhamVi.Columns[0].Width = 80;
            dataGridView_PhamVi.Columns[1].Width = 200;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridView_PhamVi.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridView_PhamVi.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaPhamVi.Text = Functions.matudong("PV", tblPhamVi);
            txtTenPhamVi.Focus();
        }

        private void ResetValues()
        {
            txtMaPhamVi.Text = "";
            txtTenPhamVi.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaPhamVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phạm vi", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhamVi.Focus();
                return;
            }
            if (txtTenPhamVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên phạm vi", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhamVi.Focus();
                return;
            }
            sql = "SELECT MaPhamVi FROM PhamVi WHERE MaPhamVi=N'" + txtMaPhamVi.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã phạm vi này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhamVi.Focus();
                txtMaPhamVi.Text = "";
                return;
            }
            sql = "INSERT INTO PhamVi(MaPhamVi,TenPhamVi) VALUES(N'" + txtMaPhamVi.Text + "',N'" + txtTenPhamVi.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView_PhamVi();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaPhamVi.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblPhamVi.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMaPhamVi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenPhamVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên phạm vi", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhamVi.Focus();
                return;
            }
            sql = "UPDATE tablePhamVi SET TenPhamVi=N'" + txtTenPhamVi.Text.ToString() + "' WHERE MaPhamVi=N'" + txtMaPhamVi.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView_PhamVi();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblPhamVi.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMaPhamVi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE PhamVi WHERE MaPhamVi=N'" + txtMaPhamVi.Text + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridView_PhamVi();
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
            txtMaPhamVi.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaPhamVi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenPhamVi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void dataGridView_PhamVi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPhamVi.Focus();
                return;
            }
            if (tblPhamVi.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaPhamVi.Text = dataGridView_PhamVi.CurrentRow.Cells["MaPhamVi"].Value.ToString();
            txtTenPhamVi.Text = dataGridView_PhamVi.CurrentRow.Cells["TenPhamVi"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }
    }
}

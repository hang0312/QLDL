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
    public partial class FrmTrinhDo : Form
    {
        DataTable tblTrinhDo;
        public FrmTrinhDo()
        {
            InitializeComponent();
        }

        private void FrmTrinhDo_Load(object sender, EventArgs e)
        {
            LoadDataToGridview();
        }
        private void LoadDataToGridview()
        {
            string sql = "select * from TrinhDo";
            tblTrinhDo = Functions.LoadDataToTable(sql);
            dataGridView_TrinhDo.DataSource = tblTrinhDo;
        }
        private void ResetValues()
        {
            txtMaTrinhDo.Text = "";
            txtTentrinhDo.Text = "";
        }

        private void dataGridView_TrinhDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTrinhDo.Text = dataGridView_TrinhDo.CurrentRow.Cells["MaTrinhDo"].Value.ToString();
            txtTentrinhDo.Text = dataGridView_TrinhDo.CurrentRow.Cells["TenTrinhDo"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaTrinhDo.Enabled = false;
            int count = 0;
            count = dataGridView_TrinhDo.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridView_TrinhDo.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                txtMaTrinhDo.Text = "TD" + (chuoi2 + 1).ToString();
            }
            else
                if (chuoi2 + 1 < 100)
            {
                txtMaTrinhDo.Text = "TD" + (chuoi2 + 1).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTrinhDo.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTrinhDo.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete from TrinhDo where MaTrinhDo= '" + txtMaTrinhDo.Text + "'";
                Functions.RunSql(sql);
                LoadDataToGridview();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTrinhDo.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTrinhDo.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "update TrinhDo set TenTrinhDo= N'" + txtTentrinhDo.Text + "' where MaTrinhDo= '" + txtMaTrinhDo.Text + "'";
            Functions.RunSql(sql);
            LoadDataToGridview();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaTrinhDo.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã trình độ");
                txtMaTrinhDo.Focus();
                return;
            }
            if (txtTentrinhDo.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên trình độ");
                txtTentrinhDo.Focus();
                return;
            }
            sql = "select MaTrinhDo from TrinhDo where MaTrinhDo= '" + txtMaTrinhDo.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã trình độ này đã tồn tại, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTrinhDo.Focus();
                txtMaTrinhDo.Text = "";
                return;
            }
            sql = "insert into TrinhDo values ('" + txtMaTrinhDo.Text + "', N'" + txtTentrinhDo.Text + "')";
            Functions.RunSql(sql);
            LoadDataToGridview();
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

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
    public partial class FrmHDV_NgoaiNgu : Form
    {
        SqlConnection con = new SqlConnection();
        DataTable tblHDVNgoaiNgu;
        public FrmHDV_NgoaiNgu()
        {
            InitializeComponent();
        }

        private void FrmHDV_NgoaiNgu_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuanLy_CongTyDuLich;Integrated Security=True";
            con.ConnectionString = connectionstring;
            con.Open();
            LoadDataToGridView();
            Functions.FillCombo("SELECT MaXepLoai FROM XepLoai ", cboMaXepLoai, "MaXepLoai");
            cboMaXepLoai.SelectedIndex = -1;
        }
        private void LoadDataToGridView()
        {
            string sql = "select * from HDV_NgoaiNgu";
            DataTable myTable = Functions.LoadDataToTable(sql);
            tblHDVNgoaiNgu = Functions.LoadDataToTable(sql);
            dataGridView_HDVNgoaiNgu.DataSource = myTable;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }
        private void RunSql(string sql)
        {

            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LoadDataToGridView();
        }
        private void resetValues()
        {
            txtMaHDV.Text = "";
            txtMaNgoaiNgu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetValues();
            txtMaHDV.Enabled = true;
        }

        private void dataGridView_HDVNgoaiNgu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHDV.Text = dataGridView_HDVNgoaiNgu.CurrentRow.Cells["MaHDV"].Value.ToString();
            txtMaNgoaiNgu.Text = dataGridView_HDVNgoaiNgu.CurrentRow.Cells["MaNgoaiNgu"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHDVNgoaiNgu.Rows.Count == 0)
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
                sql = "Delete from HDV_NgoaiNgu where MaHDV= '" + txtMaHDV.Text + "'";
                RunSql(sql);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHDVNgoaiNgu.Rows.Count == 0)
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
            sql = "update HDV_NgoaiNgu set MaHDV= '" + txtMaHDV.Text + "', MaNgoaiNgu= '" + txtMaNgoaiNgu.Text + "', MaXepLoai= '" + cboMaXepLoai.SelectedValue + "'";
            RunSql(sql);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            int count = 0;
            count = dataGridView_HDVNgoaiNgu.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridView_HDVNgoaiNgu.Rows[count - 2].Cells[0].Value);
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
            if (txtMaNgoaiNgu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập mã ngoại ngữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNgoaiNgu.Focus();
                return;
            }
            if (cboMaXepLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập mã xếp loại");
                cboMaXepLoai.Focus();
                return;
            }
            sql = "select MaHDV from HDV_NgoaiNgu where MaHDV= '" + txtMaHDV.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã HDV này đã tồn tại, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHDV.Focus();
                txtMaHDV.Text = "";
                return;
            }
            sql = "insert into HDV_NgoaiNgu values ('" + txtMaHDV.Text.Trim() + "','" + txtMaNgoaiNgu.Text.Trim() + "','" + cboMaXepLoai.SelectedValue.ToString() + "')";
            RunSql(sql);
            LoadDataToGridView();
            resetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHDV.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
    }
}


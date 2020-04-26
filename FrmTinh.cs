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
    public partial class FrmTinh : Form
    {
        SqlConnection con = new SqlConnection();
        DataTable tblTinh;
        public FrmTinh()
        {
            InitializeComponent();
        }

        private void FrmTinh_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuanLy_CongTyDuLich;Integrated Security=True";
            con.ConnectionString = connectionstring;
            con.Open();
            LoadDataToGridView();
        }
        private void LoadDataToGridView()
        {
            string sql = "select * from Tinh";
            DataTable myTable = Functions.LoadDataToTable(sql);
            tblTinh = Functions.LoadDataToTable(sql);
            dataGridView_Tinh.DataSource = myTable;
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
            txtMaTinh.Text = "";
            txtTenTinh.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            resetValues();
            txtMaTinh.Enabled = true;
        }

        private void dataGridView_Tinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTinh.Text = dataGridView_Tinh.CurrentRow.Cells["MaTinh"].Value.ToString();
            txtTenTinh.Text = dataGridView_Tinh.CurrentRow.Cells["TenTinh"].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTinh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete from Tinh where MaTinh= '" + txtMaTinh.Text + "'";
                RunSql(sql);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTinh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "update Tinh set MaTinh= '" + txtMaTinh.Text + "', TenTinh= '" + txtTenTinh.Text + "'";
            RunSql(sql);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            int count = 0;
            count = dataGridView_Tinh.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridView_Tinh.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 1)));
            if (chuoi2 + 1 < 10)
            {
                txtMaTinh.Text = "T0" + (chuoi2 + 1).ToString();
            }
            else
                if (chuoi2 + 1 < 100)
            {
                txtMaTinh.Text = "T" + (chuoi2 + 1).ToString();
            }
            if (txtTenTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTinh.Focus();
                return;
            }
            sql = "select MaTinh from Tinh where MaTinh= '" + txtMaTinh.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Tỉnh này đã tồn tại, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTinh.Focus();
                txtMaTinh.Text = "";
                return;
            }
            sql = "insert into Tinh values ('" + txtMaTinh.Text.Trim() + "','" + txtTenTinh.Text.Trim() + "')";
            RunSql(sql);
            LoadDataToGridView();
            resetValues();
        }
    }
}

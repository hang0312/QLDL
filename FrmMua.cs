using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCongTyDuLich;

namespace QuanLyCongTyDuLich
{
    public partial class FrmMua : Form
    {
        SqlConnection con = new SqlConnection();
        DataTable Mua;
        public FrmMua()
        {
            InitializeComponent();
        }

        private void FrmMua_Load(object sender, EventArgs e)
        {
            string connectoinString = "Data Source=DESKTOP-JQIE02V;Initial Catalog=QLCongTyDuLich;Integrated Security=True";
            con.ConnectionString = connectoinString;
            con.Open();
            loadDataToGridView();

            Functions.FillCombo("SELECT MaMua FROM Mua", cboMaMua, "MaMua");
            cboMaMua.SelectedIndex = -1;
        }
        private void loadDataToGridView()
        {
            string sql = "SELECT* FROM Mua";
            Mua = Functions.LoadDataToTable(sql);
            dataGridView_Mua.DataSource = Mua;
        }

        private void dataGridView_Mua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaMua.Text = dataGridView_Mua.CurrentRow.Cells["MaMua"].Value.ToString();
            cboTenMua.Text = dataGridView_Mua.CurrentRow.Cells["TenMua"].Value.ToString();
            cboMaMua.Enabled = false;
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
            loadDataToGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboMaMua.Text = "";
            cboTenMua.Text = "";
            cboMaMua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (Mua.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMaMua.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "update Mua set TenMua= N'" + cboTenMua.SelectedValue +
                 "' where MaMua= '" + cboMaMua.SelectedValue + "'";
            RunSql(sql);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE From Mua where MaMua='" + cboMaMua.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            loadDataToGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboMaMua.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã mua");
                cboMaMua.Focus();
                return;
            }
            if (cboTenMua.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên mùa");
                cboTenMua.Focus();
                return;

            }
            sql = "select MaMua from Mua where MaMua= '" + cboMaMua.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Mùa này đã tồn tại, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaMua.Focus();
                cboMaMua.Text = "";
                return;
            }
            sql = "insert into Mua values ('" + cboMaMua.SelectedValue + "', N'" + cboTenMua.SelectedValue
                + "')";
            MessageBox.Show(sql);
            RunSql(sql);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadDataToGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }
    }
}

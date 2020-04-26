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
    public partial class FrmCongTy : Form
    {
        SqlConnection con = new SqlConnection();
        DataTable CongTy;
        public FrmCongTy()
        {
            InitializeComponent();
        }

        private void FrmCongTy_Load(object sender, EventArgs e)
        {
            string connectoinString = "Data Source=DESKTOP-JQIE02V;Initial Catalog=QLCongTyDuLich;Integrated Security=True";
            con.ConnectionString = connectoinString;
            con.Open();
            loadDataToGridView();

            Functions.FillCombo("SELECT MaCongTy FROM CongTy", cboMaCongTy, "MaCongTy");
            cboMaCongTy.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaPhamVi FROM PhamVi", cboMaPhamVi, "MaPhamVi");
            cboMaPhamVi.SelectedIndex = -1;
            Functions.FillCombo("SELECT TenCongTy FROM CongTy", cboTenCongTy, "TenCongTy");
            cboTenCongTy.SelectedIndex = -1;
            Functions.FillCombo("SELECT DienThoai FROM CongTy", cboDienThoai, "DienThoai");
            cboDienThoai.SelectedIndex = -1;
            Functions.FillCombo("SELECT Email FROM CongTy", cboEmail, "Email");
            cboEmail.SelectedIndex = -1;
            Functions.FillCombo("SELECT DiaChi FROM CongTy", cboDiaChi, "DiaChi");
            cboDiaChi.SelectedIndex = -1;
        }
        private void loadDataToGridView()
        {
            string sql = "SELECT* FROM CongTy";
            CongTy = Functions.LoadDataToTable(sql);
            dataGridView_CongTy.DataSource = CongTy;
        }

        private void dataGridView_CongTy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboDiaChi.Text = dataGridView_CongTy.CurrentRow.Cells["DiaChi"].Value.ToString();
            cboDienThoai.Text = dataGridView_CongTy.CurrentRow.Cells["DienThoai"].Value.ToString();
            cboEmail.Text = dataGridView_CongTy.CurrentRow.Cells["Email"].Value.ToString();
            cboMaCongTy.Text = dataGridView_CongTy.CurrentRow.Cells["MaCongTy"].Value.ToString();
            cboMaPhamVi.Text = dataGridView_CongTy.CurrentRow.Cells["MaPhamVi"].Value.ToString();
            cboTenCongTy.Text = dataGridView_CongTy.CurrentRow.Cells["TenCongTy"].Value.ToString();
            cboMaCongTy.Enabled = false;
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
            cboDiaChi.Text = "";
            cboDienThoai.Text = "";
            cboEmail.Text = "";
            cboMaCongTy.Text = "";
            cboMaPhamVi.Text = "";
            cboTenCongTy.Text = "";
            cboMaCongTy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (CongTy.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMaCongTy.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "update CongTy set TenCongTy= N'" + cboTenCongTy.SelectedValue +
                "', DienThoai= '" + cboDienThoai.SelectedValue + "', DiaChi= N'" + cboDiaChi.SelectedValue +
                "', MaPhamVi= '" + cboMaPhamVi.SelectedValue + "', Email= '" + cboEmail.Text +
                 "' where MaCongTy= '" + cboMaCongTy.SelectedValue + "'";
            RunSql(sql);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE From CongTy where MaCongTy='" + cboMaCongTy.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            loadDataToGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboMaCongTy.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã cong ty");
                cboMaCongTy.Focus();
                return;
            }
            if (cboTenCongTy.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên công ty");
                cboTenCongTy.Focus();
                return;
            }
            if (cboDiaChi.Text == "")
            {
                MessageBox.Show("Bạn cần nhập địa chỉ");
                cboDiaChi.Focus();
                return;
            }
            if (cboDienThoai.Text == "")
            {
                MessageBox.Show("Bạn cần nhập điện thoại");
                cboDienThoai.Focus();
                return;
            }
            if (cboEmail.Text == "")
            {
                MessageBox.Show("Bạn cần nhập email");
                cboEmail.Focus();
                return;
            }
            if (cboMaPhamVi.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã phạm vi");
                cboMaPhamVi.Focus();
                return;
            }
            sql = "select MaCongTy from CongTy where MaCongTy= '" + cboMaCongTy.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã Công Ty này đã tồn tại, bạn phải nhập mã khác", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaCongTy.Focus();
                cboMaCongTy.Text = "";
                return;
            }
            sql = "insert into CongTy values ('" + cboMaCongTy.SelectedValue + "', '" + cboTenCongTy.SelectedValue + "', '" + cboDiaChi.SelectedValue
                + "', N'" + cboDienThoai.SelectedValue + "', '" + cboEmail.SelectedValue + "', '" + cboMaPhamVi.Text
                + "')";
            MessageBox.Show(sql);
            RunSql(sql);

        }

        private void Huy_Click(object sender, EventArgs e)
        {
            loadDataToGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }
        private void resetValues()
        {
            cboDiaChi.Text = "";
            cboDienThoai.Text = "";
            cboEmail.Text = "";
            cboMaCongTy.Text = "";
            cboMaPhamVi.Text = "";
            cboTenCongTy.Text = "";
        }
    }
}

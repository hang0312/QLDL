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
    public partial class FrmXacNhanDangKy : Form
    {
        SqlConnection con = new SqlConnection();
        DataTable tblXacNhanDangKy;
        public FrmXacNhanDangKy()
        {
            InitializeComponent();
        }

        private void FrmXacNhanDangKy_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CongTyDuLich;Integrated Security=True";
            con.ConnectionString = connectionString;
            con.Open();
            LoadDataToGridview();

            Functions.FillCombo("Select MaTour,DonGia from DanhMucTour", cboMaTour, "MaTour");
            cboMaTour.SelectedIndex = -1;
            Functions.FillCombo("select MaLichTour, SoNguoiDangKy, TongTien from LichTour", cboMaLichTour, "MaLichTour");
            cboMaLichTour.SelectedIndex = -1;
        }
        private void LoadDataToGridview()
        {
            string sql1 = "select SoLuongDangKy, ThanhTien, MaDangKy from DangKiTour";
            tblXacNhanDangKy = Functions.LoadDataToTable(sql1);
            dataGridView1.DataSource = tblXacNhanDangKy;

            string sql2 = "select MaLichTour, SoNguoiDangKy, TongTien from LichTour";
            DataTable myTable = Functions.LoadDataToTable(sql2);
            dataGridView2.DataSource = myTable;

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

        }

        private void btnXacNhanDangKy_Click(object sender, EventArgs e)
        {
            string sql;
            double a = Convert.ToDouble(txtDonGia.Text) * Convert.ToDouble(txtSoLuongDangKy.Text);
            sql = "insert into DangKiTour(MaDangKy, SoLuongDangKy, ThanhTien) values ( N'" + txtMaDangKy.Text + "', " + txtSoLuongDangKy.Text + ", " + a + ")";
            RunSql(sql);
            LoadDataToGridview();

            double b = Convert.ToDouble(txtSoNguoiDangKy.Text) + Convert.ToDouble(txtSoLuongDangKy.Text);
            double c = Convert.ToDouble(txtTongTien.Text) + a;
            sql = "update LichTour set SoNguoiDangKy= " + b + ", TongTien= " + c + "where MaLichTour= '" + cboMaLichTour.SelectedValue + "'";
            RunSql(sql);
            LoadDataToGridview();

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void cboMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.FillCombo("Select MaLichTour from LichTour where MaTour= '" + cboMaTour.SelectedValue + "'", cboMaLichTour, "MaLichTour");
            cboMaLichTour.SelectedIndex = -1;
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaTour.Text == "")
            {
                txtDonGia.Text = "";
            }
            str = "select DonGia from DanhMucTour where MaTour= N'" + cboMaTour.SelectedValue + "'";
            txtDonGia.Text = Functions.GetFieldValues(str);
        }

        private void txtSoNguoiDangKy_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaLichTour.Text == "")
            {
                txtSoNguoiDangKy.Text = "";
            }
            str = "select SoNguoiDangKy from LichTour where MaLichTour= N'" + cboMaLichTour.SelectedValue + "'";
            txtSoNguoiDangKy.Text = Functions.GetFieldValues(str);
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaLichTour.Text == "")
            {
                txtTongTien.Text = "";
            }
            str = "select TongTien from LichTour where MaLichTour= N'" + cboMaLichTour.SelectedValue + "'";
            txtTongTien.Text = Functions.GetFieldValues(str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich
{
    class Functions
    {
        public static SqlConnection conn = new SqlConnection();
        public static string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QLCongTyDuLich;Integrated Security=True";
        public static void connect()
        {
            conn.ConnectionString = ConnectionString;
            conn.Open();
        }
        public static void closeConnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }

        public static DataTable LoadDataToTable(string sql)
        {

            SqlDataAdapter MyData = new SqlDataAdapter();
            MyData.SelectCommand = new SqlCommand();
            MyData.SelectCommand.Connection = Functions.conn;
            MyData.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            MyData.Fill(table);
            return table;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('-');
            string dt = String.Format("{0}-{1}-{2}", parts[1], parts[0], parts[2]);
            return dt;
        }
        public static bool IsDate(string d)
        {
            string[] parts = d.Split('-');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) &&
            (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) &&
            (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; // Truong gia tri
            cbo.DisplayMember = ma; // Truong hien thi
        }

        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Functions.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }

        public static void RunSql(string sql)
        {
            SqlCommand cmd;		                
            cmd = new SqlCommand();	         
            cmd.Connection = Functions.conn;	  
            cmd.CommandText = sql;			  
            try
            {
                cmd.ExecuteNonQuery();		  
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }

        public static string matudong(string tiento, DataTable x)
        {
            string g;
            if (x.Rows.Count == 0)
            {
                g = tiento + "01";
            }
            else
            {
                int k;
                g = tiento;
                k = Convert.ToInt32(x.Rows[x.Rows.Count - 1][0].ToString().Substring(2, 1));
                k = k + 1;
                if (k < 10)
                {
                    g = g + "";
                }
                if (k >= 10 && k <= 99)
                {
                    g = g + "0";
                }
                g = g + k.ToString();
            }
            return g;
        }
    }
}

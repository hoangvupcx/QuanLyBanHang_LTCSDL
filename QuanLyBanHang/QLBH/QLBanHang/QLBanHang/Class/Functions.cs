using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//lam viec voi ado.net
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace QLBanHang.Class
{
    internal class Functions
    {
        public static SqlConnection con;// tạo phương thức kết nối
        public static void Connect()
        {
            con = new SqlConnection(); // khởi tạo đối tượng
            con.ConnectionString = Properties.Settings.Default.QLBanHangConnectionString;
            if (con.State != ConnectionState.Open) // kiểm tra xem trạng thái có đang kết nối không
            {
                con.Open();
                MessageBox.Show("Kết nối thành công");
            }
            else
                MessageBox.Show("Kết nối thất bại!");
        }




        //Tạo phương thức disconnect
        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();// đóng kết nối
                con.Dispose();// giải phóng tài nguyên
                con = null;
            }
        }




        //Phương thức thực thi câu lệnh select lấy dữ liệu
        public static DataTable GetDataToTable(string sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(table);
            return table;
        }




        // Phường thức kiểm tra id đã tồn tài hay chưa
        public static bool CheckKey(String sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }


        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }



        // Phương thức xóa Data khỏi Database
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }





        // Đổ dữ liệu vào Combobox
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }






        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }

    }
}

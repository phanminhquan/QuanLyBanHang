using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//lam viec voi ado.net
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        public static void Disconnect() { 
            if(con.State == ConnectionState.Open) {
                con.Close();// đóng kết nối
                con.Dispose();// giải phóng tài nguyên
                con = null;
            }
        }
        //Phương thức thực thi câu lệnh select lấy dữ liệu
        public static DataTable GetDataToTable(string sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql,con);
            dap.Fill(table);
            return table;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Linq.Expressions;
namespace CuaHangDT
{
    public class Connection
    {
        public static string stringConnection = @"Data Source=KIBAN;Initial Catalog=CuaHangDienThoai;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public void testConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    MessageBox.Show("Kết nối SQL Server thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

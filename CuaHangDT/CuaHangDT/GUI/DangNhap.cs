using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;

namespace CuaHangDT
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Bạn có chắc chắn muốn thoát?", 
                "Xác Nhận", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(Exit == DialogResult.No)
            {
                e.Cancel = true;
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static List<TaiKhoanMK> TaiKhoanMKs = new List<TaiKhoanMK>();
        public static void GetAllDangNhap()
        {
            try
            {
                TaiKhoanMKs.Clear();
                string query = "Select * from Tai_Khoan";
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection); //khởi tạo để thao tác với csdl
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())  // đọc csdl
                    {
                        TaiKhoanMK taiKhoanMK = new TaiKhoanMK();
                        taiKhoanMK.TaiKhoan = reader["TenDangNhap"].ToString();
                        taiKhoanMK.MatKhau = reader["MatKhau"].ToString();
                        TaiKhoanMKs.Add(taiKhoanMK);

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // xuất khi lỗi 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllDangNhap(); // load dữ liệu từ database
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            if (tenDangNhap.Trim() == "") { MessageBox.Show("Vui lòng nhập Tài Khoản!"); return; }
            else if (matKhau.Trim() == "") { MessageBox.Show("Vui lòng nhập Mật Khẩu!"); return; }
            bool dangNhapThanhCong = false;

            foreach (var dn in TaiKhoanMKs)
            {
                if (dn.TaiKhoan == tenDangNhap && dn.MatKhau == matKhau)
                {
                    dangNhapThanhCong = true;
                    break;
                }
            }

            if (dangNhapThanhCong)
            {
                frmQuanLyCuaHang ql = new frmQuanLyCuaHang();
                this.Hide();          // ẩn form đăng nhập
                ql.ShowDialog();      // mở form chính
                this.Show();          // hiện lại khi form chính đóng
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !!!");
            }

        }
    }
}

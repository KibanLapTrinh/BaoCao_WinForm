using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDT
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        SqlDataAdapter boDocGhi;
        DataSet dsKhachHang;
        SqlCommandBuilder boPhatSinh;
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}

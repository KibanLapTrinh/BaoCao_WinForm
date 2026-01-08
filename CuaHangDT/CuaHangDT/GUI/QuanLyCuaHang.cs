using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDT
{
    public partial class frmQuanLyCuaHang : Form
    {
        public frmQuanLyCuaHang()
        {
            InitializeComponent();
        }

        private void OpenQuanLySanPham()
        {
            foreach (Form f in this.MdiChildren) // mở form kh bị lặp
                if (f.Name == "frmQuanLySanPham")
                {
                    f.Activate();
                    return;
                }


            frmQuanLySanPham frmQLSP = new frmQuanLySanPham();
            frmQLSP.MdiParent = this;
            frmQLSP.Show();
        }
        private void tStripQLSP_Click(object sender, EventArgs e)
        {
            OpenQuanLySanPham();
        }
        private void OpenQuanLyKhachHang()
        {
            foreach (Form f in this.MdiChildren) // mở form kh bị lặp
                if (f.Name == "frmQuanLyKhachHang")
                {
                    f.Activate();
                    return;
                }


            frmQuanLyKhachHang frmQLKH = new frmQuanLyKhachHang();
            frmQLKH.MdiParent = this;
            frmQLKH.Show();
        }
        private void tStripQLKH_Click(object sender, EventArgs e)
        {
            OpenQuanLyKhachHang();
        }
        private void OpenQuanLyNhanVien()
        {
            foreach (Form f in this.MdiChildren) // mở form kh bị lặp
                if (f.Name == "frmQuanLyNhanVien")
                {
                    f.Activate();
                    return;
                }


            frmQuanLyNhanVien frmQLNV = new frmQuanLyNhanVien();
            frmQLNV.MdiParent = this;
            frmQLNV.Show();
        }

        private void tStripQLNV_Click(object sender, EventArgs e)
        {
            OpenQuanLyNhanVien();
        }
        private void OpenQuanLyHoaDon()
        {
            foreach (Form f in this.MdiChildren) // mở form kh bị lặp
                if (f.Name == "frmQuanLyHoaDon")
                {
                    f.Activate();
                    return;
                }


            frmQuanLyHoaDon frmQLHD = new frmQuanLyHoaDon();
            frmQLHD.MdiParent = this;
            frmQLHD.Show();
        }

        private void tStripQLHD_Click(object sender, EventArgs e)
        {
            OpenQuanLyHoaDon();
        }

        private void tStripDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?",
                "Xác Nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (Exit == DialogResult.Yes)
            {
                frmDangNhap dnhap = new frmDangNhap();
                dnhap.Show();

                this.Close(); // đóng form hiện tại
            }
        }

        private void tSBtnQLSP_Click(object sender, EventArgs e)
        {
            OpenQuanLySanPham();
        }

        private void tSBtnQLKH_Click(object sender, EventArgs e)
        {
            OpenQuanLyKhachHang();
        }

        private void tSBtnQLNV_Click(object sender, EventArgs e)
        {
            OpenQuanLyNhanVien();
        }

        private void tSBtnQLHD_Click(object sender, EventArgs e)
        {
            OpenQuanLyHoaDon();
        }

        private void frmQuanLyCuaHang_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.testConnection();

            //PhanQuyen();
        }
        //string _chucVu;
        //private void PhanQuyen()
        //{
        //    if (_chucVu == "NhanVien")
        //    {
        //        ĐƯỢC PHÉP
        //        tStripQLSP.Enabled = true;
        //        tStripQLKH.Enabled = true;
        //        tStripQLHD.Enabled = true;

        //        tSBtnQLSP.Enabled = true;
        //        tSBtnQLKH.Enabled = true;
        //        tSBtnQLHD.Enabled = true;

        //        KHÔNG ĐƯỢC PHÉP
        //        tStripQLNV.Enabled = false;
        //        tSBtnQLNV.Enabled = false;
        //    }
        //    else if (_chucVu == "Admin")
        //    {
        //        Admin được tất cả
        //        tStripQLSP.Enabled = true;
        //        tStripQLKH.Enabled = true;
        //        tStripQLHD.Enabled = true;
        //        tStripQLNV.Enabled = true;

        //        tSBtnQLSP.Enabled = true;
        //        tSBtnQLKH.Enabled = true;
        //        tSBtnQLHD.Enabled = true;
        //        tSBtnQLNV.Enabled = true;
        //    }
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangDT
{
    public class TaiKhoanMK
    {
        string taiKhoan;
        string matKhau;
        string chucVu;

        public TaiKhoanMK()
        {
        }
        public TaiKhoanMK(string taiKhoan, string matKhau, string chucVu)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.chucVu = chucVu;
            ChucVu = chucVu;
        }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}

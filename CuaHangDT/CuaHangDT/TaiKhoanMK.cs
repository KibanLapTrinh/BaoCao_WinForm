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

        public TaiKhoanMK()
        {
        }
        public TaiKhoanMK(string taiKhoan, string matKhau)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
        }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}

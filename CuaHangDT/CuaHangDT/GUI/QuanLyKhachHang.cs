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
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = "";
            this.Dock = DockStyle.Fill;
        }
        SqlDataAdapter boDocGhi;
        DataSet dsKhachHang;
        SqlCommandBuilder boPhatSinh;
        void dataKhachHang()
        {
            string sqlSelect = "Select * from Khach_Hang";
            boDocGhi = new SqlDataAdapter(sqlSelect, Connection.stringConnection);
            dsKhachHang = new DataSet();
            boDocGhi.Fill(dsKhachHang, "Khach_Hang");
            dgvKhachHang.DataSource = dsKhachHang.Tables[0];
            dgvKhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            //
            //dgvkhachhang.borderstyle = borderstyle.none;
            //dgvkhachhang.backgroundcolor = color.white;f
            //dgvkhachhang.rowtemplate.height = 32;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvkhachhang.allowusertoresizerows = false;
            //dgvkhachhang.columnheadersheightsizemode = datagridviewcolumnheadersheightsizemode.autosize;
        }
        void ClearText()
        {
            txtMaKH.Clear();
            txtKhachHang.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dataKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dongMoi = dsKhachHang.Tables[0].NewRow();
                dongMoi["MaKH"] = txtMaKH.Text;
                if (string.IsNullOrEmpty(txtMaKH.Text))
                {
                    MessageBox.Show("Mã KH không được để trống");
                    return;
                }

                dongMoi["TenKH"] = txtKhachHang.Text;
                dongMoi["SDT"] = txtSDT.Text;
                dongMoi["DiaChi"] = txtDiaChi.Text;
                //add dòng mới
                dsKhachHang.Tables[0].Rows.Add(dongMoi);
                //tự phát sinh lệnh SQL
                boPhatSinh = new SqlCommandBuilder(boDocGhi);
                boDocGhi.Update(dsKhachHang.Tables[0]);

                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearText();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            //lấy dữ liệu từng dòng đưa lên TextBox
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtKhachHang.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (dgvKhachHang.CurrentRow == null) return; //kiểm tra

            dsKhachHang.Tables[0].Rows[dgvKhachHang.CurrentRow.Index].Delete();
            boPhatSinh = new SqlCommandBuilder(boDocGhi);
            boDocGhi.Update(dsKhachHang.Tables[0]);
            MessageBox.Show("Xóa thành công");
            ClearText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataRow dongMoi = dsKhachHang.Tables[0].Rows[dgvKhachHang.CurrentRow.Index];
            dongMoi["TenKH"] = txtKhachHang.Text;
            dongMoi["SDT"] = txtSDT.Text;
            dongMoi["DiaChi"] = txtDiaChi.Text;
            boPhatSinh = new SqlCommandBuilder(boDocGhi);
            boDocGhi.Update(dsKhachHang.Tables[0]);
            MessageBox.Show("Cập nhật thành công");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoaTimKiem = txtKhachHang.Text.Trim();//khởi tạo 1 chuỗi gán textbox xóa khoảng trắng đầu cuối

            if (string.IsNullOrEmpty(tuKhoaTimKiem)) // kiểm tra rỗng
            {
                dsKhachHang.Tables[0].DefaultView.RowFilter = ""; //xóa hết chữ trong ô tìm kiếm
                return; // thoát hàm
            }

            dsKhachHang.Tables[0].DefaultView.RowFilter = $"TenKH like '%{tuKhoaTimKiem}%'"; //lệnh sql tìm kiếm
        }

        private void btnHienDanhSach_Click(object sender, EventArgs e)
        {
            dsKhachHang.Tables[0].DefaultView.RowFilter = "";
        }
    }
}

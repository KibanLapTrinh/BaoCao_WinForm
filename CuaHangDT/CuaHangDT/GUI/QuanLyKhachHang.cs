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
            this.WindowState = FormWindowState.Maximized;
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
            dgvKhachHang.BorderStyle = BorderStyle.None;
            dgvKhachHang.BackgroundColor = Color.White;
            dgvKhachHang.RowTemplate.Height = 32;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AllowUserToResizeRows = false;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtKhachHang.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

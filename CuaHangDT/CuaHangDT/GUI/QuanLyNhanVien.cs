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
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = "";
            this.Dock = DockStyle.Fill;
        }
        SqlDataAdapter boDocGhi;
        DataSet dsNhanVien;
        SqlCommandBuilder boPhatSinh;
        void dataNhanVien()
        {
            string sqlSelect ="Select * from Nhan_Vien";
            boDocGhi = new SqlDataAdapter(sqlSelect, Connection.stringConnection);
            dsNhanVien = new DataSet();
            boDocGhi.Fill(dsNhanVien);
            dgvNhanVien.DataSource = dsNhanVien.Tables[0];

            dgvNhanVien.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns["HoTenNV"].HeaderText = "Họ Tên Nhân Viên";
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns["QueQuan"].HeaderText = "Quê Quán";

            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dataNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dongMoi = dsNhanVien.Tables[0].NewRow();
                dongMoi["MaNV"] = txtMaNV.Text;
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("Mã NV không được để trống");
                    return;
                }

                dongMoi["HoTenNV"] = txtHoTen.Text;
                dongMoi["NgaySinh"] = dTPNgaySinh.Value.ToString();
                if (dTPNgaySinh.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ");
                    return;
                }
                dongMoi["QueQuan"] = txtQueQuan.Text;
                //add dòng mới
                dsNhanVien.Tables[0].Rows.Add(dongMoi);
                //tự phát sinh lệnh SQL
                boPhatSinh = new SqlCommandBuilder(boDocGhi);
                boDocGhi.Update(dsNhanVien.Tables[0]);

                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //ClearText();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();

            if (dgvNhanVien.CurrentRow.Cells[2].Value != DBNull.Value)
            {
                dTPNgaySinh.Value = Convert.ToDateTime(
                    dgvNhanVien.CurrentRow.Cells[2].Value
                );
            }

            txtQueQuan.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataRow dongMoi = dsNhanVien.Tables[0].Rows[dgvNhanVien.CurrentRow.Index];
            dongMoi["MaNV"] = txtMaNV.Text;
            dongMoi["HoTenNV"] = txtHoTen.Text;
            dongMoi["NgaySinh"] = dTPNgaySinh.Value.ToString();
            dongMoi["QueQuan"] = txtQueQuan.Text;
            boPhatSinh = new SqlCommandBuilder(boDocGhi);
            boDocGhi.Update(dsNhanVien.Tables[0]);
            MessageBox.Show("Cập nhật thành công");
        }

        void ClearText()
        {
                txtMaNV.Clear();
                txtHoTen.Clear();
                txtQueQuan.Clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

            dsNhanVien.Tables[0].Rows[dgvNhanVien.CurrentRow.Index].Delete();
            boPhatSinh = new SqlCommandBuilder(boDocGhi);
            boDocGhi.Update(dsNhanVien.Tables[0]);
            MessageBox.Show("Xóa thành công");
           ClearText();
        }
    }
}

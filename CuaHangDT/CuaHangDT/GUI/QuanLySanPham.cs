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
using System.IO;


namespace CuaHangDT
{
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }
        //Khai báo DataAdapter
        SqlDataAdapter boDocGhiSP;
        //Khai báo DataSet
        DataSet dsSanPham;
        //Khai Báo SqlCommandBuilder
        SqlCommandBuilder boPhatSinh;
        void loadData()
        {
            string sqlSelect = "Select * from San_Pham";
                boDocGhiSP = new SqlDataAdapter(sqlSelect, Connection.stringConnection);
                dsSanPham = new DataSet();
                boDocGhiSP.Fill(dsSanPham, "San_Pham");
                dgvSanPham.DataSource = dsSanPham.Tables[0];
            dgvSanPham.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns["HangSX"].HeaderText = "Hãng Sản Xuất";
            dgvSanPham.Columns["GiaBan"].HeaderText = "Giá Bán";
            dgvSanPham.Columns["HinhAnh"].HeaderText = "Hình Ảnh";
            //auto giãn cột theo nội dung.
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //format tiền trực tiếp trên datagridview
            dgvSanPham.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.jpg;*.png;*.jpeg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh
                using (var bmp = new Bitmap(ofd.FileName))
                {
                    pBHinhAnh.Image = new Bitmap(bmp);
                }

                // Lưu đường dẫn
                pBHinhAnh.Tag = ofd.FileName;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dongMoi = dsSanPham.Tables[0].NewRow();
                dongMoi["MaSP"] = txtMaSP.Text;
                dongMoi["TenSP"] = txtTenSP.Text;
                dongMoi["HangSX"] = cbxHangSX.Text;
                decimal giaBan;
                if (!decimal.TryParse(txtGiaBan.Text.Trim(), out giaBan))
                {
                    MessageBox.Show("Giá bán phải là số!");
                    return;
                }
                dongMoi["GiaBan"] = giaBan;
                dongMoi["HinhAnh"] = pBHinhAnh.Tag?.ToString();

                dsSanPham.Tables[0].Rows.Add(dongMoi);

                //sinh SQL INSERT
                SqlCommandBuilder boPhatSinh = new SqlCommandBuilder(boDocGhiSP);
                boDocGhiSP.Update(dsSanPham.Tables[0]);

                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.testConnection();
            //Thêm dữ liệu vào combobox
            cbxHangSX.Items.Add("Apple");
            cbxHangSX.Items.Add("Samsung");
            cbxHangSX.Items.Add("Xiaomi");
            cbxHangSX.Items.Add("Oppo");
            cbxHangSX.Items.Add("Vivo");

            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xóa hàng trong dataSet
            dsSanPham.Tables[0].Rows[dgvSanPham.CurrentRow.Index].Delete();
                boPhatSinh = new SqlCommandBuilder(boDocGhiSP);
                boDocGhiSP.Update(dsSanPham.Tables[0]);
            MessageBox.Show("Xóa thành công.");
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
            txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            cbxHangSX.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
            txtGiaBan.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();

            // hiển thị hình ảnh
            string path = row.Cells["HinhAnh"].Value?.ToString();

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                using (var bmp = new Bitmap(path))
                {
                    pBHinhAnh.Image = new Bitmap(bmp);
                }
                pBHinhAnh.Tag = path;
            }
            else
            {
                pBHinhAnh.Image = null;
                pBHinhAnh.Tag = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSanPham.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                    return;
                }

                int rowIndex = dgvSanPham.CurrentRow.Index;
                DataRow row = dsSanPham.Tables[0].Rows[rowIndex];

                // KHÔNG sửa MaSP (khóa chính)
                row["TenSP"] = txtTenSP.Text;
                row["HangSX"] = cbxHangSX.Text;

                decimal giaBan;
                if (!decimal.TryParse(txtGiaBan.Text.Replace(".", "").Replace(",", ""), out giaBan))
                {
                    MessageBox.Show("Giá bán phải là số!");
                    return;
                }
                row["GiaBan"] = giaBan;

                row["HinhAnh"] = pBHinhAnh.Tag?.ToString();

                // Sinh lệnh UPDATE
                SqlCommandBuilder boPhatSinh = new SqlCommandBuilder(boDocGhiSP);
                boDocGhiSP.Update(dsSanPham.Tables[0]);

                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }
    }
}

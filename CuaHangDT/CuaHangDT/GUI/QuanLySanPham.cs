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
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }
        DataSet dsDienThoai;
        private void btnHienDS_Click(object sender, EventArgs e)
        {
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.DataSource = GetAllSP().Tables[0];
            //dataGridView1.DataMember = "San_Pham";
        }
        DataSet GetAllSP()
        {
            DataSet dataSP = new DataSet();
            //Sql Connection
            //sau khi sài xong là bỏ
            string query = "Select * from San_Pham";
            using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dataSP);


                connection.Close();
            }    


                return dataSP;
        }

            private void Home_Load(object sender, EventArgs e)
        {
            // Thêm các hãng điện thoại phổ biến
            cbxHangSX.Items.Add("Apple");
            cbxHangSX.Items.Add("Samsung");
            cbxHangSX.Items.Add("Oppo");
            cbxHangSX.Items.Add("Xiaomi");
            cbxHangSX.Items.Add("Realme");

            cbxHangSX.SelectedIndex = 0; // Chọn item đầu tiên
        }
        private void GetValuesTextBox(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            string hangSX = cbxHangSX.Text;
            decimal giaBan = decimal.Parse(txtGiaBan.Text);
        }
         private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        // xóa dữ liệu trong TextBox
        private void ClearTextBoxes()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaBan.Clear();
            txtMaSP.Focus(); // Đưa con trỏ về TextBox đầu tiên
        }

        private void cbxHangSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể hiển thị thông tin hoặc lọc sản phẩm theo hãng
            if (cbxHangSX.SelectedIndex != -1)
            {
                string hangDaChon = cbxHangSX.SelectedItem.ToString();
                // Ví dụ: Lọc sản phẩm theo hãng
                // LocSanPhamTheoHang(hangDaChon);
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo OpenFileDialog để chọn file ảnh
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Thiết lập bộ lọc chỉ cho phép chọn file ảnh
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
                openFileDialog.Title = "Chọn ảnh sản phẩm";

                // Hiển thị dialog và kiểm tra nếu người dùng chọn file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file ảnh
                    string imagePath = openFileDialog.FileName;

                    // Hiển thị ảnh lên PictureBox
                    pictureBox1.Image = Image.FromFile(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Hoặc Zoom để giữ tỷ lệ

                    // Lưu đường dẫn ảnh (nếu cần)
                    pictureBox1.Tag = imagePath;

                    MessageBox.Show("Chọn ảnh thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn ảnh: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tSMnDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

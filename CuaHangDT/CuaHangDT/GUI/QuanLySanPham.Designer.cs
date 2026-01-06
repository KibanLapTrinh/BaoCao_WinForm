namespace CuaHangDT
{
    partial class frmQuanLySanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySanPham));
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.cbxHangSX = new System.Windows.Forms.ComboBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHienDS = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tSMnDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.tSQuanLyKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tSQuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tSQuanLyHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tSChiTietHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tSDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.a.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(543, 172);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.Size = new System.Drawing.Size(646, 382);
            this.dgvSanPham.TabIndex = 0;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.White;
            this.a.Controls.Add(this.pictureBox1);
            this.a.Controls.Add(this.btnChonAnh);
            this.a.Controls.Add(this.cbxHangSX);
            this.a.Controls.Add(this.txtGiaBan);
            this.a.Controls.Add(this.txtTenSP);
            this.a.Controls.Add(this.txtMaSP);
            this.a.Controls.Add(this.label5);
            this.a.Controls.Add(this.label4);
            this.a.Controls.Add(this.label3);
            this.a.Controls.Add(this.label2);
            this.a.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(13, 158);
            this.a.Margin = new System.Windows.Forms.Padding(4);
            this.a.Name = "a";
            this.a.Padding = new System.Windows.Forms.Padding(4);
            this.a.Size = new System.Drawing.Size(522, 396);
            this.a.TabIndex = 1;
            this.a.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(293, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Location = new System.Drawing.Point(67, 58);
            this.btnChonAnh.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(145, 56);
            this.btnChonAnh.TabIndex = 9;
            this.btnChonAnh.Text = "Chọn Ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // cbxHangSX
            // 
            this.cbxHangSX.FormattingEnabled = true;
            this.cbxHangSX.Location = new System.Drawing.Point(196, 286);
            this.cbxHangSX.Margin = new System.Windows.Forms.Padding(4);
            this.cbxHangSX.Name = "cbxHangSX";
            this.cbxHangSX.Size = new System.Drawing.Size(286, 27);
            this.cbxHangSX.TabIndex = 8;
            this.cbxHangSX.SelectedIndexChanged += new System.EventHandler(this.cbxHangSX_SelectedIndexChanged);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(196, 333);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(286, 27);
            this.txtGiaBan.TabIndex = 7;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(196, 232);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(286, 27);
            this.txtTenSP.TabIndex = 5;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(196, 177);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(286, 27);
            this.txtMaSP.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá Bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hãng Sản Xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1190, 105);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ THÔNG TIN SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnHienDS);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(145, 571);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1002, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(753, 41);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(126, 60);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnHienDS
            // 
            this.btnHienDS.Location = new System.Drawing.Point(600, 41);
            this.btnHienDS.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienDS.Name = "btnHienDS";
            this.btnHienDS.Size = new System.Drawing.Size(126, 60);
            this.btnHienDS.TabIndex = 4;
            this.btnHienDS.Text = "Hiện Danh Sách";
            this.btnHienDS.UseVisualStyleBackColor = true;
            this.btnHienDS.Click += new System.EventHandler(this.btnHienDS_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(412, 41);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(126, 60);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(219, 41);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(136, 60);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(30, 41);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(153, 60);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 129);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1190, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMnDanhMuc,
            this.tSDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 105);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tSMnDanhMuc
            // 
            this.tSMnDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSQuanLyKhachHang,
            this.tSQuanLyNhanVien,
            this.tSQuanLyHoaDon});
            this.tSMnDanhMuc.Name = "tSMnDanhMuc";
            this.tSMnDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.tSMnDanhMuc.Text = "Danh Mục";
            this.tSMnDanhMuc.Click += new System.EventHandler(this.tSMnDanhMuc_Click);
            // 
            // tSQuanLyKhachHang
            // 
            this.tSQuanLyKhachHang.Name = "tSQuanLyKhachHang";
            this.tSQuanLyKhachHang.Size = new System.Drawing.Size(185, 22);
            this.tSQuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            // 
            // tSQuanLyNhanVien
            // 
            this.tSQuanLyNhanVien.Name = "tSQuanLyNhanVien";
            this.tSQuanLyNhanVien.Size = new System.Drawing.Size(185, 22);
            this.tSQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // tSQuanLyHoaDon
            // 
            this.tSQuanLyHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSChiTietHoaDon});
            this.tSQuanLyHoaDon.Name = "tSQuanLyHoaDon";
            this.tSQuanLyHoaDon.Size = new System.Drawing.Size(185, 22);
            this.tSQuanLyHoaDon.Text = "Quản Lý Hóa Đơn";
            // 
            // tSChiTietHoaDon
            // 
            this.tSChiTietHoaDon.Name = "tSChiTietHoaDon";
            this.tSChiTietHoaDon.Size = new System.Drawing.Size(165, 22);
            this.tSChiTietHoaDon.Text = "Chi Tiết Hóa Đơn";
            // 
            // tSDangXuat
            // 
            this.tSDangXuat.Name = "tSDangXuat";
            this.tSDangXuat.Size = new System.Drawing.Size(74, 20);
            this.tSDangXuat.Text = "Đăng Xuất";
            // 
            // frmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 723);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.dgvSanPham);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Sản Phẩm";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.GroupBox a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHienDS;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.ComboBox cbxHangSX;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tSMnDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem tSQuanLyKhachHang;
        private System.Windows.Forms.ToolStripMenuItem tSQuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tSQuanLyHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tSChiTietHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tSDangXuat;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}
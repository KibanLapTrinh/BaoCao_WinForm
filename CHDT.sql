CREATE DATABASE CuaHangDienThoai
GO
USE CuaHangDienThoai
GO

CREATE TABLE San_Pham(
MaSP NVARCHAR(10) NOT NULL,
TenSP NVARCHAR(50)NOT NULL,
HangSX NVARCHAR(50),
GiaBan Money NOT NULL,
Constraint PK_MaSP Primary Key(MaSP)
)
GO

CREATE TABLE Khach_Hang(
MaKH NVARCHAR(10) NOT NULL,
TenKH NVARCHAR(50),
SDT NVARCHAR(10),
Constraint PK_MaKH Primary Key(MaKH)
)
GO

CREATE TABLE Nhan_Vien(
MaNV NVARCHAR(10) NOT NULL,
HoTenNV NVARCHAR(50),
Constraint PK_MaNV Primary Key(MaNV)
)
GO

CREATE TABLE Hoa_Don(
MaHD NVARCHAR(10) NOT NULL,
MaKH NVARCHAR(10) NOT NULL,
MaNV NVARCHAR(10) NOT NULL,
NgayBan Date,
Constraint PK_MaHD Primary Key(MaHD),

Constraint FK_HD_KH Foreign Key(MaKH) References Khach_Hang(MaKH),
Constraint FK_HD_NV Foreign Key(MaNV) References Nhan_Vien(MaNV)
)
GO

CREATE TABLE CT_HD(
MaHD NVARCHAR(10) NOT NULL,
MaSP NVARCHAR(10) NOT NULL,
SoLuong INT,
DonGia Money,
Constraint PK_MaHD_MaSP Primary Key(MaHD , MaSP),

Constraint FK_CTHD_HD Foreign Key(MaHD) References Hoa_Don(MaHD),
Constraint FK_CTHD_SP Foreign Key(MaSP) References San_Pham(MaSP)
)
GO
ALTER TABLE CT_HD
ADD CONSTRAINT CHK_SoLuong CHECK (SoLuong > 0),
CONSTRAINT CHK_DonGia CHECK (DonGia > 0);

CREATE TABLE Tai_Khoan(
TenDangNhap NVARCHAR(50) NOT NULL,
MatKhau NVARCHAR(50) NOT NULL,
MaNV NVARCHAR(10) NOT NULL,
Constraint PK_TaiKhoan Primary Key(TenDangNhap),

Constraint FK_TK_NV Foreign Key(MaNV) References Nhan_Vien(MaNV)
)
GO


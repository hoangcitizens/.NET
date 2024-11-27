-- Tạo cơ sở dữ liệu
CREATE DATABASE QuanLySinhVien_Ex01_LAB10
GO
USE QuanLySinhVien_Ex01_LAB10
GO

-- Tạo bảng Khoa
CREATE TABLE tbKhoa (
    MaKhoa INT PRIMARY KEY,
    TenKhoa NVARCHAR(50) NOT NULL
)
GO

-- Tạo bảng Chuyên Sâu
CREATE TABLE tbChinhSach (
    MaCS INT PRIMARY KEY,
    TenCS NVARCHAR(50) NOT NULL,
    CheDo NVARCHAR(50) NULL
)
GO

-- Tạo bảng Lớp
CREATE TABLE tbLop (
    MaLop INT PRIMARY KEY,
    TenLop NVARCHAR(50) NOT NULL,
    MaKhoa INT,
    CONSTRAINT FK_tbLop_tbKhoa FOREIGN KEY (MaKhoa) REFERENCES tbKhoa(MaKhoa) ON UPDATE CASCADE ON DELETE CASCADE
)
GO

-- Tạo bảng Sinh Viên
CREATE TABLE tbSinhVien (
    MaSV INT PRIMARY KEY,
    Ten NVARCHAR(50) NOT NULL,
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    SDT NVARCHAR(15),
    DiaChi NVARCHAR(100),
    MaCS INT,
    MaLop INT,
    CONSTRAINT FK_tbSinhVien_tbChinhSach FOREIGN KEY (MaCS) REFERENCES tbChinhSach(MaCS) ON UPDATE CASCADE ON DELETE SET NULL,
    CONSTRAINT FK_tbSinhVien_tbLop FOREIGN KEY (MaLop) REFERENCES tbLop(MaLop) ON UPDATE CASCADE ON DELETE SET NULL
)
GO

-- Tạo bảng Giáo Viên
CREATE TABLE tbGiaoVien (
    MaGV INT PRIMARY KEY,
    TenGV NVARCHAR(50) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(100)
)
GO

-- Tạo bảng Môn Học
CREATE TABLE tbMonHoc (
    MaMH INT PRIMARY KEY,
    TenMH NVARCHAR(50) NOT NULL,
    SoTiet INT,
    MaGV INT,
    CONSTRAINT FK_tbMonHoc_tbGiaoVien FOREIGN KEY (MaGV) REFERENCES tbGiaoVien(MaGV) ON UPDATE CASCADE ON DELETE SET NULL
)
GO

-- Tạo bảng Điểm
CREATE TABLE tbDiem (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MaSV INT,
    MaMH INT,
    Diem FLOAT,
    CONSTRAINT FK_tbDiem_tbSinhVien FOREIGN KEY (MaSV) REFERENCES tbSinhVien(MaSV) ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FK_tbDiem_tbMonHoc FOREIGN KEY (MaMH) REFERENCES tbMonHoc(MaMH) ON UPDATE CASCADE ON DELETE CASCADE
)
GO

-- Tạo bảng Admin
CREATE TABLE tbAdmin (
    UserID NVARCHAR(50) PRIMARY KEY,
    PassWord NVARCHAR(50) NOT NULL
)
GO
-- Thêm dữ liệu vào bảng tbKhoa
INSERT INTO tbKhoa (MaKhoa, TenKhoa) VALUES (1, N'Công nghệ thông tin')
INSERT INTO tbKhoa (MaKhoa, TenKhoa) VALUES (2, N'Khoa học máy tính')
INSERT INTO tbKhoa (MaKhoa, TenKhoa) VALUES (3, N'Kinh tế')
GO

-- Thêm dữ liệu vào bảng tbChinhSach
INSERT INTO tbChinhSach (MaCS, TenCS, CheDo) VALUES (1, N'Học bổng toàn phần', N'Giảm 100% học phí')
INSERT INTO tbChinhSach (MaCS, TenCS, CheDo) VALUES (2, N'Học bổng bán phần', N'Giảm 50% học phí')
INSERT INTO tbChinhSach (MaCS, TenCS, CheDo) VALUES (3, N'Học bổng khuyến khích', N'Giảm 25% học phí')
GO

-- Thêm dữ liệu vào bảng tbLop
INSERT INTO tbLop (MaLop, TenLop, MaKhoa) VALUES (1, N'CNTT-01', 1)
INSERT INTO tbLop (MaLop, TenLop, MaKhoa) VALUES (2, N'KHMT-02', 2)
INSERT INTO tbLop (MaLop, TenLop, MaKhoa) VALUES (3, N'KT-03', 3)
GO

-- Thêm dữ liệu vào bảng tbSinhVien
INSERT INTO tbSinhVien (MaSV, Ten, GioiTinh, NgaySinh, SDT, DiaChi, MaCS, MaLop) 
VALUES (1, N'Nguyễn Hữu Hoàng', N'Nam', '2003-11-26', '0366898984', N'Thái Bình', 1, 1)
INSERT INTO tbSinhVien (MaSV, Ten, GioiTinh, NgaySinh, SDT, DiaChi, MaCS, MaLop) 
VALUES (2, N'Vũ Hồng Anh', N'Nữ', '2000-05-25', '0987654321', N'Hải Phòng', 2, 2)
INSERT INTO tbSinhVien (MaSV, Ten, GioiTinh, NgaySinh, SDT, DiaChi, MaCS, MaLop) 
VALUES (3, N'Trần Đức Huy', N'Nam', '2001-09-20', '0934567890', N'Hà Nội', 2, 3)
GO

-- Thêm dữ liệu vào bảng tbGiaoVien
INSERT INTO tbGiaoVien (MaGV, TenGV, NgaySinh, GioiTinh, DiaChi) 
VALUES (1, N'Nguyễn Chí Vịnh', '1980-03-15', N'Nam', N'Nam Định')
INSERT INTO tbGiaoVien (MaGV, TenGV, NgaySinh, GioiTinh, DiaChi) 
VALUES (2, N'Nguyễn Thị Bình', '1985-07-20', N'Nữ', N'Quảng Trị')
INSERT INTO tbGiaoVien (MaGV, TenGV, NgaySinh, GioiTinh, DiaChi) 
VALUES (3, N'Đặng Trần Đức', '1975-11-25', N'Nam', N'Bình Thuận')
GO

-- Thêm dữ liệu vào bảng tbMonHoc
INSERT INTO tbMonHoc (MaMH, TenMH, SoTiet, MaGV) VALUES (1, N'Lập trình C++', 45, 1)
INSERT INTO tbMonHoc (MaMH, TenMH, SoTiet, MaGV) VALUES (2, N'Trí tuệ nhân tạo', 60, 2)
INSERT INTO tbMonHoc (MaMH, TenMH, SoTiet, MaGV) VALUES (3, N'Kinh tế vi mô', 30, 3)
GO

-- Thêm dữ liệu vào bảng tbDiem
INSERT INTO tbDiem (MaSV, MaMH, Diem) VALUES (1, 1, 8.5)
INSERT INTO tbDiem (MaSV, MaMH, Diem) VALUES (1, 2, 7.5)
INSERT INTO tbDiem (MaSV, MaMH, Diem) VALUES (2, 1, 9.0)
INSERT INTO tbDiem (MaSV, MaMH, Diem) VALUES (2, 3, 6.5)
INSERT INTO tbDiem (MaSV, MaMH, Diem) VALUES (3, 2, 8.0)
GO

-- Thêm dữ liệu vào bảng tbAdmin
INSERT INTO tbAdmin (UserID, PassWord) VALUES ('admin1', '123')
INSERT INTO tbAdmin (UserID, PassWord) VALUES ('admin2', '456')
GO
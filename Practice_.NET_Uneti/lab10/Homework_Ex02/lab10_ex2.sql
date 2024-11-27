-- Tạo cơ sở dữ liệu
CREATE DATABASE QuanLyHangHoa_Ex02_LAB10;
GO

-- Sử dụng cơ sở dữ liệu vừa tạo
USE QuanLyHangHoa_Ex02_LAB10;
GO

-- Tạo bảng tbHangHoa
CREATE TABLE tbHangHoa (
    MaHang INT PRIMARY KEY,           -- Mã hàng (số nguyên, là khóa chính)
    TenHang NVARCHAR(100) NOT NULL,   -- Tên hàng (chuỗi Unicode, không được để trống)
    DonViTinh NVARCHAR(50),           -- Đơn vị tính (chuỗi Unicode)
    DonGia DECIMAL(18, 2) NOT NULL,   -- Đơn giá (số thực với 2 chữ số thập phân, không được để trống)
    SoLuong INT NOT NULL              -- Số lượng (số nguyên, không được để trống)
);

-- Thêm 5 bản ghi đa dạng vào bảng tbHangHoa
INSERT INTO tbHangHoa (MaHang, TenHang, DonViTinh, DonGia, SoLuong)
VALUES
    (1, N'Bút', N'Cái', 3000, 150),
    (2, N'Sách giáo khoa', N'Quyển', 25000, 80),
    (3, N'Gạo', N'Kg', 30000, 50),
    (4, N'Ghế', N'Cái', 2000, 300),
    (5, N'Dầu ăn', N'Chai', 85000, 20);
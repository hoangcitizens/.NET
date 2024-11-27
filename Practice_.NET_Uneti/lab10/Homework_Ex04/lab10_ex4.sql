-- Tạo cơ sở dữ liệu
CREATE DATABASE QuanLyHoaDonDien_Ex04_LAB10;
GO

USE QuanLyHoaDonDien_Ex04_LAB10;
GO

-- Tạo bảng tbHoaDon
CREATE TABLE tbHoaDon (
    SoCongTo NVARCHAR(10) PRIMARY KEY, -- Số công tơ
    TenChuHo NVARCHAR(100),             -- Tên chủ hộ
    SoCu INT,                           -- Số cũ
    SoMoi INT,                          -- Số mới
    DonGia DECIMAL(18, 2),              -- Đơn giá
    SoTieuThu AS (SoMoi - SoCu),        -- Số tiêu thụ, được tính tự động
    ThanhTien AS ((SoMoi - SoCu) * DonGia) -- Thành tiền, tính trực tiếp từ SoMoi, SoCu, và DonGia
);
INSERT INTO tbHoaDon (SoCongTo, TenChuHo, SoCu, SoMoi, DonGia) VALUES
('001', N'Nguyễn Hữu Hoàng', 100, 200, 2200),
('002', N'Nguyễn Văn Minh', 50, 200, 1850),
('003', N'Phạm Thị Lan', 75, 150, 1850),
('004', N'Trần Văn Tuấn', 90, 180, 2200),
('005', N'Lê Thị Hằng', 40, 170, 1850);
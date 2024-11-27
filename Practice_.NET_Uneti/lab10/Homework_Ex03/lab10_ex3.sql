-- Tạo cơ sở dữ liệu QuanLyDiemHocSinh_Ex03_LAB10
CREATE DATABASE QuanLyDiemHocSinh_Ex03_LAB10;
GO

-- Sử dụng cơ sở dữ liệu vừa tạo
USE QuanLyDiemHocSinh_Ex03_LAB10;
GO

-- Tạo bảng tbDiemHocSinh
CREATE TABLE tbDiemHocSinh (
    MaHocSinh NVARCHAR(20) NOT NULL PRIMARY KEY,  -- Mã học sinh (khóa chính)
    TenHocSinh NVARCHAR(50) NOT NULL,             -- Tên học sinh
    DiemToan FLOAT CHECK (DiemToan BETWEEN 0 AND 10),  -- Điểm Toán (phải từ 0 đến 10)
    DiemViet FLOAT CHECK (DiemViet BETWEEN 0 AND 10)   -- Điểm Viết (phải từ 0 đến 10)
);

-- Thêm dữ liệu vào bảng tbDiemHocSinh
INSERT INTO tbDiemHocSinh (MaHocSinh, TenHocSinh, DiemToan, DiemViet) VALUES 
    (N'HS001', N'Nguyễn Hữu Hoàng', 8.5, 9.0),
    (N'HS002', N'Vũ Hồng Anh', 7.0, 6.5),
    (N'HS003', N'Trần Quang Tuấn', 9.2, 8.7),
    (N'HS004', N'Phạm Thị Dung', 6.5, 7.8),
    (N'HS005', N'Hoàng Văn Long', 5.9, 6.0);
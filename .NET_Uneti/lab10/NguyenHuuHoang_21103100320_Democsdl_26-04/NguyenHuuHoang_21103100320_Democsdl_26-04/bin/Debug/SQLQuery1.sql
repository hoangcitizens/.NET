create database QLSV
go
use QLSV
CREATE TABLE [dbo].[Khoa] (
    [MaKhoa]    VARCHAR (20)  NOT NULL,
    [TenKhoa]   NVARCHAR (50) NOT NULL,
    [DiaChi]    NVARCHAR (50) NULL,
    [DienThoai] VARCHAR (15)  NULL,
    CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED ([MaKhoa] ASC)
);
create database QLSV
go
CREATE TABLE [dbo].[SinhVien] (
    [MaSV]     VARCHAR (20)  NOT NULL,
    [HoTen]    NVARCHAR (30) NULL,
    [NgaySinh] SMALLDATETIME NULL,
    [GioiTinh] BIT           NULL,
    [MaKhoa]   VARCHAR (20)  NULL,
    CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED ([MaSV] ASC),
    CONSTRAINT [FK_SinhVien_Khoa] FOREIGN KEY ([MaKhoa]) REFERENCES [dbo].[Khoa] ([MaKhoa])
);
go 

INSERT INTO [dbo].[Khoa] ([MaKhoa], [TenKhoa], [DiaChi], [DienThoai]) VALUES (N'1', N'Công nghệ thông tin', N'Tầng 5 HA9', NULL)
INSERT INTO [dbo].[Khoa] ([MaKhoa], [TenKhoa], [DiaChi], [DienThoai]) VALUES (N'2', N'Địa lý', NULL, NULL)

INSERT INTO [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [MaKhoa]) VALUES (N'21103100111', N'Nguyễn Hồng Anh', N'2003-05-25 00:00:00', 0, N'2')
INSERT INTO [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [MaKhoa]) VALUES (N'21103100320', N'Nguyễn Hữu Hoàng', N'2003-11-26 00:00:00', 1, N'1')

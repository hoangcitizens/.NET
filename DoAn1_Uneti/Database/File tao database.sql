CREATE DATABASE QuanLyThueNha
go

USE QuanLyThueNha
go

CREATE TABLE [dbo].[TaiKhoan] (
    [TenDangNhap] VARCHAR (30) NOT NULL,
    [MatKhau]     VARCHAR (20) NULL,
    CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED ([TenDangNhap] ASC)
);
go

CREATE TABLE [dbo].[ChuNha] (
    [MaChuNha]      VARCHAR (15)  NOT NULL,
    [HoTenCN]       NVARCHAR (30) NOT NULL,
    [SoDienThoaiCN] VARCHAR (10)  NULL,
    [EmailCN]       VARCHAR (30)  NULL,
    [MaNha]         VARCHAR (15)  NULL,
    CONSTRAINT [PK_ChuNha] PRIMARY KEY CLUSTERED ([MaChuNha] ASC),
    CONSTRAINT [FK_ChuNha_Nha] FOREIGN KEY ([MaNha]) REFERENCES [dbo].[Nha] ([MaNha])
);
go

CREATE TABLE [dbo].[Nha] (
    [MaNha]       VARCHAR (15)  NOT NULL,
    [ThongTinNha] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Nha] PRIMARY KEY CLUSTERED ([MaNha] ASC)
);
go

CREATE TABLE [dbo].[HoaDon] (
    [MaHoaDon]      VARCHAR (15) NOT NULL,
    [MaKhachHang]   VARCHAR (15) NOT NULL,
    [TienThanhToan] MONEY        NULL,
    CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED ([MaHoaDon] ASC),
    CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KhachHang] ([MaKhachHang])
);
go

CREATE TABLE [dbo].[KhachHang] (
    [MaKhachHang]   VARCHAR (15)  NOT NULL,
    [HoTenKH]       NVARCHAR (30) NULL,
    [DiaChiKH]      NVARCHAR (30) NOT NULL,
    [SoDienThoaiKH] VARCHAR (10)  NULL,
    [EmailKH]       VARCHAR (30)  NULL,
    CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED ([MaKhachHang] ASC)
);
go

CREATE TABLE [dbo].[QuanLy] (
    [MaQuanLy]      VARCHAR (15)  NOT NULL,
    [HoTenQL]       NVARCHAR (30) NOT NULL,
    [SoDienThoaiQL] VARCHAR (10)  NULL,
    [EmailQL]       VARCHAR (30)  NULL,
    CONSTRAINT [PK_QuanLy] PRIMARY KEY CLUSTERED ([MaQuanLy] ASC)
);
go

CREATE TABLE [dbo].[HopDong] (
    [MaHopDong]        VARCHAR (15)  NOT NULL,
    [MaQuanLy]         VARCHAR (15)  NULL,
    [MaKhachHang]      VARCHAR (15)  NULL,
    [DieuKhoanHopDong] NVARCHAR (60) NULL,
    CONSTRAINT [PK_HopDong] PRIMARY KEY CLUSTERED ([MaHopDong] ASC),
    CONSTRAINT [FK_HopDong_QuanLy] FOREIGN KEY ([MaQuanLy]) REFERENCES [dbo].[QuanLy] ([MaQuanLy]),
    CONSTRAINT [FK_HopDong_KhachHang] FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KhachHang] ([MaKhachHang])
);
go

CREATE TABLE [dbo].[ChiTietHopDong] (
    [MaHopDong]      VARCHAR (15) NOT NULL,
    [MaNHa]          VARCHAR (15) NOT NULL,
    [NgayLapHopDong] DATE         NULL,
    CONSTRAINT [FK_ChiTietHopDong_HopDong] FOREIGN KEY ([MaHopDong]) REFERENCES [dbo].[HopDong] ([MaHopDong]),
    CONSTRAINT [FK_ChiTietHopDong_Nha] FOREIGN KEY ([MaNHa]) REFERENCES [dbo].[Nha] ([MaNha])
);
go

INSERT INTO [dbo].[ChuNha] ([MaChuNha], [HoTenCN], [SoDienThoaiCN], [EmailCN], [MaNha]) VALUES (N'a3c378', N'Đỗ Việt Anh', N'0742385854', N'anh03@gmail.com', N'3')
INSERT INTO [dbo].[ChuNha] ([MaChuNha], [HoTenCN], [SoDienThoaiCN], [EmailCN], [MaNha]) VALUES (N'd2b545', N'Nguyễn Tiến Đạt', N'0985234563', N'dat11@gmail.com', N'2')
INSERT INTO [dbo].[ChuNha] ([MaChuNha], [HoTenCN], [SoDienThoaiCN], [EmailCN], [MaNha]) VALUES (N'h1a255', N'Nguyễn Hữu Hoàng', N'0366898984', N'huuhoang@gmail.com', N'1')
INSERT INTO [dbo].[ChuNha] ([MaChuNha], [HoTenCN], [SoDienThoaiCN], [EmailCN], [MaNha]) VALUES (N'h4d879', N'Bùi Thế Hoàng', N'0344123555', N'thehoang22@gmail.com', N'4')
INSERT INTO [dbo].[ChuNha] ([MaChuNha], [HoTenCN], [SoDienThoaiCN], [EmailCN], [MaNha]) VALUES (N'm5e234', N'Nguyễn Mai Anh', N'0734325434', N'maianh@gmail.com', N'5')
go

INSERT INTO [dbo].[Nha] ([MaNha], [ThongTinNha]) VALUES (N'1', N'150m², 3 Tầng, 296 Lĩnh Nam, 400 triệu/năm')
INSERT INTO [dbo].[Nha] ([MaNha], [ThongTinNha]) VALUES (N'2', N'120m², 2 Tầng, 789 Trần Hưng Đạo, 300 triệu/năm')
INSERT INTO [dbo].[Nha] ([MaNha], [ThongTinNha]) VALUES (N'3', N'200m2, 4 Tầng, 122 Hoàng Mai, 500 triệu/năm')
INSERT INTO [dbo].[Nha] ([MaNha], [ThongTinNha]) VALUES (N'4', N'180m², 4 Tầng, 456 Bạch Đằng, 450 triệu/năm')
INSERT INTO [dbo].[Nha] ([MaNha], [ThongTinNha]) VALUES (N'5', N'250m², 5 Tầng, 1010 Kim Mã, 600 triệu/năm')
go

INSERT INTO [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [TienThanhToan]) VALUES (N'H01', N'KH04', CAST(470000000.0000 AS Money))
INSERT INTO [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [TienThanhToan]) VALUES (N'H02', N'KH02', CAST(782500000.0000 AS Money))
INSERT INTO [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [TienThanhToan]) VALUES (N'H03', N'KH01', CAST(650000000.0000 AS Money))
INSERT INTO [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [TienThanhToan]) VALUES (N'H04', N'KH03', CAST(132000000.0000 AS Money))
INSERT INTO [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [TienThanhToan]) VALUES (N'HD05', N'KH05', CAST(800000000.0000 AS Money))
go

INSERT INTO [dbo].[KhachHang] ([MaKhachHang], [HoTenKH], [DiaChiKH], [SoDienThoaiKH], [EmailKH]) VALUES (N'KH01', N'Lê Đắc Long', N'TP Hồ Chí Minh', N'0378123456', N'long@gmail.com')
INSERT INTO [dbo].[KhachHang] ([MaKhachHang], [HoTenKH], [DiaChiKH], [SoDienThoaiKH], [EmailKH]) VALUES (N'KH02', N'Trần Hồng Hà', N'Hà Nội', N'0386654521', N'ha@gmail.com')
INSERT INTO [dbo].[KhachHang] ([MaKhachHang], [HoTenKH], [DiaChiKH], [SoDienThoaiKH], [EmailKH]) VALUES (N'KH03', N'Nguyễn Thị Linh', N'Đà Nẵng', N'0789456789', N'linh@gmail.com')
INSERT INTO [dbo].[KhachHang] ([MaKhachHang], [HoTenKH], [DiaChiKH], [SoDienThoaiKH], [EmailKH]) VALUES (N'KH04', N'Đỗ Văn Tài ', N'Hải Phòng', N'0865678123', N'tai@gmail.com')
INSERT INTO [dbo].[KhachHang] ([MaKhachHang], [HoTenKH], [DiaChiKH], [SoDienThoaiKH], [EmailKH]) VALUES (N'KH05', N'Dương Hoàng Yến', N'Thái Bình', N'0973456789', N'yen@gmail.com')
go

INSERT INTO [dbo].[QuanLy] ([MaQuanLy], [HoTenQL], [SoDienThoaiQL], [EmailQL]) VALUES (N'QL01', N'Trần Văn Khánh', N'0908123456', N'khanh@gmail.com')
INSERT INTO [dbo].[QuanLy] ([MaQuanLy], [HoTenQL], [SoDienThoaiQL], [EmailQL]) VALUES (N'QL02', N'Vũ Thị Ly', N'0368209683', N'vuly@gmail.com')
INSERT INTO [dbo].[QuanLy] ([MaQuanLy], [HoTenQL], [SoDienThoaiQL], [EmailQL]) VALUES (N'QL03', N'Nguyễn Văn Huy', N'0785332154', N'huy@gmail.com')
go

INSERT INTO [dbo].[HopDong] ([MaHopDong], [MaQuanLy], [MaKhachHang], [DieuKhoanHopDong]) VALUES (N'HD01', N'QL02', N'KH01', N'Thanh toán hợp đồng trước 25/05/2024')
INSERT INTO [dbo].[HopDong] ([MaHopDong], [MaQuanLy], [MaKhachHang], [DieuKhoanHopDong]) VALUES (N'HD02', N'QL02', N'KH02', N'Trả góp kèm lãi suất 4% một năm')
INSERT INTO [dbo].[HopDong] ([MaHopDong], [MaQuanLy], [MaKhachHang], [DieuKhoanHopDong]) VALUES (N'HD03', N'QL01', N'KH03', N'Bảo trì toàn bộ hệ thống điện trước khi bàn giao')
INSERT INTO [dbo].[HopDong] ([MaHopDong], [MaQuanLy], [MaKhachHang], [DieuKhoanHopDong]) VALUES (N'HD04', N'QL03', N'KH04', N'Trả trước 70% giá trị hóa đơn ')
INSERT INTO [dbo].[HopDong] ([MaHopDong], [MaQuanLy], [MaKhachHang], [DieuKhoanHopDong]) VALUES (N'HD05', NULL, N'KH05', N'Bàn giao nhà trước 01/01/2025')
INSERT INTO [dbo].[HopDong] ([MaHopDong], [MaQuanLy], [MaKhachHang], [DieuKhoanHopDong]) VALUES (N'HD07', NULL, NULL, NULL)
go

INSERT INTO [dbo].[ChiTietHopDong] ([MaHopDong], [MaNHa], [NgayLapHopDong]) VALUES (N'HD01', N'1', N'2023-04-04')
INSERT INTO [dbo].[ChiTietHopDong] ([MaHopDong], [MaNHa], [NgayLapHopDong]) VALUES (N'HD02', N'2', N'2024-05-25')
INSERT INTO [dbo].[ChiTietHopDong] ([MaHopDong], [MaNHa], [NgayLapHopDong]) VALUES (N'HD03', N'3', N'2021-11-22')
INSERT INTO [dbo].[ChiTietHopDong] ([MaHopDong], [MaNHa], [NgayLapHopDong]) VALUES (N'HD04', N'4', N'2020-10-29')
INSERT INTO [dbo].[ChiTietHopDong] ([MaHopDong], [MaNHa], [NgayLapHopDong]) VALUES (N'HD05', N'5', N'2024-09-05')
go
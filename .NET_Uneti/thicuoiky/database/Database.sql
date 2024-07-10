CREATE DATABASE qlsinhvien
go

use qlsinhvien
go

CREATE TABLE [dbo].[Lop] (
    [maLop]  VARCHAR (15)  NOT NULL,
    [tenLop] NVARCHAR (30) NULL,
    CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED ([maLop] ASC)
);
go

CREATE TABLE [dbo].[sinhvien] (
    [maSv]     VARCHAR (15)  NOT NULL,
    [tenSv]    NVARCHAR (50) NULL,
    [gioiTinh] BIT           NULL,
    [ngaySinh] DATETIME      NULL,
    [maLop]    VARCHAR (15)  NULL,
    CONSTRAINT [PK_sinhvien] PRIMARY KEY CLUSTERED ([maSv] ASC),
    CONSTRAINT [FK_sinhvien_Lop] FOREIGN KEY ([maLop]) REFERENCES [dbo].[Lop] ([maLop])
);
go

INSERT INTO [dbo].[Lop] ([maLop], [tenLop]) VALUES (N'ml01', N'DHTI15A5HN')
INSERT INTO [dbo].[Lop] ([maLop], [tenLop]) VALUES (N'ml02', N'DHKT14A2HN')
INSERT INTO [dbo].[Lop] ([maLop], [tenLop]) VALUES (N'ml03', N'DHTI16A10ND')
INSERT INTO [dbo].[Lop] ([maLop], [tenLop]) VALUES (N'ml04', N'DHCK17A7HN')
go

INSERT INTO [dbo].[sinhvien] ([maSv], [tenSv], [gioiTinh], [ngaySinh], [maLop]) VALUES (N'ms01', N'Nguyễn Hữu Hoàng', 1, N'2003-11-26 00:00:00', N'ml01')
INSERT INTO [dbo].[sinhvien] ([maSv], [tenSv], [gioiTinh], [ngaySinh], [maLop]) VALUES (N'ms02', N'Đỗ Văn Linh', 1, N'2004-10-10 00:00:00', N'ml02')
INSERT INTO [dbo].[sinhvien] ([maSv], [tenSv], [gioiTinh], [ngaySinh], [maLop]) VALUES (N'ms03', N'Phan Thùy Trang', 0, N'2005-05-25 00:00:00', N'ml03')
INSERT INTO [dbo].[sinhvien] ([maSv], [tenSv], [gioiTinh], [ngaySinh], [maLop]) VALUES (N'ms04', N'Đỗ Tuyết Dung', 0, N'2003-02-22 00:00:00', N'ml04')
INSERT INTO [dbo].[sinhvien] ([maSv], [tenSv], [gioiTinh], [ngaySinh], [maLop]) VALUES (N'ms06', N'Phạm Tuấn', 1, N'2003-11-04 00:00:00', NULL)
go
CREATE TABLE [dbo].[Lop]
(
	[MaLop] INT NOT NULL PRIMARY KEY, 
    [TenLop] NVARCHAR(30) NOT NULL
)
CREATE TABLE [dbo].[SinhVien]
(
	[MaSV] INT NOT NULL PRIMARY KEY, 
    [HoTen] NVARCHAR(50) NULL, 
    [NgaySinh] DATETIME NULL, 
    [GioiTinh] BIT NULL, 
    [MaLop] INT NULL, 
    CONSTRAINT [FK_SinhVien_ToLop] FOREIGN KEY ([MaLop]) REFERENCES [Lop]([MaLop])
)
CREATE TABLE [dbo].[Diem]
(
	[MaSV] INT NOT NULL , 
    [MaMH] INT NOT NULL, 
    [DiemTBM] DECIMAL(4, 2) NULL, 
    CONSTRAINT [PK_Diem] PRIMARY KEY ([MaMH], [MaSV]), 
    CONSTRAINT [FK_Diem_ToSinhVien] FOREIGN KEY ([MaSV]) REFERENCES [SinhVien]([MaSV])
)
INSERT INTO [dbo].[Lop] ([MaLop], [TenLop]) VALUES (5, N'Tin15a5')
INSERT INTO [dbo].[Lop] ([MaLop], [TenLop]) VALUES (6, N'Tin15a6')
INSERT INTO [dbo].[Lop] ([MaLop], [TenLop]) VALUES (7, N'Tin15a7')

INSERT INTO [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [MaLop]) VALUES (1, N'Nguyễn Hữu Hoàng', N'2003-11-26 00:00:00', 1, 5)
INSERT INTO [dbo].[SinhVien] ([MaSV], [HoTen], [NgaySinh], [GioiTinh], [MaLop]) VALUES (2, N'Vũ Hồng Anh', N'2003-05-25 00:00:00', 0, 6)


INSERT INTO [dbo].[Diem] ([MaSV], [MaMH], [DiemTBM]) VALUES (1, 1, CAST(9.00 AS Decimal(4, 2)))
INSERT INTO [dbo].[Diem] ([MaSV], [MaMH], [DiemTBM]) VALUES (2, 1, CAST(10.00 AS Decimal(4, 2)))
INSERT INTO [dbo].[Diem] ([MaSV], [MaMH], [DiemTBM]) VALUES (1, 2, CAST(8.00 AS Decimal(4, 2)))
INSERT INTO [dbo].[Diem] ([MaSV], [MaMH], [DiemTBM]) VALUES (2, 2, CAST(8.80 AS Decimal(4, 2)))


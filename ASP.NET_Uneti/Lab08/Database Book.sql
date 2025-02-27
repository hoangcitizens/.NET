﻿create table Category(
 CategoryID int identity(1,1) primary key,
 CategoryName nvarchar(100) not null
)
go
CREATE TABLE Author(
	AuthorID int identity(1,1) primary key,
	AuthorName nvarchar(50) NOT NULL,
	AuthorEmail nvarchar(50) NULL,	
	AuthorAddress nvarchar(150) NULL
) 
go
create table Book(
 BookID int identity(1,1) primary key,
 Title nvarchar(200) not null,
 AuthorID int  not null,
 Price decimal(18,0),
 Images varchar(200),
 CategoryID int not null,
 Description ntext,
 Published datetime default(getdate()),
 ViewCount int default(0),
 constraint fk_book_category foreign key (CategoryID) references Category(CategoryID),
 constraint fk_book_author	foreign key(AuthorID) references Author(AuthorID)
)
go
create table Users(
 UserID int identity(1,1) primary key,
 Username varchar(50) not null,
 Password nvarchar(50) not null,
 Fullname nvarchar(100) null,
 IsAdmin bit default(0)
)
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT Category (CategoryID, CategoryName) VALUES (1, N'Ngoại ngữ ')
GO
INSERT Category (CategoryID, CategoryName) VALUES (2, N'Công nghệ thông tin')
GO
INSERT Category (CategoryID, CategoryName) VALUES (3, N'Văn học')
GO
INSERT Category (CategoryID, CategoryName) VALUES (4, N'Khoa học kỹ thuật')
GO
INSERT Category (CategoryID, CategoryName) VALUES (5, N'Nông nghiệp')
GO
INSERT Category (CategoryID, CategoryName) VALUES (6, N'Triết học-Chính trị')
GO
SET IDENTITY_INSERT [dbo].[Category] OFF 

SET IDENTITY_INSERT [dbo].[Author] ON 
GO
INSERT Author(AuthorID, AuthorName, AuthorEmail, AuthorAddress) VALUES (2, N'Phạm Công Anh', N'vinh@gmailc.om', N'197 Trần Hưng Đạo')
GO
INSERT Author(AuthorID, AuthorName, AuthorEmail, AuthorAddress) VALUES (3, N'Nguyễn Thế Giang', N'giangnt@gmail.com', N'179 Chánh hưng - F.4 - Q.8 Tp.HCM')
GO
INSERT Author(AuthorID, AuthorName, AuthorEmail, AuthorAddress) VALUES (4, N'Lê Việt Nhân', N'nhanvl@gmail.com', N'45 Lý Thái Tổ-F2.Q.3 Tp.HCM')
GO
INSERT Author(AuthorID, AuthorName, AuthorEmail, AuthorAddress)  VALUES (5, N'Hồng Phúc', N'hong@gmail.com', N'46 Lý Thái Tổ-F2.Q.3 Tp.HCM')
GO
INSERT Author(AuthorID, AuthorName, AuthorEmail, AuthorAddress)  VALUES (6, N'Ks.Phạm Quang Huy', N'huyq@gmail.com', N'47 Lý Thái Tổ-F2.Q.3 Tp.HCM')
GO
INSERT Author(AuthorID, AuthorName, AuthorEmail, AuthorAddress) VALUES (9, N'Quách Tuấn Ngọc', N'ngocqt@gmail.com', N'48 Lý Thái Tổ-F2.Q.3 Tp.HCM')

GO
INSERT Book(Title, Price, [Description], Images, CategoryID, AuthorID, Published, ViewCount) 
VALUES ( N'Giáo trình Tin học cơ bản1', 26000.0000, N'Nội dung của cuốn: Tin Học Cơ Bản Windows XP gồm có 7 chương:
Chương 1: Một số vấn đề cơ bản. 
Chương 2: Sử dụng nhanh thanh công cụ và thanh thực đơn trong My Computer và Windows Explorer. 
Chương 3: Các thao tác trong windows XP. 
Chương 4: Các thiết lập trong Windows XP. 
Chương 5: Bảo trì máy tính. 
Chương 6: Các phím tắt 
Chương 7: Hỏi và đáp các thắc mắc.
Xin trân trọng giới thiệu cuốn sách cùng bạn', N'THCB.jpg', 2, 2, CAST(N'2004-07-17T00:00:00' AS SmallDateTime),  0)
GO
INSERT Book(Title, Price, [Description], Images, CategoryID, AuthorID, Published, ViewCount) 
VALUES (N'Giáo trình Tin học văn phòng', 12000.0000, N'Cuốn sách này gồm 3 phần sau:
Phần 1: Xử lý văn bản trong Microsoft Office Word 2007. 
Phần 2: Xử lý bảng tính trong Microsoft Office Excel 2007. 
Phần 3: Quản lý cơ sở dữ liệu trong Microsoft Office Access 2007.
Xin trân trọng giới thiệu cùng các bạn.', N'TH004.jpg', 3, 2, CAST(N'2004-06-05T00:00:00' AS SmallDateTime), 25)
GO
INSERT Book(Title, Price, [Description], Images, CategoryID, AuthorID, Published, ViewCount) 
VALUES (N'Lập Trình Cơ Sở Dữ Liệu Với Visual Basic 2005 Và ADO.NET 2.0', 11500.0000, N'Cuốn sách "Lập Trình Cơ Sở Dữ Liệu Với Visual Basic 2005 Và ADO.NET 2.0" này giới thiệu các nội dung sau:
Chương 1: Căn bản về cơ sở dữ liệu.
Chương 2: Các bộ kết nối và tương tác dữ liệu.
Chương 3: Bộ chứa dữ liệu DataSet.
Chương 4: Bộ điều hợp dữ liệu DataAdapter.
Chương 5: Sử dụng các điều khiển ràng buộc dữ liệu.
Chương 6: Tạo báo cáo với Crystal Report.
Chương 7: ADO.NET và XML.
Xin trân trọng giới thiệu cùng các bạn.', N'Gt_Thcb.jpg', 3, 3, CAST(N'2004-07-12T00:00:00' AS SmallDateTime), 23)
GO
INSERT Book(Title, Price, [Description], Images, CategoryID, AuthorID, Published, ViewCount) 
 VALUES (N'Visual Basic 2005 Tập 3, Quyển 2: Lập Trình Web', 20000.0000, N'"Visual Basic 2005 Tập 3, Quyển 2: Lập Trình Web Với Cơ Sở Dữ Liệu" sẽ cung cấp kỹ thuật và hướng dẫn bạn:
Tự học xây dựng ứng dụng Web quản lý CSDL toàn diện với ADO.NET 2.0 và ASP.NET. 
Khai thác các đối tượng và nguồn dữ liệu dành cho WebForm. 
Sử dụng các điều khiển dữ liệu đặc thù dành riêng cho ASP.NET và Web. 
Làm quen với những khái niệm xử lý dữ liệu hoàn toàn mới. 
Ràng buộc dữ liệu với các thành phần giao diện Web Forms. 
Thiết kế ứng dụng Web "Quản lý CD Shop" trực quan và thực tế. 
Cung cấp một kiến thức hoàn chỉnh về Web cho các bạn yêu thích ngôn ngữ Visual Basic và .NET Framework.
Sách có kèm theo CD-ROM bài tập.
Xin trân trọng giới thiệu cùng các bạn.', N'LTWeb2005.jpg', 4, 4, CAST(N'2004-07-18T00:00:00' AS SmallDateTime),0)
GO

INSERT Book(Title, Price, [Description], Images, CategoryID, AuthorID, Published, ViewCount)  
VALUES (N'Giáo trình Tin học quản lý 1',  21000.0000, N'Mạng Máy Tính Và Hệ Thống Bảo Mật gồm 7 chương:
Chương I: Tổng quan về công nghệ mạng máy tính và mạng cục bộ.
Chương II: Các thiết bị mạng thông dụng và các chuẩn kết nối vật lý.
Chương III: TCP/IP và mạng Internet.
Chương IV: Hệ điều hành mạng đặc điểm của hệ điều hành mạng.
Chương V: Một số vấn đề an toàn và bảo mật thông tin trên mạng máy tính.
Chương VI: Giới thiệu hệ điều hành Windows NT.
Chương VII: Giới thiệu hệ điều hành UNIX.
Trân trọng giới thiệu.', N'TH001.jpg', 3, 2, CAST(N'2004-06-18T00:00:00' AS SmallDateTime), 16)
GO
INSERT Book(Title, Price, [Description], Images, CategoryID, AuthorID, Published, ViewCount) 
 VALUES (N'Giáo trình Tin học quản lý 2',  21000.0000, N'Mục đích của bộ sách này giúp bạn trở nên thành thạo cơ sở dữ liệu (CSDL) Oracle9i, đề cập đến tất cả những kiến thức cần thiết từ mô hình dữ liệu, quản trị CSDL, sao lưu phục hồi, mạng và xử lý sự cố cũng như hiệu chỉnh hiệu suất thực thi..., với sự kết hợp lý thuyết và thực hành về điều mà Nhà quản trị CSDL Oracle9i cần biết để sử dụng CSDL Oracle9i một cách hiệu quả từ chính bộ sách này.
Bộ sách được chia làm 2 tập, tập 1 đề cập các kiến thức cơ bản về CSDL, mô hình dữ liệu. Bạn sẽ được biết về hệ quản trị CSDL Oracle9i, tạo CSDL, kết nối và quản lý người dùng. Tập 2 hướng dẫn bạn cách nạp, sao lưu và phục hồi dữ liệu, quản lý hoạt động CSDL Oracle9i, thực hiện hiệu chỉnh hiệu suất thực thi và xử lý sự cố cho CSDL.
Xin trân trọng giới thiệu Tập 1 cùng các bạn.', N'130499.jpg', 2, 4, CAST(N'2004-05-15T00:00:00' AS SmallDateTime), 65)
GO
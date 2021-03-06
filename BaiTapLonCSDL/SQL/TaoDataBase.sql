create database BaiTapLonHQT

USE [BaiTapLonHQT]

CREATE TABLE [dbo].[ChiTietMuon](
	[MaSach] [nchar](10) NULL,
	[MaMuon] [int] NULL
) ON [PRIMARY]

CREATE TABLE [dbo].[DocGia](
	[MaDocGia] [nchar](10) NOT NULL,
	[TenDocGia] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [date] NULL,
	[Khoa] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[LoaiSach](
	[MaLoai] [nchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiSach] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Muon](
	[MaDocGia] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL,
	[NgayMuon] [date] NULL,
	[GhiChu] [nvarchar](100) NULL,
	[MaMuon] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[SDT] [nchar](20) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Quyen] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
alter table nhanvien
add TenDangNhap nvarchar(50), MatKhau nvarchar(50);

CREATE TABLE [dbo].[Quyen](
	[Quyen] [nchar](10) NOT NULL,
	[TenQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[Quyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[Sach](
	[MaSach] [nchar](10) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[NXB] [nvarchar](50) NULL,
	[GiaSach] [float] NULL,
	[MaLoai] [nchar](10) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[Tra](
	[MaNV] [nchar](10) NULL,
	[NgayTra] [date] NULL,
	[GhiChu] [nvarchar](100) NULL,
	[MaMuon] [int] NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ChiTietMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTienMuon_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietMuon] CHECK CONSTRAINT [FK_ChiTienMuon_Sach]
GO
ALTER TABLE [dbo].[ChiTietMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMuon_Muon] FOREIGN KEY([MaMuon])
REFERENCES [dbo].[Muon] ([MaMuon])
GO
ALTER TABLE [dbo].[ChiTietMuon] CHECK CONSTRAINT [FK_ChiTietMuon_Muon]
GO
ALTER TABLE [dbo].[Muon]  WITH CHECK ADD  CONSTRAINT [FK_Muon_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[Muon] CHECK CONSTRAINT [FK_Muon_DocGia]
GO
ALTER TABLE [dbo].[Muon]  WITH CHECK ADD  CONSTRAINT [FK_Muon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Muon] CHECK CONSTRAINT [FK_Muon_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Quyen] FOREIGN KEY([Quyen])
REFERENCES [dbo].[Quyen] ([Quyen])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Quyen]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_LoaiSach] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSach] ([MaLoai])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_LoaiSach]
GO
ALTER TABLE [dbo].[Tra]  WITH CHECK ADD  CONSTRAINT [FK_Tra_Muon] FOREIGN KEY([MaMuon])
REFERENCES [dbo].[Muon] ([MaMuon])
GO
ALTER TABLE [dbo].[Tra] CHECK CONSTRAINT [FK_Tra_Muon]
GO
ALTER TABLE [dbo].[Tra]  WITH CHECK ADD  CONSTRAINT [FK_Tra_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Tra] CHECK CONSTRAINT [FK_Tra_NhanVien]
GO


insert into quyen values
('admin', 'admin');
select * from quyen 

insert into nhanvien values
('NV01', 'Tuan Tran', '0987678555', 'Ha Noi', 'admin', 'tuantran', '1');
select * from NhanVien 

insert into DocGia values
('DG01', 'Thanh Tung', 1, '12/20/2000', 'cntt', 'Ha Noi', 'em chi muon sach dung 1 hom thoi'),
('DG02', 'Phuong Hang', 0, '10/15/2001', 'kt', 'Hai Phong', 'em cung chi muon sach dung 1 hom thoi');
select * from DocGia 

insert into loaisach values
('TTTT', 'Tieu thuyet Trinh tham'),
('TTTN', 'Truyen tranh thieu nhi');
select * from LoaiSach 

insert into Sach values
('S01','Sherlock holmes', 'Kim dong', '150000', 'TTTT', 5),
('S02','Doraemon', 'Kim dong', '200000', 'TTTN', 10);
select * from Sach

insert into Muon values 
('DG01', 'NV01', '10/05/2020', 'muon sach mot hom'),
('DG02', 'NV01', '10/05/2020', 'muon sach mot hom');
select * from Muon 

insert into ChiTietMuon values 
('S01',1),
('S02',2);
select * from ChiTietMuon 

insert into Tra values 
('NV01', '10/06/2020', 'chi muon mot hom', 1),
('NV01', '10/06/2020', 'cung chi muon mot hom', 2);
select * from Tra 


 
 select * from quyen 
 select * from NhanVien 
 select * from DocGia 
 select * from LoaiSach 
 select * from Sach
 select * from Muon 
 select * from ChiTietMuon 
 select * from  Tra




 -- 1. HÀM truyền vào MaDocGia, trả về thông tin TenDocGia, NgaySinh, Gioi Tinh, SachMuon
 alter function ham_Tuan(@MaDocGia nchar(10))
 returns table as return (
 select docgia.MaDocGia, TenDocGia, NgaySinh, case GioiTinh when 0 then N'Nữ' when 1 then 'Nam' end as GioiTinh, TenSach from DocGia, Sach, Muon, ChiTietMuon
 where DocGia.MaDocGia = Muon.MaDocGia and Muon.MaMuon = ChiTietMuon.MaMuon 
 and Sach.MaSach=ChiTietMuon.MaSach and ChiTietMuon.MaSach = Sach.MaSach and @MaDocGia = Muon.MaDocGia
 )
 select * from ham_Tuan('DG01')


 -- 2. THỦ TỤC truyền vào MaDocGia, trả về hoten, tên sách của độc giả đó.
 alter proc proc_Tuan
 @MaDocGia nchar(10)
 as
begin
	select TenDocGia, TenSach from DocGia, Muon, Sach, ChiTietMuon
	where DocGia.MaDocGia = Muon.MaDocGia and Sach.MaSach = ChiTietMuon.MaSach and Muon.MaMuon = ChiTietMuon.MaMuon
	and @MaDocGia = Muon.MaDocGia
end
exec dbo.proc_Tuan @madocgia = 'DG03'


-- 3. TRIGGER xóa sách thay bằng chuyển số lượng thành 0
alter TRIGGER trigger_Tuan
ON Sach
INSTEAD OF DELETE 
AS
BEGIN
	update Sach set SoLuong = 0 where MaSach = (select MaSach from deleted);
END

delete from Sach where MaSach = 'S01'
select * from Sach

-- 4. VIEWS TenDocGia, NgayMuon, NgayTrađưa ra những độc giả đã mượn và trả sách
alter view DocGiaMuonSach 
as 
begin
if (select mamuon from muon) = (select mamuon from tra)
	select TenDocGia, NgayMuon, NgayTra from DocGia, Muon, Tra, ChiTietMuon 
	where DocGia.MaDocGia = Muon.MaDocGia and Muon.MaMuon = Tra.MaMuon and ChiTietMuon.MaMuon = Muon.MaMuon
else
	select TenDocGia, NgayMuon from DocGia, Muon, ChiTietMuon 
	where DocGia.MaDocGia = Muon.MaDocGia and ChiTietMuon.MaMuon = Muon.MaMuon
end
select * from DocGiaMuonSach 

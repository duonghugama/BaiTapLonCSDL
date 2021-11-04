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
 --proc đếm tổng số sách trong kho
create proc sp_tongsach
as begin
	 select sum(soluong) as N'tong sach trong kho' from Sach 
end

select * from sach
exec sp_tongsach
 go

 --trigger mỗi khi thêm chi tiết mượn thì số lượng sách -1
create trigger trg_ThemCTM on chitietmuon for insert 
as begin 
update sach
set soluong = (soluong - (Select count(mamuon) from inserted)) where MaSach = (select masach from inserted)
end

select * from sach
select * from ChiTietMuon
insert into ChiTietMuon values
('T1','5');
go
 --view chứa thông tin của giao dịch mượn
create view thongtinM as 
select nhanvien.MaNV,TenNV,NgayMuon,docgia.MaDocGia,TenDocGia 
from NhanVien,DocGia,Muon,ChiTietMuon 
where (dbo.NhanVien.MaNV = dbo.Muon.MaNV) and (dbo.DocGia.MaDocGia = dbo.Muon.MaDocGia) and (dbo.ChiTietMuon.MaMuon = dbo.Muon.MaMuon)

select * from thongtinM
select * from ChiTietMuon

--func Tổng số sách đã mượn
go
create function fun_TongsachM() 
returns int 
as begin 
declare @tong int
select @tong = (select count(mamuon) from ChiTietMuon )
return @tong;
end

select dbo.fun_TongsachM()

-- Xóa sách đã chỉ định với điều kiện chỉ có duy nhất tên sách đó
begin tran XoaS
delete from Sach where TenSach = 'Ngu van'
if (@@ROWCOUNT > 1 )
begin 
rollback tran XoaS
print N'Huy xoa Sach'
end
else 
begin
commit tran XoaS
print N'Da xoa Sach'
end
--con trỏ để khi thấy số ngày mượn quá 40 thì chập nhật ghi chú thành 'tra dung han' còn ngược lại thành 'tra muon'
declare MuonCursor cursor for select MaDocGia,datediff(day,NgayMuon,NgayTra) from muon left join tra on muon.MaMuon = tra.MaMuon
open MuonCursor 
declare @Madocgia nchar(10)
declare @songaymuon int
fetch next from MuonCursor into @Madocgia,@songaymuon
while @@FETCH_STATUS = 0
begin
if @songaymuon < 40
begin
update Muon set GhiChu = N'tra dung han' where @Madocgia = MaDocGia
end
else 
begin
update Muon set GhiChu = N'tra muon' where @Madocgia = MaDocGia
end
fetch next from MuonCursor into @Madocgia,@songaymuon
end
close MuonCursor
deallocate MuonCursor
select * from Tra
select * from Muon


select * from nhanvien


Grant select,insert,update on chitietmuon to nhanvien
Grant select,insert,update on docgia to nhanvien
Grant select,insert,update on loaisach to nhanvien
Grant select,insert,update on muon to nhanvien
Grant select,insert,update on sach to nhanvien
Grant select,insert,update on tra to nhanvien




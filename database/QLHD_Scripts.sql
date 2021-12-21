use master
go
if db_id('QLHD') is not null
	drop database QLHD
go


create database [QLHD]
GO

USE [QLHD]
GO
/****** Object:  Table [dbo].[CHINHANH]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHINHANH](
	[MaCN] [nvarchar](100) NOT NULL,
	[MaDT] [nvarchar](100) NOT NULL,
	[SoNha_CN] [int] NULL,
	[Duong_CN] [nvarchar](100) NULL,
	[Phuong_CN] [nvarchar](100) NULL,
	[Quan_CN] [nvarchar](100) NULL,
	[ThanhPho_CN] [nvarchar](100) NULL,
 CONSTRAINT [PK_CN] PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC,
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_DONHANG]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_DONHANG](
	[MaDH] [nvarchar](100) NOT NULL,
	[MaSP] [nvarchar](100) NOT NULL,
	[SoLuong] [int] NULL,
	[GiaTien] [money] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_CTDH] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_HOPDONG]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HOPDONG](
	[MaHD] [nvarchar](100) NOT NULL,
	[MaDT] [nvarchar](100) NOT NULL,
	[MaCNhanh] [nvarchar](100) NOT NULL,
	[DiaChi_CN] [nvarchar](500) NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaDT] ASC,
	[MaCNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOANHTHU_DT]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOANHTHU_DT](
	[MaDT] [nvarchar](100) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[DoanhThu] [money] NULL,
	[PhiHoaHong] [money] NULL,
 CONSTRAINT [PK_DTDT] PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC,
	[Thang] ASC,
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOITAC]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOITAC](
	[MaDT] [nvarchar](100) NOT NULL,
	[TenDT] [nvarchar](100) NULL,
	[NguoiDaiDien] [nvarchar](100) NULL,
	[SoChiNhanh] [int] NULL,
	[SoLuongDH] [int] NULL,
	[LoaiHang] [nvarchar](100) NULL,
	[SDT_DT] [varchar](100) NULL,
	[Email_DT] [nvarchar](100) NULL,
	[MaSoThue] [nvarchar](100) NULL,
	[SoNha] [int] NULL,
	[Duong] [nvarchar](100) NULL,
	[Phuong] [nvarchar](100) NULL,
	[Quan] [nvarchar](100) NULL,
	[ThanhPho] [nvarchar](100) NULL,
 CONSTRAINT [PK_DT] PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONHANG]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONHANG](
	[MaDH] [nvarchar](100) NOT NULL,
	[MaKH] [nvarchar](100) NULL,
	[MaTX] [nvarchar](100) NULL,
	[TinhTrangDH] [nvarchar](100) NULL,
	[HinhThucThanhToan] [nvarchar](100) NULL,
	[DiaChiGiao] [nvarchar](100) NULL,
	[PhiVC] [money] NULL,
	[TongTien] [money] NULL,
	[ThoiGianDatHang] [datetime] NULL,
 CONSTRAINT [PK_DH] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOPDONG]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOPDONG](
	[MaHD] [nvarchar](100) NOT NULL,
	[MaNV] [nvarchar](100) NULL,
	[MaDT] [nvarchar](100) NULL,
	[MaSoThue_HD] [nvarchar](100) NULL,
	[NguoiDaiDien_HD] [nvarchar](100) NULL,
	[SoChiNhanhDK] [int] NULL,
	[PhiKichHoat] [money] NULL,
	[PhanTramHoaHong] [int] NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
 CONSTRAINT [PK_HD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](100) NOT NULL,
	[TenKH] [nvarchar](100) NULL,
	[SDT_KH] [varchar](100) NULL,
	[Email_KH] [nvarchar](100) NULL,
	[SoNha_KH] [int] NULL,
	[Duong_KH] [nvarchar](100) NULL,
	[Phuong_KH] [nvarchar](100) NULL,
	[Quan_KH] [nvarchar](100) NULL,
	[ThanhPho_KH] [nvarchar](100) NULL,
 CONSTRAINT [PK_KH] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIHANG]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHANG](
	[MaLH] [nvarchar](100) NOT NULL,
	[TenLH] [nvarchar](100) NULL,
 CONSTRAINT [PK_LH] PRIMARY KEY CLUSTERED 
(
	[MaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](100) NOT NULL,
	[TenNV] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](100) NULL,
 CONSTRAINT [PK_NV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUANLY]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLY](
	[MAQL] [nvarchar](100) NOT NULL,
	[TenQL] [nvarchar](100) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [nvarchar](100) NULL,
	[UserNameQL] [nvarchar](100) NULL,
	[PasswordQL] [nvarchar](100) NULL,
 CONSTRAINT [PK_QL] PRIMARY KEY CLUSTERED 
(
	[MAQL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [nvarchar](100) NOT NULL,
	[MaDT] [nvarchar](100) NULL,
	[TenSP] [nvarchar](100) NULL,
	[MaCN] [nvarchar](100) NULL,
	[GiaBan] [money] NULL,
	[GiaGiam] [money] NULL,
	[MaLoaiHang] [nvarchar](100) NULL,
	[HinhAnh] [varchar](150) NULL
 CONSTRAINT [PK_SP] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MaND] [nvarchar](100) NOT NULL,
	[UserID] [nvarchar](100) NULL,
	[UserPassword] [nvarchar](100) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_TK] PRIMARY KEY CLUSTERED 
(
	[MaND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIXE]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIXE](
	[MaTX] [nvarchar](100) NOT NULL,
	[TenTX] [nvarchar](100) NULL,
	[CMND] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[SDT_TX] [varchar](100) NULL,
	[BienSoXe] [nvarchar](100) NULL,
	[KhuVucHoatDong] [nvarchar](100) NULL,
	[Email_TX] [nvarchar](100) NULL,
	[TKNganHang] [nvarchar](200) NULL,
	[ThuNhap] [money] NULL,
	[SoNha_TX] [int] NULL,
	[Duong_TX] [nvarchar](100) NULL,
	[Phuong_TX] [nvarchar](100) NULL,
	[Quan_TX] [nvarchar](100) NULL,
	[ThanhPho_TX] [nvarchar](100) NULL,
 CONSTRAINT [PK_TX] PRIMARY KEY CLUSTERED 
(
	[MaTX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUNHAP_TAIXE]    Script Date: 12/12/2021 12:01:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUNHAP_TAIXE](
	[MaTX] [nvarchar](100) NOT NULL,
	[MaDH] [nvarchar](100) NOT NULL,
	[PhiVanChuyen_TX] [money] NULL,
 CONSTRAINT [PK_TNTX] PRIMARY KEY CLUSTERED 
(
	[MaTX] ASC,
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHINHANH] ([MaCN], [MaDT], [SoNha_CN], [Duong_CN], [Phuong_CN], [Quan_CN], [ThanhPho_CN]) VALUES (N'CN1', N'DT3', 245, N'Nguyễn Văn Tố', N'Phường Hàng Bông', N'Quận Thanh Xuân', N'Hà Nội')
INSERT [dbo].[CHINHANH] ([MaCN], [MaDT], [SoNha_CN], [Duong_CN], [Phuong_CN], [Quan_CN], [ThanhPho_CN]) VALUES (N'CN2', N'DT3', 25, N'Nguyễn Khuyến', N'Phường 12', N'Quận 11', N'TPHCM')
INSERT [dbo].[CHINHANH] ([MaCN], [MaDT], [SoNha_CN], [Duong_CN], [Phuong_CN], [Quan_CN], [ThanhPho_CN]) VALUES (N'CN1', N'DT5', 545, N'Nguyễn Giao', N'Phường 22', N'Quận 5', N'TPHCM')
INSERT [dbo].[CHINHANH] ([MaCN], [MaDT], [SoNha_CN], [Duong_CN], [Phuong_CN], [Quan_CN], [ThanhPho_CN]) VALUES (N'CN2', N'DT5', 75, N'Lãnh Binh Tòng', N'Phường Hàng Bồ', N'Quận Bắc Từ Liêm', N'Hà Nội')
INSERT [dbo].[CHINHANH] ([MaCN], [MaDT], [SoNha_CN], [Duong_CN], [Phuong_CN], [Quan_CN], [ThanhPho_CN]) VALUES (N'CN1', N'DT6', 715, N'Nguyễn Bỉnh Khiêm', N'Phường 7', N'Quận 8', N'TPHCM')
INSERT [dbo].[CHINHANH] ([MaCN], [MaDT], [SoNha_CN], [Duong_CN], [Phuong_CN], [Quan_CN], [ThanhPho_CN]) VALUES (N'CN1', N'DT7', 715, N'Hoàng Diệu', N'Phường 17', N'Quận 1', N'TPHCM')
GO
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH22', N'SP15', 2, 4900.0000, 9800.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH22', N'SP2', 3, 1000.0000, 3000.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH31', N'SP1', 4, 2000.0000, 8000.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH31', N'SP19', 1, 400.0000, 400.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH43', N'SP10', 1, 1400.0000, 1400.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH43', N'SP20', 3, 900.0000, 2700.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH69', N'SP21', 5, 3900.0000, 19500.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH69', N'SP3', 5, 1222.0000, 6110.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH74', N'SP14', 1, 4900.0000, 4900.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH74', N'SP4', 4, 2333.0000, 9332.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH81', N'SP18', 3, 900.0000, 2700.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH81', N'SP6', 5, 2000.0000, 10000.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH92', N'SP5', 1, 611.0000, 611.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH92', N'SP8', 4, 1900.0000, 7600.0000)
GO
INSERT [dbo].[CT_HOPDONG] ([MaHD], [MaDT], [MaCNhanh], [DiaChi_CN]) VALUES (N'HD1', N'DT5', N'CN1', N'545, Nguyễn Giao, Phường 22, Quận 5, TPHCM')
INSERT [dbo].[CT_HOPDONG] ([MaHD], [MaDT], [MaCNhanh], [DiaChi_CN]) VALUES (N'HD10', N'DT3', N'CN2', N'25, Nguyễn Khuyến, Phường 12, Quận 11, TPHCM')
INSERT [dbo].[CT_HOPDONG] ([MaHD], [MaDT], [MaCNhanh], [DiaChi_CN]) VALUES (N'HD7', N'DT3', N'CN1', N'245, Nguyễn Văn Tố, Phường Hàng Bông, Quận Thanh Xuân, Hà Nội')
INSERT [dbo].[CT_HOPDONG] ([MaHD], [MaDT], [MaCNhanh], [DiaChi_CN]) VALUES (N'HD8', N'DT7', N'CN1', N'715, Hoàng Diệu, Phường 17, Quận 1, TPHCM')
INSERT [dbo].[CT_HOPDONG] ([MaHD], [MaDT], [MaCNhanh], [DiaChi_CN]) VALUES (N'HD9', N'DT6', N'CN1', N'715, Nguyễn Bỉnh Khiêm, Phường 7, Quận 8, TPHCM')
GO
INSERT [dbo].[DOANHTHU_DT] ([MaDT], [Thang], [Nam], [DoanhThu], [PhiHoaHong]) VALUES (N'DT3', 4, 2018, 8000.0000, 800.0000)
INSERT [dbo].[DOANHTHU_DT] ([MaDT], [Thang], [Nam], [DoanhThu], [PhiHoaHong]) VALUES (N'DT3', 8, 2018, NULL, NULL)
INSERT [dbo].[DOANHTHU_DT] ([MaDT], [Thang], [Nam], [DoanhThu], [PhiHoaHong]) VALUES (N'DT5', 3, 2018, NULL, NULL)
INSERT [dbo].[DOANHTHU_DT] ([MaDT], [Thang], [Nam], [DoanhThu], [PhiHoaHong]) VALUES (N'DT5', 7, 2018, NULL, NULL)
INSERT [dbo].[DOANHTHU_DT] ([MaDT], [Thang], [Nam], [DoanhThu], [PhiHoaHong]) VALUES (N'DT6', 1, 2018, NULL, NULL)
INSERT [dbo].[DOANHTHU_DT] ([MaDT], [Thang], [Nam], [DoanhThu], [PhiHoaHong]) VALUES (N'DT6', 5, 2018, NULL, NULL)
INSERT [dbo].[DOANHTHU_DT] ([MaDT], [Thang], [Nam], [DoanhThu], [PhiHoaHong]) VALUES (N'DT6', 9, 2018, NULL, NULL)
INSERT [dbo].[DOANHTHU_DT] ([MaDT], [Thang], [Nam], [DoanhThu], [PhiHoaHong]) VALUES (N'DT7', 2, 2018, NULL, NULL)
INSERT [dbo].[DOANHTHU_DT] ([MaDT], [Thang], [Nam], [DoanhThu], [PhiHoaHong]) VALUES (N'DT7', 6, 2018, NULL, NULL)
INSERT [dbo].[DOANHTHU_DT] ([MaDT], [Thang], [Nam], [DoanhThu], [PhiHoaHong]) VALUES (N'DT7', 10, 2018, NULL, NULL)
GO
INSERT [dbo].[DOITAC] ([MaDT], [TenDT], [NguoiDaiDien], [SoChiNhanh], [SoLuongDH], [LoaiHang], [SDT_DT], [Email_DT], [MaSoThue], [SoNha], [Duong], [Phuong], [Quan], [ThanhPho]) VALUES (N'DT3', N'MÙA HÈ', N'Nguyễn Thanh Hiền', 3, 100, N'LH1', N'6748329108', N'mh@gmail.com', N'123', 12, N'Lạc Long Quân', N'Phường 2', N'Quận 2', N'TPHCM')
INSERT [dbo].[DOITAC] ([MaDT], [TenDT], [NguoiDaiDien], [SoChiNhanh], [SoLuongDH], [LoaiHang], [SDT_DT], [Email_DT], [MaSoThue], [SoNha], [Duong], [Phuong], [Quan], [ThanhPho]) VALUES (N'DT5', N'PHI ĐIỂU', N'Nguyễn Tiểu Mi', 2, 102, N'LH4', N'6748320008', N'pd@gmail.com', N'456', 3, N'Hữu Nghị', N'Phường 4', N'Quận 6', N'TPHCM')
INSERT [dbo].[DOITAC] ([MaDT], [TenDT], [NguoiDaiDien], [SoChiNhanh], [SoLuongDH], [LoaiHang], [SDT_DT], [Email_DT], [MaSoThue], [SoNha], [Duong], [Phuong], [Quan], [ThanhPho]) VALUES (N'DT6', N'VE SẦU', N'Huỳnh Thanh Mỹ', 1, 104, N'LH6', N'6748329000', N'vs@gmail.com', N'789', 34, N'Nguyễn Xí', N'Phường 10', N'Quận 10', N'TPHCM')
INSERT [dbo].[DOITAC] ([MaDT], [TenDT], [NguoiDaiDien], [SoChiNhanh], [SoLuongDH], [LoaiHang], [SDT_DT], [Email_DT], [MaSoThue], [SoNha], [Duong], [Phuong], [Quan], [ThanhPho]) VALUES (N'DT7', N'MÙA ĐÔNG', N'Nguyễn Kim Ngân', 2, 101, N'LH9', N'6748009108', N'md@gmail.com', N'113', 16, N'Quang Trung', N'Phường 2', N'Quận 5', N'TPHCM')
GO
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH13', N'KH5', N'TX5', N'Đang giao', N'Thanh toán sau', N'34, Tô Hiến Thành, Phường 3, Quận 10, TPHCM', 100.0000, 19830.0000, CAST(N'2018-05-11T19:39:57.690' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH17', N'KH5', N'TX5', N'Đang giao', N'Thanh toán trước', N'34, Tô Hiến Thành, Phường 3, Quận 10, TPHCM', 30.0000, 6130.0000, CAST(N'2020-01-27T12:58:14.630' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH19', N'KH7', N'TX7', N'Đang giao', N'Thanh toán trước', N'342, Võ Văn Ngân, Phường 12, Quận 2, TPHCM', 30.0000, 3930.0000, CAST(N'2020-10-08T19:59:26.890' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH22', N'KH5', N'TX5', N'Đã giao', N'Thanh toán sau', N'34, Tô Hiến Thành, Phường 3, Quận 10, TPHCM', 30.0000, 12830.0000, CAST(N'2021-06-22T15:58:28.760' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH31', N'KH1', N'TX1', N'Đã giao', N'Thanh toán sau', N'14, Nguyễn Huệ, Phường 2, Quận 1, TPHCM', 30.0000, 8430.0000, CAST(N'2018-04-22T15:12:50.340' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH43', N'KH3', N'TX3', N'Đang giao', N'Thanh toán trước', N'4, Võ Thị Sáu, Phường 5, Quận 4, TPHCM', 30.0000, 4130.0000, CAST(N'2019-08-18T10:39:59.020' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH69', N'KH3', N'TX3', N'Đã giao', N'Thanh toán trước', N'4, Võ Thị Sáu, Phường 5, Quận 4, TPHCM', 30.0000, 25640.0000, CAST(N'2018-11-17T20:05:25.500' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH74', N'KH5', N'TX5', N'Đang giao', N'Thanh toán sau', N'34, Tô Hiến Thành, Phường 3, Quận 10, TPHCM', 30.0000, 14262.0000, CAST(N'2019-10-17T17:26:44.990' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH81', N'KH5', N'TX5', N'Đang chuẩn bị hàng', N'Thanh toán sau', N'34, Tô Hiến Thành, Phường 3, Quận 10, TPHCM', 30.0000, 12730.0000, CAST(N'2018-09-07T15:13:46.320' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH92', N'KH7', N'TX7', N'Đang chuẩn bị hàng', N'Thanh toán trước', N'342, Võ Văn Ngân, Phường 12, Quận 2, TPHCM', 30.0000, 8241.0000, CAST(N'2019-07-10T02:36:12.460' AS DateTime))
GO
INSERT [dbo].[HOPDONG] ([MaHD], [MaNV], [MaDT], [MaSoThue_HD], [NguoiDaiDien_HD], [SoChiNhanhDK], [PhiKichHoat], [PhanTramHoaHong], [NgayBatDau], [NgayKetThuc]) VALUES (N'HD1', N'NV5', N'DT5', N'456', N'Nguyễn Tiểu Mi', 1, 1000.0000, 10, CAST(N'2018-12-11' AS Date), CAST(N'2021-12-03' AS Date))
INSERT [dbo].[HOPDONG] ([MaHD], [MaNV], [MaDT], [MaSoThue_HD], [NguoiDaiDien_HD], [SoChiNhanhDK], [PhiKichHoat], [PhanTramHoaHong], [NgayBatDau], [NgayKetThuc]) VALUES (N'HD10', N'NV7', N'DT3', N'123', N'Nguyễn Thanh Hiền', 1, 1000.0000, 10, CAST(N'2020-01-19' AS Date), CAST(N'2021-08-16' AS Date))
INSERT [dbo].[HOPDONG] ([MaHD], [MaNV], [MaDT], [MaSoThue_HD], [NguoiDaiDien_HD], [SoChiNhanhDK], [PhiKichHoat], [PhanTramHoaHong], [NgayBatDau], [NgayKetThuc]) VALUES (N'HD7', N'NV7', N'DT3', N'123', N'Nguyễn Thanh Hiền', 1, 1000.0000, 10, CAST(N'2018-08-30' AS Date), CAST(N'2022-08-14' AS Date))
INSERT [dbo].[HOPDONG] ([MaHD], [MaNV], [MaDT], [MaSoThue_HD], [NguoiDaiDien_HD], [SoChiNhanhDK], [PhiKichHoat], [PhanTramHoaHong], [NgayBatDau], [NgayKetThuc]) VALUES (N'HD8', N'NV5', N'DT7', N'113', N'Nguyễn Kim Ngân', 1, 1000.0000, 10, CAST(N'2018-12-06' AS Date), CAST(N'2020-08-31' AS Date))
INSERT [dbo].[HOPDONG] ([MaHD], [MaNV], [MaDT], [MaSoThue_HD], [NguoiDaiDien_HD], [SoChiNhanhDK], [PhiKichHoat], [PhanTramHoaHong], [NgayBatDau], [NgayKetThuc]) VALUES (N'HD9', N'NV5', N'DT6', N'789', N'Huỳnh Thanh Mỹ', 1, 1000.0000, 10, CAST(N'2018-09-09' AS Date), CAST(N'2020-08-17' AS Date))
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT_KH], [Email_KH], [SoNha_KH], [Duong_KH], [Phuong_KH], [Quan_KH], [ThanhPho_KH]) VALUES (N'KH1', N'Nguyễn Giang Mai', N'1234567890', N'gm@gmail.com', 14, N'Nguyễn Huệ', N'Phường 2', N'Quận 1', N'TPHCM')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT_KH], [Email_KH], [SoNha_KH], [Duong_KH], [Phuong_KH], [Quan_KH], [ThanhPho_KH]) VALUES (N'KH3', N'Trần Gia', N'1234567000', N'tg@gmail.com', 4, N'Võ Thị Sáu', N'Phường 5', N'Quận 4', N'TPHCM')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT_KH], [Email_KH], [SoNha_KH], [Duong_KH], [Phuong_KH], [Quan_KH], [ThanhPho_KH]) VALUES (N'KH5', N'Lê Thụy', N'1234007000', N'lt@gmail.com', 34, N'Tô Hiến Thành', N'Phường 3', N'Quận 10', N'TPHCM')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT_KH], [Email_KH], [SoNha_KH], [Duong_KH], [Phuong_KH], [Quan_KH], [ThanhPho_KH]) VALUES (N'KH6', N'Huỳnh Hiền', N'1114567000', N'hh@gmail.com', 120, N'Tạ Quang Bửu', N'Phường 4', N'Quận 12', N'TPHCM')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT_KH], [Email_KH], [SoNha_KH], [Duong_KH], [Phuong_KH], [Quan_KH], [ThanhPho_KH]) VALUES (N'KH7', N'Ngụy Trạm', N'1234333000', N'nt@gmail.com', 342, N'Võ Văn Ngân', N'Phường 12', N'Quận 2', N'TPHCM')
GO
INSERT [dbo].[LOAIHANG] ([MaLH], [TenLH]) VALUES (N'LH1', N'Sách')
INSERT [dbo].[LOAIHANG] ([MaLH], [TenLH]) VALUES (N'LH4', N'Bếp')
INSERT [dbo].[LOAIHANG] ([MaLH], [TenLH]) VALUES (N'LH6', N'Công nghệ')
INSERT [dbo].[LOAIHANG] ([MaLH], [TenLH]) VALUES (N'LH9', N'Thời trang')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh]) VALUES (N'NV5', N'Nguyễn Du', CAST(N'1999-02-10' AS Date), N'Nam')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh]) VALUES (N'NV7', N'Trần Diệu', CAST(N'1993-10-02' AS Date), N'Nữ')
GO
INSERT [dbo].[QUANLY] ([MAQL], [TenQL], [NGAYSINH], [GIOITINH], [UserNameQL], [PasswordQL]) VALUES (N'QL1', N'Đặng Luân', CAST(N'1992-01-24' AS Date), N'Nam', N'dlv', N'1345')
GO
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP1', N'DT3', N'Đắc Nhân Tâm', N'CN1', 3000.0000, 2000.0000, N'LH1','https://eccthai.com/wp-content/uploads/2021/01/sach-dac-nhan-tam-dale-carnegie.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP10', N'DT5', N'Kệ bếp', N'CN1', 1500.0000, 100.0000, N'LH4','https://cf.shopee.vn/file/25219aa3c945728947474ee81080f196')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP11', N'DT5', N'Tủ lạnh BANANA', N'CN2', 5000.0000, 100.0000, N'LH4','https://cdn01.dienmaycholon.vn/filewebdmclnew/public//picture/product/product17354/product_17354_4.png')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP12', N'DT5', N'Lò nướng BANANA', N'CN2', 2000.0000, 100.0000, N'LH4','https://cdn01.dienmaycholon.vn/filewebdmclnew/public//picture/product/product16470/product_16470_3.png')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP13', N'DT5', N'Nồi chiên không dầu ZY', N'CN2', 4000.0000, 100.0000, N'LH4','https://product.hstatic.net/200000227393/product/hd965091-3_29e4a9d38242434d9c904e6441258602_master.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP14', N'DT6', N'Tivi SONY 200INCH', N'CN1', 5000.0000, 100.0000, N'LH6','https://vn-test-11.slatic.net/p/84b085244a963fbcbd7580fa342912bf.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP15', N'DT6', N'Laptop Dell PS100', N'CN1', 5000.0000, 100.0000, N'LH6','https://product.hstatic.net/1000331874/product/laptop-dell-xps-15-9570-04_945e2c0070a14bda93b06dbd8e502060_master.png')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP17', N'DT6', N'PS5', N'CN1', 4000.0000, 200.0000, N'LH6','https://cdn.vjshop.vn/hightech/may-choi-game/ps5/sony-ps-5-1.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP18', N'DT6', N'Bàn phím AKKO', N'CN1', 1000.0000, 100.0000, N'LH6','https://phucanhcdn.com/media/product/38287_akko_3087_world_tour_tokyo_h1.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP19', N'DT6', N'Chuột Logitech', N'CN1', 500.0000, 100.0000, N'LH6','https://hanoicomputercdn.com/media/product/54216_chuot_choi_game_khong_day_logitech_g502_lightspeed_usb_rgb_den_0000_1.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP2', N'DT3', N'Nhà giả kim', N'CN1', 2000.0000, 1000.0000, N'LH1','https://shop.ask.com.vn/wp-content/uploads/2021/06/A%CC%89nh-online-SA%CC%81CH-SP-kha%CC%81c_ASK-SHOP-15-1.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP20', N'DT7', N'Giày Nike 1000A', N'CN1', 1000.0000, 100.0000, N'LH9','https://product.hstatic.net/1000008082/product/26.2_c1565788ce134eb2874a7c0a7ad0037a_master.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP21', N'DT7', N'Ví GUCCI GOLD', N'CN1', 4000.0000, 100.0000, N'LH9','https://cf.shopee.vn/file/1c15afa8a98c7a3a8092160b136feb2c')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP22', N'DT7', N'Áo thun DOSIDA', N'CN1', 400.0000, 300.0000, N'LH9','https://xuongmayaothunvt.com/wp-content/uploads/2021/04/ao-thun-co-tron-duoc-thiet-ke-voi-dac-diem-la-co-ao-tron.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP3', N'DT3', N'Dạy Con Làm Giàu', N'CN1', 2222.0000, 1000.0000, N'LH1','https://trinhdinhlinh.com/sach/wp-content/uploads/2017/11/001-000-81.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP4', N'DT3', N'Khi con người biết nói', N'CN1', 3333.0000, 1000.0000, N'LH1','https://nuhado.co/wp-content/uploads/2020/03/kheo-an-noi-se-co-duoc-thien-ha.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP5', N'DT3', N'Harry Potter', N'CN2', 1111.0000, 500.0000, N'LH1','https://cdn0.fahasa.com/media/catalog/product/cache/1/small_image/600x600/9df78eab33525d08d6e5fb8d27136e95/c/o/combo0112072017_2.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP6', N'DT3', N'Alice in Wonderland', N'CN2', 2500.0000, 500.0000, N'LH1','https://downloadsach.com/wp-content/uploads/2017/01/Alice-o-xu-so-dieu-ky-Lewis-Carroll.gif')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP7', N'DT5', N'Bếp điện từ', N'CN1', 500.0000, 100.0000, N'LH4','https://bizweb.dktcdn.net/thumb/1024x1024/100/213/727/products/561-shb9105-4e1b3f33-dc1d-4ae4-8dab-169cdf03264c.jpg?v=1606134119587')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP8', N'DT5', N'Bộ chén kim cương', N'CN1', 2000.0000, 100.0000, N'LH4','https://salt.tikicdn.com/ts/product/b6/be/69/6401019ac9647fce961ffbd437b7fac9.jpg')
INSERT [dbo].[SANPHAM] ([MaSP], [MaDT], [TenSP], [MaCN], [GiaBan], [GiaGiam], [MaLoaiHang],[HinhAnh]) VALUES (N'SP9', N'DT5', N'Bộ đũa mạ vàng 9999', N'CN1', 2500.0000, 200.0000, N'LH4','https://ae01.alicdn.com/kf/Hf737fd09d6514c029b6a0ce16ec4a4eeV/6-i-a-Inox-D-i-M-V-ng-Vu-ng-a-Sushi-C-Th-T.jpg_Q90.jpg_.webp')
GO
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'DT3', N'jys', N'DT4434', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'DT5', N'dke', N'DT9655', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'DT6', N'mct', N'DT2093', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'DT7', N'lon', N'DT2094', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'KH1', N'fuo', N'2282', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'KH3', N'ofa', N'4434', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'KH5', N'tkj', N'9655', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'KH6', N'vny', N'2093', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'KH7', N'ufj', N'2094', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'NV5', N'fgu', N'4179', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'NV7', N'jnq', N'5718', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'TX1', N'gwp', N'0041', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'TX3', N'pwh', N'0730', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'TX5', N'ujt', N'5142', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'TX6', N'bjh', N'4446', 1)
INSERT [dbo].[TAIKHOAN] ([MaND], [UserID], [UserPassword], [TrangThai]) VALUES (N'TX7', N'vts', N'9379', 1)
GO
INSERT [dbo].[TAIXE] ([MaTX], [TenTX], [CMND], [GioiTinh], [NgaySinh], [SDT_TX], [BienSoXe], [KhuVucHoatDong], [Email_TX], [TKNganHang], [ThuNhap], [SoNha_TX], [Duong_TX], [Phuong_TX], [Quan_TX], [ThanhPho_TX]) VALUES (N'TX1', N'Trần Cương', N'123456789', N'Nam', CAST(N'1988-01-12' AS Date), N'0987654321', N'AX-34355', N'Quận 2', N'df@gmail.com', N'123456', 12.0000, 12, N'Nguyễn Du', N'Phường 4', N'Quận 2', N'TPHCM')
INSERT [dbo].[TAIXE] ([MaTX], [TenTX], [CMND], [GioiTinh], [NgaySinh], [SDT_TX], [BienSoXe], [KhuVucHoatDong], [Email_TX], [TKNganHang], [ThuNhap], [SoNha_TX], [Duong_TX], [Phuong_TX], [Quan_TX], [ThanhPho_TX]) VALUES (N'TX3', N'Lam Trạm', N'1200056789', N'Nam', CAST(N'1996-03-14' AS Date), N'0987650021', N'LT-34388', N'Quận 4', N'ltt@gmail.com', N'100026', 12.0000, 2, N'Trần Hưng Đạo', N'Phường 5', N'Quận 10', N'TPHCM')
INSERT [dbo].[TAIXE] ([MaTX], [TenTX], [CMND], [GioiTinh], [NgaySinh], [SDT_TX], [BienSoXe], [KhuVucHoatDong], [Email_TX], [TKNganHang], [ThuNhap], [SoNha_TX], [Duong_TX], [Phuong_TX], [Quan_TX], [ThanhPho_TX]) VALUES (N'TX5', N'Tinh Trần', N'123777779', N'Nam', CAST(N'1991-10-01' AS Date), N'0987004321', N'TT-00355', N'Quận 6', N'tt@gmail.com', N'100456', 12.0000, 54, N'Hồ Ngọc Lãm', N'Phường 10', N'Quận 2', N'TPHCM')
INSERT [dbo].[TAIXE] ([MaTX], [TenTX], [CMND], [GioiTinh], [NgaySinh], [SDT_TX], [BienSoXe], [KhuVucHoatDong], [Email_TX], [TKNganHang], [ThuNhap], [SoNha_TX], [Duong_TX], [Phuong_TX], [Quan_TX], [ThanhPho_TX]) VALUES (N'TX6', N'Chu Thước', N'123456000', N'Nam', CAST(N'1990-12-04' AS Date), N'0987654000', N'CT-34355', N'Quận 8', N'ct@gmail.com', N'120056', 12.0000, 124, N'Đặng Văn Bi', N'Phường 4', N'Quận 1', N'TPHCM')
INSERT [dbo].[TAIXE] ([MaTX], [TenTX], [CMND], [GioiTinh], [NgaySinh], [SDT_TX], [BienSoXe], [KhuVucHoatDong], [Email_TX], [TKNganHang], [ThuNhap], [SoNha_TX], [Duong_TX], [Phuong_TX], [Quan_TX], [ThanhPho_TX]) VALUES (N'TX7', N'Ôn Hành', N'123450009', N'Nam', CAST(N'1991-12-11' AS Date), N'0980054321', N'OH-34355', N'Quận 10', N'oh@gmail.com', N'123156', 12.0000, 146, N'Cộng Hòa', N'Phường 13', N'Quận 6', N'TPHCM')
GO
INSERT [dbo].[THUNHAP_TAIXE] ([MaTX], [MaDH], [PhiVanChuyen_TX]) VALUES (N'TX1', N'DH13', 6.0000)
INSERT [dbo].[THUNHAP_TAIXE] ([MaTX], [MaDH], [PhiVanChuyen_TX]) VALUES (N'TX1', N'DH17', 6.0000)
INSERT [dbo].[THUNHAP_TAIXE] ([MaTX], [MaDH], [PhiVanChuyen_TX]) VALUES (N'TX3', N'DH22', 6.0000)
INSERT [dbo].[THUNHAP_TAIXE] ([MaTX], [MaDH], [PhiVanChuyen_TX]) VALUES (N'TX3', N'DH43', 6.0000)
INSERT [dbo].[THUNHAP_TAIXE] ([MaTX], [MaDH], [PhiVanChuyen_TX]) VALUES (N'TX5', N'DH19', 6.0000)
INSERT [dbo].[THUNHAP_TAIXE] ([MaTX], [MaDH], [PhiVanChuyen_TX]) VALUES (N'TX5', N'DH69', 6.0000)
INSERT [dbo].[THUNHAP_TAIXE] ([MaTX], [MaDH], [PhiVanChuyen_TX]) VALUES (N'TX6', N'DH31', 6.0000)
INSERT [dbo].[THUNHAP_TAIXE] ([MaTX], [MaDH], [PhiVanChuyen_TX]) VALUES (N'TX6', N'DH74', 6.0000)
INSERT [dbo].[THUNHAP_TAIXE] ([MaTX], [MaDH], [PhiVanChuyen_TX]) VALUES (N'TX7', N'DH81', 6.0000)
INSERT [dbo].[THUNHAP_TAIXE] ([MaTX], [MaDH], [PhiVanChuyen_TX]) VALUES (N'TX7', N'DH92', 6.0000)
GO
ALTER TABLE [dbo].[CHINHANH]  WITH CHECK ADD  CONSTRAINT [FK_4] FOREIGN KEY([MaDT])
REFERENCES [dbo].[DOITAC] ([MaDT])
GO
ALTER TABLE [dbo].[CHINHANH] CHECK CONSTRAINT [FK_4]
GO
ALTER TABLE [dbo].[CT_DONHANG]  WITH CHECK ADD  CONSTRAINT [FK_6] FOREIGN KEY([MaDH])
REFERENCES [dbo].[DONHANG] ([MaDH])
GO
ALTER TABLE [dbo].[CT_DONHANG] CHECK CONSTRAINT [FK_6]
GO
ALTER TABLE [dbo].[CT_DONHANG]  WITH CHECK ADD  CONSTRAINT [FK_7] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[CT_DONHANG] CHECK CONSTRAINT [FK_7]
GO
ALTER TABLE [dbo].[CT_HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_12] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOPDONG] ([MaHD])
GO
ALTER TABLE [dbo].[CT_HOPDONG] CHECK CONSTRAINT [FK_12]
GO
ALTER TABLE [dbo].[CT_HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_13] FOREIGN KEY([MaDT], [MaCNhanh])
REFERENCES [dbo].[CHINHANH] ([MaDT], [MaCN])
GO
ALTER TABLE [dbo].[CT_HOPDONG] CHECK CONSTRAINT [FK_13]
GO
ALTER TABLE [dbo].[DOANHTHU_DT]  WITH CHECK ADD  CONSTRAINT [FK_1] FOREIGN KEY([MaDT])
REFERENCES [dbo].[DOITAC] ([MaDT])
GO
ALTER TABLE [dbo].[DOANHTHU_DT] CHECK CONSTRAINT [FK_1]
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD  CONSTRAINT [FK_8] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[DONHANG] CHECK CONSTRAINT [FK_8]
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD  CONSTRAINT [FK_9] FOREIGN KEY([MaTX])
REFERENCES [dbo].[TAIXE] ([MaTX])
GO
ALTER TABLE [dbo].[DONHANG] CHECK CONSTRAINT [FK_9]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_2] FOREIGN KEY([MaDT])
REFERENCES [dbo].[DOITAC] ([MaDT])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_2]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_3] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_3]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_15] FOREIGN KEY([MaKH])
REFERENCES [dbo].[TAIKHOAN] ([MaND])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_15]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_17] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TAIKHOAN] ([MaND])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_17]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_14] FOREIGN KEY([MaLoaiHang])
REFERENCES [dbo].[LOAIHANG] ([MaLH])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_14]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_5] FOREIGN KEY([MaDT], [MaCN])
REFERENCES [dbo].[CHINHANH] ([MaDT], [MaCN])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_5]
GO
ALTER TABLE [dbo].[TAIXE]  WITH CHECK ADD  CONSTRAINT [FK_16] FOREIGN KEY([MaTX])
REFERENCES [dbo].[TAIKHOAN] ([MaND])
GO
ALTER TABLE [dbo].[TAIXE] CHECK CONSTRAINT [FK_16]
GO
ALTER TABLE [dbo].[THUNHAP_TAIXE]  WITH CHECK ADD  CONSTRAINT [FK_10] FOREIGN KEY([MaTX])
REFERENCES [dbo].[TAIXE] ([MaTX])
GO
ALTER TABLE [dbo].[THUNHAP_TAIXE] CHECK CONSTRAINT [FK_10]
GO
ALTER TABLE [dbo].[THUNHAP_TAIXE]  WITH CHECK ADD  CONSTRAINT [FK_11] FOREIGN KEY([MaDH])
REFERENCES [dbo].[DONHANG] ([MaDH])
GO
ALTER TABLE [dbo].[THUNHAP_TAIXE] CHECK CONSTRAINT [FK_11]
GO

select*from ct_donhang
select*from donhang


insert into donhang(madh, makh, matx, tinhtrangdh, hinhthucthanhtoan,diachigiao, phivc, tongtien, thoigiandathang)
values ('dh1', 'kh1', null, N'Đang chuẩn bị hàng',N'Thanh toán trước', N'14, Nguyễn Huệ, Phường 2, Quận 1, TPHCM',30,null,'2021-1-12')

insert into ct_donhang(madh,masp,soluong,giatien,thanhtien) values ('dh1','sp19',400,1,400),
('dh1','sp20',900,1,900)



exec  USP_GetInfoDriver 'TX1'
exec USP_GetAllOrderByAreaOfDriver 'TX1'

select*from donhang
select*from taixe

create function fuArea (@matx nvarchar(100))
returns nvarchar(100)
as
begin
	declare @area nvarchar(100)
	set @area = (select khuvuchoatdong from taixe where matx=@matx)
	return @area
end

declare @kq nvarchar(100)


exec USP_GetArea 'TX3'
declare @kq int
exec USP_ShowOrderByArea 'TX3'
	print('loi he thong')
else
	print('thanh cong')

declare @matx nvarchar(100)
set @matx='TX3'
declare @diachi nvarchar(100)
set @diachi=N'Quận 4'
declare @tinhtrang nvarchar(100)
set @tinhtrang=N'Đang giao'

select *
from donhang d
where d.tinhtrangdh=@tinhtrang  and d.matx=@matx and d.diachigiao like '%' + @diachi + '%'

SELECT*FROM DONHANG
SELECT*FROM CT_DONHANG

select*from Taikhoan
select*from taikhoan

INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH1', N'KH7', NULL, N'Đang chuẩn bị hàng', N'Thanh toán trước', N'342, Võ Văn Ngân, Phường 12, Quận 2, TPHCM', 30.0000, 8241.0000, CAST(N'2019-07-10T02:36:12.460' AS DateTime))

INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH1', N'SP5', 1, 611.0000, 611.0000)
INSERT [dbo].[CT_DONHANG] ([MaDH], [MaSP], [SoLuong], [GiaTien], [ThanhTien]) VALUES (N'DH1', N'SP8', 4, 1900.0000, 7600.0000)
alter proc usp_show @matx nvarchar(100)
as
	select*from donhang where matx=@matx
go

exec usp_show 'TX3'
delete donhang where madh='dh1'
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH100', N'KH7', NULL, N'Đang chuẩn bị hàng', N'Thanh toán trước', N'342, Võ Văn Ngân, Phường 12, Quận 2, TPHCM', 30.0000, 8241.0000, CAST(N'2019-07-10T02:36:12.460' AS DateTime))
select*from taixe
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH1000', N'KH7', NULL, N'Đang chuẩn bị hàng', N'Thanh toán trước', N'342 , Võ Văn Ngân , Phường 12 , Quận 2 , TPHCM', 30.0000, 8241.0000, CAST(N'2018-04-10T02:36:12.460' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH699', N'KH3', NULL, N'Đã đóng gói hàng', N'Thanh toán trước', N'4, Võ Thị Sáu, Phường 5, Quận 4, TPHCM', 30.0000, 25640.0000, CAST(N'2021-11-07T20:05:25.500' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH777', N'KH5', NULL, N'Đã đóng gói hàng', N'Thanh toán sau', N'34, Tô Hiến Thành, Phường 3, Quận 10, TPHCM', 30.0000, 6130.0000, CAST(N'2019-01-02T12:58:14.630' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH922', N'KH7', NULL, N'Đã đóng gói hàng', N'Thanh toán sau', N'342, Võ Văn Ngân, Phường 12, Quận 2, TPHCM', 30.0000, 8241.0000, CAST(N'2021-07-10T02:36:12.460' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH222', N'KH7', 'TX1', N'Tài xế đã nhận hàng', N'Thanh toán sau', N'342, Võ Văn Ngân, Phường 12, Quận 2, TPHCM', 30.0000, 8241.0000, CAST(N'2021-12-10T02:36:12.460' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH111', N'KH7', 'TX1', N'Đang giao', N'Thanh toán sau', N'342, Võ Văn Ngân, Phường 12, Quận 2, TPHCM', 30.0000, 8241.0000, CAST(N'2020-11-01T02:36:12.460' AS DateTime))
INSERT [dbo].[DONHANG] ([MaDH], [MaKH], [MaTX], [TinhTrangDH], [HinhThucThanhToan], [DiaChiGiao], [PhiVC], [TongTien], [ThoiGianDatHang]) VALUES (N'DH2212', N'KH7', 'TX1', N'Tài xế đã nhận hàng', N'Thanh toán sau', N'342, Võ Văn Ngân, Phường 12, Quận 2, TPHCM', 30.0000, 8241.0000, CAST(N'2021-12-15T02:36:12.460' AS DateTime))

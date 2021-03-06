USE [QLNT]
GO
/****** Object:  Table [dbo].[BenhNhanh]    Script Date: 03/05/2019 7:23:05 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BenhNhanh](
	[MaBenhNhan] [varchar](50) NOT NULL,
	[TenBenhNhanh] [nvarchar](150) NULL,
	[Tuoi] [int] NULL,
	[GioiTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_BenhNhanh] PRIMARY KEY CLUSTERED 
(
	[MaBenhNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietToaThuoc]    Script Date: 03/05/2019 7:23:05 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietToaThuoc](
	[MaThuoc] [varchar](10) NOT NULL,
	[STT] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[LieuDung] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 03/05/2019 7:23:05 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [varchar](10) NOT NULL,
	[TenThuoc] [nvarchar](150) NULL,
	[NuocSX] [nvarchar](150) NULL,
	[DonGia] [float] NULL,
	[HanSuDung] [nvarchar](150) NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_TiemThuoc] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ToaThuoc]    Script Date: 03/05/2019 7:23:05 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ToaThuoc](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[BenhDuocChungDoan] [nvarchar](150) NULL,
	[NgayKham] [date] NULL,
	[MaBenhNhan] [varchar](50) NULL,
 CONSTRAINT [PK_ToaThuoc] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user]    Script Date: 03/05/2019 7:23:05 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[Tentaikhoan] [nchar](10) NOT NULL,
	[Matkhau] [nchar](10) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[Tentaikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ChiTietToaThuoc]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietToaThuoc_Thuoc] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[ChiTietToaThuoc] CHECK CONSTRAINT [FK_ChiTietToaThuoc_Thuoc]
GO
ALTER TABLE [dbo].[ChiTietToaThuoc]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietToaThuoc_ToaThuoc] FOREIGN KEY([STT])
REFERENCES [dbo].[ToaThuoc] ([STT])
GO
ALTER TABLE [dbo].[ChiTietToaThuoc] CHECK CONSTRAINT [FK_ChiTietToaThuoc_ToaThuoc]
GO
ALTER TABLE [dbo].[ToaThuoc]  WITH CHECK ADD  CONSTRAINT [FK_ToaThuoc_BenhNhanh] FOREIGN KEY([MaBenhNhan])
REFERENCES [dbo].[BenhNhanh] ([MaBenhNhan])
GO
ALTER TABLE [dbo].[ToaThuoc] CHECK CONSTRAINT [FK_ToaThuoc_BenhNhanh]
GO

USE [QLTV]
GO
/****** Object:  Table [dbo].[Bangcap]    Script Date: 03/03/2019 12:24:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bangcap](
	[Mabangcap] [int] IDENTITY(1,1) NOT NULL,
	[Tenbangcap] [nvarchar](40) NULL,
 CONSTRAINT [PK_mabangcap] PRIMARY KEY CLUSTERED 
(
	[Mabangcap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Chitietphieumuon]    Script Date: 03/03/2019 12:24:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitietphieumuon](
	[Masach] [int] NOT NULL,
	[Maphieumuon] [int] NOT NULL,
 CONSTRAINT [PK_chitieyphieumuon] PRIMARY KEY CLUSTERED 
(
	[Masach] ASC,
	[Maphieumuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Docgia]    Script Date: 03/03/2019 12:24:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docgia](
	[Madocgia] [int] IDENTITY(1,1) NOT NULL,
	[Hotendocgia] [nvarchar](40) NULL,
	[Ngaysinh] [datetime] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Ngaylapthe] [datetime] NULL,
	[Ngayhethan] [datetime] NULL,
	[Tienno] [float] NULL,
 CONSTRAINT [PK_madocgia] PRIMARY KEY CLUSTERED 
(
	[Madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 03/03/2019 12:24:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[Manhanvien] [int] IDENTITY(1,1) NOT NULL,
	[Hotennhanvien] [nvarchar](40) NULL,
	[Ngaysinh] [datetime] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Dienthoai] [nvarchar](15) NULL,
	[Mabangcap] [int] NULL,
 CONSTRAINT [PK_manhanvien] PRIMARY KEY CLUSTERED 
(
	[Manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phieumuonsach]    Script Date: 03/03/2019 12:24:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieumuonsach](
	[Maphieumuonsach] [int] IDENTITY(1,1) NOT NULL,
	[Ngaymuon] [datetime] NOT NULL,
	[Madocgia] [int] NULL,
 CONSTRAINT [PK_phieumuonsach] PRIMARY KEY CLUSTERED 
(
	[Maphieumuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phieuthutien]    Script Date: 03/03/2019 12:24:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieuthutien](
	[Maphieuthutien] [int] IDENTITY(1,1) NOT NULL,
	[Sotienno] [float] NULL,
	[Sotienthu] [float] NULL,
	[Madocgia] [int] NULL,
	[Manhanvien] [int] NULL,
 CONSTRAINT [PK_maphieuthutien] PRIMARY KEY CLUSTERED 
(
	[Maphieuthutien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sach]    Script Date: 03/03/2019 12:24:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[Masach] [int] IDENTITY(1,1) NOT NULL,
	[Tensach] [nvarchar](40) NULL,
	[Tacgia] [nvarchar](30) NULL,
	[Namxuatban] [int] NULL,
	[Nhaxuatban] [nvarchar](40) NULL,
	[Trigia] [float] NULL,
	[Ngaynhap] [datetime] NULL,
 CONSTRAINT [PK_masach] PRIMARY KEY CLUSTERED 
(
	[Masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thamso]    Script Date: 03/03/2019 12:24:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thamso](
	[Tenthamso] [nvarchar](40) NOT NULL,
	[Giatri] [int] NULL,
 CONSTRAINT [PK_tenthamso] PRIMARY KEY CLUSTERED 
(
	[Tenthamso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Chitietphieumuon]  WITH CHECK ADD  CONSTRAINT [FK_Chitietphieumuon_Phieumuonsach] FOREIGN KEY([Maphieumuon])
REFERENCES [dbo].[Phieumuonsach] ([Maphieumuonsach])
GO
ALTER TABLE [dbo].[Chitietphieumuon] CHECK CONSTRAINT [FK_Chitietphieumuon_Phieumuonsach]
GO
ALTER TABLE [dbo].[Chitietphieumuon]  WITH CHECK ADD  CONSTRAINT [FK_Chitietphieumuon_Sach] FOREIGN KEY([Masach])
REFERENCES [dbo].[Sach] ([Masach])
GO
ALTER TABLE [dbo].[Chitietphieumuon] CHECK CONSTRAINT [FK_Chitietphieumuon_Sach]
GO
ALTER TABLE [dbo].[Nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_Nhanvien_Bangcap] FOREIGN KEY([Mabangcap])
REFERENCES [dbo].[Bangcap] ([Mabangcap])
GO
ALTER TABLE [dbo].[Nhanvien] CHECK CONSTRAINT [FK_Nhanvien_Bangcap]
GO
ALTER TABLE [dbo].[Phieumuonsach]  WITH CHECK ADD  CONSTRAINT [FK_Phieumuonsach_Docgia] FOREIGN KEY([Madocgia])
REFERENCES [dbo].[Docgia] ([Madocgia])
GO
ALTER TABLE [dbo].[Phieumuonsach] CHECK CONSTRAINT [FK_Phieumuonsach_Docgia]
GO
ALTER TABLE [dbo].[Phieuthutien]  WITH CHECK ADD  CONSTRAINT [FK_Phieuthutien_Docgia] FOREIGN KEY([Madocgia])
REFERENCES [dbo].[Docgia] ([Madocgia])
GO
ALTER TABLE [dbo].[Phieuthutien] CHECK CONSTRAINT [FK_Phieuthutien_Docgia]
GO
ALTER TABLE [dbo].[Phieuthutien]  WITH CHECK ADD  CONSTRAINT [FK_Phieuthutien_Nhanvien] FOREIGN KEY([Manhanvien])
REFERENCES [dbo].[Nhanvien] ([Manhanvien])
GO
ALTER TABLE [dbo].[Phieuthutien] CHECK CONSTRAINT [FK_Phieuthutien_Nhanvien]
GO

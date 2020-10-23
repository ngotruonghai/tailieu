USE [nhanvien]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 03/03/2019 1:35:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[Mã NV] [int] NULL,
	[Họ Tên] [nvarchar](50) NULL,
	[Ngày Sinh] [datetime] NULL,
	[Địa Chỉ] [nvarchar](50) NULL,
	[Bằng Cấp] [nvarchar](50) NULL
) ON [PRIMARY]

GO

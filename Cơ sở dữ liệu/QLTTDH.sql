USE [QL_TT]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[UniqueID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [int] NULL,
	[StartDate] [smalldatetime] NULL,
	[EndDate] [smalldatetime] NULL,
	[AllDay] [bit] NULL,
	[Subject] [nvarchar](50) NULL,
	[Location] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[Status] [int] NULL,
	[Label] [int] NULL,
	[ResourceID] [int] NULL,
	[ResourceIDs] [nvarchar](max) NULL,
	[ReminderInfo] [nvarchar](max) NULL,
	[RecurrenceInfo] [nvarchar](max) NULL,
	[CustomField1] [nvarchar](max) NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[UniqueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BIENLAI]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BIENLAI](
	[MaBienLai] [int] IDENTITY(1,1) NOT NULL,
	[NgayDong] [date] NULL,
	[SoTien] [float] NULL,
	[Thang] [int] NULL,
	[MaNV] [int] NULL,
	[MaHV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBienLai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BUOIHOC]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BUOIHOC](
	[MaBuoi] [int] IDENTITY(1,1) NOT NULL,
	[TenBuoi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBuoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CAHOC]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAHOC](
	[MaCH] [int] IDENTITY(1,1) NOT NULL,
	[GioBD] [time](7) NULL,
	[GioKT] [time](7) NULL,
	[Thu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHAMCONG]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHAMCONG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayChamCong] [date] NULL,
	[CoPhep] [int] NULL,
	[MaPC] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTPHIEUDK]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPHIEUDK](
	[MaPhieuDK] [int] NOT NULL,
	[MaLop] [int] NOT NULL,
 CONSTRAINT [PK_CTPDK] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDK] ASC,
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DIEMDANH]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEMDANH](
	[NgayDiemDanh] [date] NOT NULL,
	[CoPhep] [int] NULL,
	[MaHV] [int] NOT NULL,
	[MaLop] [int] NOT NULL,
 CONSTRAINT [PK_DD] PRIMARY KEY CLUSTERED 
(
	[NgayDiemDanh] ASC,
	[MaLop] ASC,
	[MaHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MaGV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[HeSL] [float] NULL,
	[LuongCB] [float] NULL,
	[MaMH] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOCVIEN]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOCVIEN](
	[MaHV] [int] IDENTITY(1,1) NOT NULL,
	[TenHV] [nvarchar](max) NULL,
	[GioiTinh] [nchar](5) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [nvarchar](50) NULL,
	[DiemDauVao] [float] NULL,
 CONSTRAINT [PK__HOCVIEN__2725A6D2A1417943] PRIMARY KEY CLUSTERED 
(
	[MaHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHOI]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOI](
	[MaKhoi] [int] IDENTITY(1,1) NOT NULL,
	[TenKhoi] [nvarchar](50) NULL,
	[HocPhi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOP]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MaLop] [int] IDENTITY(1,1) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[SiSo] [int] NULL,
	[MaKhoi] [int] NULL,
	[MaMH] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MaMH] [int] IDENTITY(1,1) NOT NULL,
	[TenMH] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[MaTK] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHANCONG]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANCONG](
	[MaPC] [int] IDENTITY(1,1) NOT NULL,
	[MaLop] [int] NULL,
	[MaTKB] [int] NULL,
	[MaGV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUDK]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUDK](
	[MaPhieuDK] [int] IDENTITY(1,1) NOT NULL,
	[TongSoMon] [int] NULL,
	[NgayDK] [date] NULL,
	[MaHV] [int] NULL,
	[MaNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEULUONG]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEULUONG](
	[MaPL] [int] IDENTITY(1,1) NOT NULL,
	[TongTien] [float] NULL,
	[MaGV] [int] NULL,
	[MaNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONGHOC]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGHOC](
	[MaPH] [int] IDENTITY(1,1) NOT NULL,
	[TenPH] [nvarchar](50) NULL,
	[SucChua] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Resources]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resources](
	[UniqueID] [int] IDENTITY(1,1) NOT NULL,
	[ResourceID] [int] NOT NULL,
	[ResourceName] [nvarchar](50) NULL,
	[Color] [int] NULL,
	[Image] [image] NULL,
	[CustomField1] [nvarchar](max) NULL,
 CONSTRAINT [PK_Resources] PRIMARY KEY CLUSTERED 
(
	[UniqueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[TenDN] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Quyen] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THOIKHOABIEU]    Script Date: 03/06/2021 01:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THOIKHOABIEU](
	[MATKB] [int] NOT NULL,
	[MaCH] [int] NULL,
	[MaBuoi] [int] NULL,
	[MaPH] [int] NULL,
 CONSTRAINT [PK_TKB] PRIMARY KEY CLUSTERED 
(
	[MATKB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([UniqueID], [Type], [StartDate], [EndDate], [AllDay], [Subject], [Location], [Description], [Status], [Label], [ResourceID], [ResourceIDs], [ReminderInfo], [RecurrenceInfo], [CustomField1]) VALUES (8, 1, CAST(N'2021-06-02 18:00:00' AS SmallDateTime), CAST(N'2021-06-02 18:00:00' AS SmallDateTime), 0, N'Toán 12 Nâng Cao', N'', N'', 1, 3, 1, NULL, N'', N'<RecurrenceInfo Start="06/02/2021 18:00:00" End="07/07/2021 18:00:00" WeekDays="42" Id="771319cc-aa0e-4ed1-b8a5-59234427e070" OccurrenceCount="16" Range="2" Type="1" />', NULL)
INSERT [dbo].[Appointments] ([UniqueID], [Type], [StartDate], [EndDate], [AllDay], [Subject], [Location], [Description], [Status], [Label], [ResourceID], [ResourceIDs], [ReminderInfo], [RecurrenceInfo], [CustomField1]) VALUES (9, 1, CAST(N'2021-06-03 19:45:00' AS SmallDateTime), CAST(N'2021-06-03 19:45:00' AS SmallDateTime), 0, N'Hoá 12 Cơ Bản', N'', N'', 0, 5, 1, NULL, N'', N'<RecurrenceInfo Start="06/03/2021 19:45:00" End="07/01/2021 19:45:00" WeekDays="84" Id="9e992f22-2d50-443b-9eb2-61f57ac2e774" OccurrenceCount="13" Range="2" Type="1" />', NULL)
SET IDENTITY_INSERT [dbo].[Appointments] OFF
SET IDENTITY_INSERT [dbo].[BIENLAI] ON 

INSERT [dbo].[BIENLAI] ([MaBienLai], [NgayDong], [SoTien], [Thang], [MaNV], [MaHV]) VALUES (1, CAST(N'2021-05-20' AS Date), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[BIENLAI] OFF
SET IDENTITY_INSERT [dbo].[BUOIHOC] ON 

INSERT [dbo].[BUOIHOC] ([MaBuoi], [TenBuoi]) VALUES (1, N'Buổi 1')
INSERT [dbo].[BUOIHOC] ([MaBuoi], [TenBuoi]) VALUES (2, N'Buổi 2')
INSERT [dbo].[BUOIHOC] ([MaBuoi], [TenBuoi]) VALUES (3, N'Buổi 3')
SET IDENTITY_INSERT [dbo].[BUOIHOC] OFF
SET IDENTITY_INSERT [dbo].[CAHOC] ON 

INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (1, CAST(N'09:30:00' AS Time), CAST(N'11:00:00' AS Time), N'Thứ 7')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (2, CAST(N'09:30:00' AS Time), CAST(N'11:00:00' AS Time), N'Chủ Nhật')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (3, CAST(N'15:30:00' AS Time), CAST(N'17:00:00' AS Time), N'Thứ 7')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (4, CAST(N'15:30:00' AS Time), CAST(N'17:00:00' AS Time), N'Chủ Nhật')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (5, CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), N'Thứ 2')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (6, CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), N'Thứ 3')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (7, CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), N'Thứ 4')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (8, CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), N'Thứ 5')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (9, CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), N'Thứ 6')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (10, CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), N'Thứ 7')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (11, CAST(N'18:00:00' AS Time), CAST(N'19:30:00' AS Time), N'Chủ Nhật')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (12, CAST(N'19:45:00' AS Time), CAST(N'21:15:00' AS Time), N'Thứ 2')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (13, CAST(N'19:45:00' AS Time), CAST(N'21:15:00' AS Time), N'Thứ 3')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (14, CAST(N'19:45:00' AS Time), CAST(N'21:15:00' AS Time), N'Thứ 4')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (15, CAST(N'19:45:00' AS Time), CAST(N'21:15:00' AS Time), N'Thứ 5')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (16, CAST(N'19:45:00' AS Time), CAST(N'21:15:00' AS Time), N'Thứ 6')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (17, CAST(N'19:45:00' AS Time), CAST(N'21:15:00' AS Time), N'Thứ 7')
INSERT [dbo].[CAHOC] ([MaCH], [GioBD], [GioKT], [Thu]) VALUES (18, CAST(N'19:45:00' AS Time), CAST(N'21:15:00' AS Time), N'Chủ Nhật')
SET IDENTITY_INSERT [dbo].[CAHOC] OFF
INSERT [dbo].[CTPHIEUDK] ([MaPhieuDK], [MaLop]) VALUES (1, 1)
INSERT [dbo].[CTPHIEUDK] ([MaPhieuDK], [MaLop]) VALUES (1, 3)
INSERT [dbo].[CTPHIEUDK] ([MaPhieuDK], [MaLop]) VALUES (2, 2)
INSERT [dbo].[CTPHIEUDK] ([MaPhieuDK], [MaLop]) VALUES (3, 3)
INSERT [dbo].[CTPHIEUDK] ([MaPhieuDK], [MaLop]) VALUES (4, 5)
INSERT [dbo].[CTPHIEUDK] ([MaPhieuDK], [MaLop]) VALUES (4, 7)
INSERT [dbo].[CTPHIEUDK] ([MaPhieuDK], [MaLop]) VALUES (5, 4)
INSERT [dbo].[CTPHIEUDK] ([MaPhieuDK], [MaLop]) VALUES (5, 13)
INSERT [dbo].[DIEMDANH] ([NgayDiemDanh], [CoPhep], [MaHV], [MaLop]) VALUES (CAST(N'2021-05-21' AS Date), 0, 1, 1)
INSERT [dbo].[DIEMDANH] ([NgayDiemDanh], [CoPhep], [MaHV], [MaLop]) VALUES (CAST(N'2021-05-21' AS Date), 0, 2, 2)
INSERT [dbo].[DIEMDANH] ([NgayDiemDanh], [CoPhep], [MaHV], [MaLop]) VALUES (CAST(N'2021-05-21' AS Date), 0, 3, 3)
INSERT [dbo].[DIEMDANH] ([NgayDiemDanh], [CoPhep], [MaHV], [MaLop]) VALUES (CAST(N'2021-05-21' AS Date), 0, 4, 4)
INSERT [dbo].[DIEMDANH] ([NgayDiemDanh], [CoPhep], [MaHV], [MaLop]) VALUES (CAST(N'2021-05-21' AS Date), 1, 5, 4)
INSERT [dbo].[DIEMDANH] ([NgayDiemDanh], [CoPhep], [MaHV], [MaLop]) VALUES (CAST(N'2021-05-30' AS Date), NULL, 5, 13)
SET IDENTITY_INSERT [dbo].[GIAOVIEN] ON 

INSERT [dbo].[GIAOVIEN] ([MaGV], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [HeSL], [LuongCB], [MaMH]) VALUES (1, N'Lê Hoàng Vũ', N'Nam', CAST(N'1990-02-01' AS Date), N'TP.HCM', N'0978443322', 44, 2500000, 1)
INSERT [dbo].[GIAOVIEN] ([MaGV], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [HeSL], [LuongCB], [MaMH]) VALUES (2, N'Ngô Bá Khá', N'Nam', CAST(N'1993-09-08' AS Date), N'Đồng Nai', N'0987666444', 44, 3000000, 2)
INSERT [dbo].[GIAOVIEN] ([MaGV], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [HeSL], [LuongCB], [MaMH]) VALUES (3, N'Bùi Xuân Huấn', N'Nam', CAST(N'1990-05-05' AS Date), N'Hà Nôi', N'0988213321', 44, 2500000, 3)
INSERT [dbo].[GIAOVIEN] ([MaGV], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [HeSL], [LuongCB], [MaMH]) VALUES (4, N'Nguyễn Văn Dũng', N'Nam', CAST(N'1990-04-02' AS Date), N'TP.HCM', N'0978555444', 44, 2500000, 4)
INSERT [dbo].[GIAOVIEN] ([MaGV], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [HeSL], [LuongCB], [MaMH]) VALUES (5, N'Nguyễn Thị Dung Hà', N'Nữ', CAST(N'1990-05-23' AS Date), N'Hải Phòng', N'0786334555', 44, 2500000, 5)
SET IDENTITY_INSERT [dbo].[GIAOVIEN] OFF
SET IDENTITY_INSERT [dbo].[HOCVIEN] ON 

INSERT [dbo].[HOCVIEN] ([MaHV], [TenHV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemDauVao]) VALUES (1, N'Dương Đình Hải ', N'Nam  ', CAST(N'1996-12-20' AS Date), N'Bình Dương', N'0969696969', 9)
INSERT [dbo].[HOCVIEN] ([MaHV], [TenHV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemDauVao]) VALUES (2, N'Nguyễn Ngọc Hải', N'Nam  ', CAST(N'2000-01-01' AS Date), N'TP.HCM', N'0999999999', 10)
INSERT [dbo].[HOCVIEN] ([MaHV], [TenHV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemDauVao]) VALUES (3, N'Nguyễn Hồng Phúc', N'Nữ   ', CAST(N'2000-12-20' AS Date), N'TP.HCM', N'0123321123', 8)
INSERT [dbo].[HOCVIEN] ([MaHV], [TenHV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemDauVao]) VALUES (4, N'Đặng Hoàng Cẩm My', N'Nữ   ', CAST(N'2000-02-02' AS Date), N'TP.HCM', N'0987654321', 8)
INSERT [dbo].[HOCVIEN] ([MaHV], [TenHV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemDauVao]) VALUES (5, N'Nguyễn Văn Dương', N'Nam  ', CAST(N'2000-05-25' AS Date), N'Quảng Trị', N'0123456789', 8)
INSERT [dbo].[HOCVIEN] ([MaHV], [TenHV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemDauVao]) VALUES (7, N'Aa', N'Nam  ', CAST(N'2021-05-10' AS Date), N'AA', N'1234', 4)
INSERT [dbo].[HOCVIEN] ([MaHV], [TenHV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemDauVao]) VALUES (9, N'aaaa', N'Nữ   ', CAST(N'2021-05-30' AS Date), N'vv', N'123', 5)
INSERT [dbo].[HOCVIEN] ([MaHV], [TenHV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemDauVao]) VALUES (12, N'Bé Nhi', N'Nam  ', CAST(N'2021-05-03' AS Date), N'Ở Nhà nè', N'12314', 10)
INSERT [dbo].[HOCVIEN] ([MaHV], [TenHV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [DiemDauVao]) VALUES (13, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[HOCVIEN] OFF
SET IDENTITY_INSERT [dbo].[KHOI] ON 

INSERT [dbo].[KHOI] ([MaKhoi], [TenKhoi], [HocPhi]) VALUES (1, N'Khối 10', 500000)
INSERT [dbo].[KHOI] ([MaKhoi], [TenKhoi], [HocPhi]) VALUES (2, N'Khối 11', 600000)
INSERT [dbo].[KHOI] ([MaKhoi], [TenKhoi], [HocPhi]) VALUES (3, N'Khối 12 ', 700000)
SET IDENTITY_INSERT [dbo].[KHOI] OFF
SET IDENTITY_INSERT [dbo].[LOP] ON 

INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (1, N'Toán 10', 12, 1, 1)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (2, N'Lý 10', 12, 1, 2)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (3, N'Hoá 10', 12, 1, 3)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (4, N'Anh 10', 12, 1, 8)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (5, N'Toán 11', 12, 2, 1)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (6, N'Hoá 11', 12, 2, 3)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (7, N'Lý 11', 12, 2, 2)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (8, N'Anh 11', 12, 2, 8)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (9, N'Toán 12', 12, 3, 1)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (10, N'Lý 12', 12, 3, 2)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (11, N'Hoá 12', 12, 3, 3)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (12, N'Sinh 12', 12, 3, 4)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (13, N'Anh 12', 12, 3, 8)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [SiSo], [MaKhoi], [MaMH]) VALUES (14, N'Văn 12', 12, 3, 5)
SET IDENTITY_INSERT [dbo].[LOP] OFF
SET IDENTITY_INSERT [dbo].[MONHOC] ON 

INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (1, N'Toán')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (2, N'Lý')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (3, N'Hóa')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (4, N'Sinh')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (5, N'Văn')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (6, N'Sử ')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (7, N'Địa')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (8, N'Anh Văn')
SET IDENTITY_INSERT [dbo].[MONHOC] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT], [ChucVu], [MaTK]) VALUES (1, N'6', N'Bình Phước', N'0989777888', N'Nhân Viên', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT], [ChucVu], [MaTK]) VALUES (2, N'Hồ Thị Vương Trúc', N'Bình Dương', N'0967444333', N'Nhân Viên', 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT], [ChucVu], [MaTK]) VALUES (3, N'Phùng Thị Hương', N'Bình Dương', N'0343213839', N'Nhân Viên', 3)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT], [ChucVu], [MaTK]) VALUES (4, N'Nguyễn Ngọc Trinh', N'Bình Dương', N'0944207809', N'Nhân Viên', 4)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT], [ChucVu], [MaTK]) VALUES (5, N'Nguyễn Thị Kim Ngân', N'Tây Ninh', N'0976444212', N'Nhân Viên', 5)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT], [ChucVu], [MaTK]) VALUES (6, N'Tống Huỳnh Trà My', N'Bình Dương', N'0866123421', N'Nhân Viên', 6)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[PHIEUDK] ON 

INSERT [dbo].[PHIEUDK] ([MaPhieuDK], [TongSoMon], [NgayDK], [MaHV], [MaNV]) VALUES (1, 3, CAST(N'2021-05-20' AS Date), 1, 4)
INSERT [dbo].[PHIEUDK] ([MaPhieuDK], [TongSoMon], [NgayDK], [MaHV], [MaNV]) VALUES (2, 3, CAST(N'2021-05-30' AS Date), 2, 4)
INSERT [dbo].[PHIEUDK] ([MaPhieuDK], [TongSoMon], [NgayDK], [MaHV], [MaNV]) VALUES (3, 3, CAST(N'2021-05-30' AS Date), 3, 2)
INSERT [dbo].[PHIEUDK] ([MaPhieuDK], [TongSoMon], [NgayDK], [MaHV], [MaNV]) VALUES (4, 2, CAST(N'2021-05-20' AS Date), 4, 2)
INSERT [dbo].[PHIEUDK] ([MaPhieuDK], [TongSoMon], [NgayDK], [MaHV], [MaNV]) VALUES (5, 4, CAST(N'2021-05-20' AS Date), 5, 2)
INSERT [dbo].[PHIEUDK] ([MaPhieuDK], [TongSoMon], [NgayDK], [MaHV], [MaNV]) VALUES (6, 2, CAST(N'2021-05-30' AS Date), 3, NULL)
INSERT [dbo].[PHIEUDK] ([MaPhieuDK], [TongSoMon], [NgayDK], [MaHV], [MaNV]) VALUES (16, 2, CAST(N'2021-06-01' AS Date), 2, 3)
INSERT [dbo].[PHIEUDK] ([MaPhieuDK], [TongSoMon], [NgayDK], [MaHV], [MaNV]) VALUES (17, 4, CAST(N'2021-06-30' AS Date), 2, 6)
INSERT [dbo].[PHIEUDK] ([MaPhieuDK], [TongSoMon], [NgayDK], [MaHV], [MaNV]) VALUES (19, 1, CAST(N'2021-07-08' AS Date), 12, 6)
SET IDENTITY_INSERT [dbo].[PHIEUDK] OFF
SET IDENTITY_INSERT [dbo].[PHIEULUONG] ON 

INSERT [dbo].[PHIEULUONG] ([MaPL], [TongTien], [MaGV], [MaNV]) VALUES (1, 1000000, 1, 1)
SET IDENTITY_INSERT [dbo].[PHIEULUONG] OFF
SET IDENTITY_INSERT [dbo].[PHONGHOC] ON 

INSERT [dbo].[PHONGHOC] ([MaPH], [TenPH], [SucChua]) VALUES (1, N'Phòng 1', 12)
INSERT [dbo].[PHONGHOC] ([MaPH], [TenPH], [SucChua]) VALUES (2, N'Phòng 2', 12)
INSERT [dbo].[PHONGHOC] ([MaPH], [TenPH], [SucChua]) VALUES (3, N'Phòng 3', 12)
INSERT [dbo].[PHONGHOC] ([MaPH], [TenPH], [SucChua]) VALUES (4, N'Phòng 4', 12)
INSERT [dbo].[PHONGHOC] ([MaPH], [TenPH], [SucChua]) VALUES (5, N'Phòng 5', 12)
INSERT [dbo].[PHONGHOC] ([MaPH], [TenPH], [SucChua]) VALUES (6, N'Phòng 6', 12)
SET IDENTITY_INSERT [dbo].[PHONGHOC] OFF
SET IDENTITY_INSERT [dbo].[Resources] ON 

INSERT [dbo].[Resources] ([UniqueID], [ResourceID], [ResourceName], [Color], [Image], [CustomField1]) VALUES (1, 1, N'Resource One', NULL, NULL, NULL)
INSERT [dbo].[Resources] ([UniqueID], [ResourceID], [ResourceName], [Color], [Image], [CustomField1]) VALUES (2, 2, N'Resource Two', NULL, NULL, NULL)
INSERT [dbo].[Resources] ([UniqueID], [ResourceID], [ResourceName], [Color], [Image], [CustomField1]) VALUES (3, 3, N'Resource Three', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Resources] OFF
SET IDENTITY_INSERT [dbo].[TAIKHOAN] ON 

INSERT [dbo].[TAIKHOAN] ([MaTK], [TenDN], [MatKhau], [Quyen]) VALUES (1, N'nhinyc', N'123', N'')
INSERT [dbo].[TAIKHOAN] ([MaTK], [TenDN], [MatKhau], [Quyen]) VALUES (2, N'trucnyc', N'123', NULL)
INSERT [dbo].[TAIKHOAN] ([MaTK], [TenDN], [MatKhau], [Quyen]) VALUES (3, N'huongnyc', N'123', NULL)
INSERT [dbo].[TAIKHOAN] ([MaTK], [TenDN], [MatKhau], [Quyen]) VALUES (4, N'trinhnyc', N'123', NULL)
INSERT [dbo].[TAIKHOAN] ([MaTK], [TenDN], [MatKhau], [Quyen]) VALUES (5, N'ngannyc', N'123', NULL)
INSERT [dbo].[TAIKHOAN] ([MaTK], [TenDN], [MatKhau], [Quyen]) VALUES (6, N'mynyc', N'123', NULL)
SET IDENTITY_INSERT [dbo].[TAIKHOAN] OFF
INSERT [dbo].[THOIKHOABIEU] ([MATKB], [MaCH], [MaBuoi], [MaPH]) VALUES (1, 1, 1, 1)
INSERT [dbo].[THOIKHOABIEU] ([MATKB], [MaCH], [MaBuoi], [MaPH]) VALUES (2, 1, 2, 2)
ALTER TABLE [dbo].[BIENLAI]  WITH CHECK ADD  CONSTRAINT [FK_BL_HV] FOREIGN KEY([MaHV])
REFERENCES [dbo].[HOCVIEN] ([MaHV])
GO
ALTER TABLE [dbo].[BIENLAI] CHECK CONSTRAINT [FK_BL_HV]
GO
ALTER TABLE [dbo].[BIENLAI]  WITH CHECK ADD  CONSTRAINT [FK_BL_NV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[BIENLAI] CHECK CONSTRAINT [FK_BL_NV]
GO
ALTER TABLE [dbo].[CHAMCONG]  WITH CHECK ADD  CONSTRAINT [FK_CC_PC] FOREIGN KEY([MaPC])
REFERENCES [dbo].[PHANCONG] ([MaPC])
GO
ALTER TABLE [dbo].[CHAMCONG] CHECK CONSTRAINT [FK_CC_PC]
GO
ALTER TABLE [dbo].[CTPHIEUDK]  WITH CHECK ADD  CONSTRAINT [FK_CTPDK_L] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[CTPHIEUDK] CHECK CONSTRAINT [FK_CTPDK_L]
GO
ALTER TABLE [dbo].[CTPHIEUDK]  WITH CHECK ADD  CONSTRAINT [FK_CTPDK_PDK] FOREIGN KEY([MaPhieuDK])
REFERENCES [dbo].[PHIEUDK] ([MaPhieuDK])
GO
ALTER TABLE [dbo].[CTPHIEUDK] CHECK CONSTRAINT [FK_CTPDK_PDK]
GO
ALTER TABLE [dbo].[DIEMDANH]  WITH CHECK ADD  CONSTRAINT [FK_DD_HV] FOREIGN KEY([MaHV])
REFERENCES [dbo].[HOCVIEN] ([MaHV])
GO
ALTER TABLE [dbo].[DIEMDANH] CHECK CONSTRAINT [FK_DD_HV]
GO
ALTER TABLE [dbo].[DIEMDANH]  WITH CHECK ADD  CONSTRAINT [FK_DD_L] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[DIEMDANH] CHECK CONSTRAINT [FK_DD_L]
GO
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD  CONSTRAINT [FK_GV_MH] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MONHOC] ([MaMH])
GO
ALTER TABLE [dbo].[GIAOVIEN] CHECK CONSTRAINT [FK_GV_MH]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_L_K] FOREIGN KEY([MaKhoi])
REFERENCES [dbo].[KHOI] ([MaKhoi])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_L_K]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_L_MH] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MONHOC] ([MaMH])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_L_MH]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NV_TK] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TAIKHOAN] ([MaTK])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NV_TK]
GO
ALTER TABLE [dbo].[PHANCONG]  WITH CHECK ADD  CONSTRAINT [FK_PC_GV] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[PHANCONG] CHECK CONSTRAINT [FK_PC_GV]
GO
ALTER TABLE [dbo].[PHANCONG]  WITH CHECK ADD  CONSTRAINT [FK_PC_L] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[PHANCONG] CHECK CONSTRAINT [FK_PC_L]
GO
ALTER TABLE [dbo].[PHANCONG]  WITH CHECK ADD  CONSTRAINT [FK_PC_TKB] FOREIGN KEY([MaTKB])
REFERENCES [dbo].[THOIKHOABIEU] ([MATKB])
GO
ALTER TABLE [dbo].[PHANCONG] CHECK CONSTRAINT [FK_PC_TKB]
GO
ALTER TABLE [dbo].[PHIEUDK]  WITH CHECK ADD  CONSTRAINT [FK_PDK_HV] FOREIGN KEY([MaHV])
REFERENCES [dbo].[HOCVIEN] ([MaHV])
GO
ALTER TABLE [dbo].[PHIEUDK] CHECK CONSTRAINT [FK_PDK_HV]
GO
ALTER TABLE [dbo].[PHIEUDK]  WITH CHECK ADD  CONSTRAINT [FK_PDK_NV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUDK] CHECK CONSTRAINT [FK_PDK_NV]
GO
ALTER TABLE [dbo].[PHIEULUONG]  WITH CHECK ADD  CONSTRAINT [FK_PL_GV] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[PHIEULUONG] CHECK CONSTRAINT [FK_PL_GV]
GO
ALTER TABLE [dbo].[PHIEULUONG]  WITH CHECK ADD  CONSTRAINT [FK_PL_NV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEULUONG] CHECK CONSTRAINT [FK_PL_NV]
GO
ALTER TABLE [dbo].[THOIKHOABIEU]  WITH CHECK ADD  CONSTRAINT [FK_TKB_BH] FOREIGN KEY([MaBuoi])
REFERENCES [dbo].[BUOIHOC] ([MaBuoi])
GO
ALTER TABLE [dbo].[THOIKHOABIEU] CHECK CONSTRAINT [FK_TKB_BH]
GO
ALTER TABLE [dbo].[THOIKHOABIEU]  WITH CHECK ADD  CONSTRAINT [FK_TKB_CH] FOREIGN KEY([MaCH])
REFERENCES [dbo].[CAHOC] ([MaCH])
GO
ALTER TABLE [dbo].[THOIKHOABIEU] CHECK CONSTRAINT [FK_TKB_CH]
GO
ALTER TABLE [dbo].[THOIKHOABIEU]  WITH CHECK ADD  CONSTRAINT [FK_TKB_PH] FOREIGN KEY([MaPH])
REFERENCES [dbo].[PHONGHOC] ([MaPH])
GO
ALTER TABLE [dbo].[THOIKHOABIEU] CHECK CONSTRAINT [FK_TKB_PH]
GO

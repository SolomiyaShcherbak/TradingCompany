USE [TradingCompany]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 10/13/2022 7:54:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[RowInsertTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (22, N'Appliances', CAST(N'2022-10-12T12:04:38.280' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (59, N'Apps & Games', CAST(N'2022-10-12T18:10:04.477' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (60, N'Books', CAST(N'2022-10-12T18:10:08.070' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (61, N'CDs & Vinyl', CAST(N'2022-10-12T18:10:16.360' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (62, N'Electronics', CAST(N'2022-10-12T18:10:24.827' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (63, N'Home & Kitchen', CAST(N'2022-10-12T18:10:34.713' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (64, N'Sports & Outdoors', CAST(N'2022-10-12T18:10:40.227' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (132, N'Toys & Games', CAST(N'2022-10-13T15:42:45.107' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (133, N'Video Games', CAST(N'2022-10-13T15:42:50.443' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (134, N'Garden & Outdoor', CAST(N'2022-10-13T15:42:59.647' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (135, N'Industrial & Scientific', CAST(N'2022-10-13T15:43:08.753' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (136, N'Computers', CAST(N'2022-10-13T15:43:20.627' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (137, N'Movies & TV', CAST(N'2022-10-13T15:43:21.797' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (138, N'Musical Instruments', CAST(N'2022-10-13T15:43:28.587' AS DateTime))
INSERT [dbo].[Category] ([CategoryID], [Name], [RowInsertTime]) VALUES (139, N'Clothing, Shoes and Jewelry', CAST(N'2022-10-13T15:43:38.090' AS DateTime))
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_RowInsertTime]  DEFAULT (getutcdate()) FOR [RowInsertTime]
GO

USE [TradingCompany]
GO
/****** Object:  Table [dbo].[PostProduct]    Script Date: 10/13/2022 7:54:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostProduct](
	[PostID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[RowInsertTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PostProduct] PRIMARY KEY CLUSTERED 
(
	[PostID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PostProduct] ([PostID], [ProductID], [RowInsertTime]) VALUES (1, 49, CAST(N'2022-10-13T15:58:26.667' AS DateTime))
INSERT [dbo].[PostProduct] ([PostID], [ProductID], [RowInsertTime]) VALUES (1, 55, CAST(N'2022-10-13T15:56:43.540' AS DateTime))
INSERT [dbo].[PostProduct] ([PostID], [ProductID], [RowInsertTime]) VALUES (2, 50, CAST(N'2022-10-13T15:57:05.400' AS DateTime))
INSERT [dbo].[PostProduct] ([PostID], [ProductID], [RowInsertTime]) VALUES (3, 48, CAST(N'2022-10-13T15:56:52.360' AS DateTime))
INSERT [dbo].[PostProduct] ([PostID], [ProductID], [RowInsertTime]) VALUES (3, 55, CAST(N'2022-10-13T15:57:48.900' AS DateTime))
INSERT [dbo].[PostProduct] ([PostID], [ProductID], [RowInsertTime]) VALUES (4, 51, CAST(N'2022-10-13T15:57:35.600' AS DateTime))
INSERT [dbo].[PostProduct] ([PostID], [ProductID], [RowInsertTime]) VALUES (6, 50, CAST(N'2022-10-13T15:57:11.327' AS DateTime))
INSERT [dbo].[PostProduct] ([PostID], [ProductID], [RowInsertTime]) VALUES (7, 52, CAST(N'2022-10-13T15:57:43.053' AS DateTime))
INSERT [dbo].[PostProduct] ([PostID], [ProductID], [RowInsertTime]) VALUES (8, 49, CAST(N'2022-10-13T15:57:28.740' AS DateTime))
INSERT [dbo].[PostProduct] ([PostID], [ProductID], [RowInsertTime]) VALUES (9, 53, CAST(N'2022-10-13T15:58:16.057' AS DateTime))
INSERT [dbo].[PostProduct] ([PostID], [ProductID], [RowInsertTime]) VALUES (10, 53, CAST(N'2022-10-13T15:57:19.343' AS DateTime))
GO
ALTER TABLE [dbo].[PostProduct] ADD  CONSTRAINT [DF_PostItem_RowInsertTime]  DEFAULT (getutcdate()) FOR [RowInsertTime]
GO
ALTER TABLE [dbo].[PostProduct]  WITH CHECK ADD  CONSTRAINT [FK_PostProduct_Post] FOREIGN KEY([PostID])
REFERENCES [dbo].[Post] ([PostID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PostProduct] CHECK CONSTRAINT [FK_PostProduct_Post]
GO
ALTER TABLE [dbo].[PostProduct]  WITH CHECK ADD  CONSTRAINT [FK_PostProduct_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PostProduct] CHECK CONSTRAINT [FK_PostProduct_Product]
GO

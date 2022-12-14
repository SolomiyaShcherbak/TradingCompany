USE [TradingCompany]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 10/13/2022 7:54:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Price] [money] NOT NULL,
	[RowInsertTime] [datetime] NOT NULL,
	[RowUpdateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [Name], [CategoryID], [Description], [Price], [RowInsertTime], [RowUpdateTime]) VALUES (48, N'Xbox Series S', 59, N'Go all digital with Xbox Series S and experience next-gen speed and performance at a great price. ', 2000.0000, CAST(N'2022-10-13T15:47:04.597' AS DateTime), CAST(N'2022-10-13T15:47:04.597' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [Name], [CategoryID], [Description], [Price], [RowInsertTime], [RowUpdateTime]) VALUES (49, N'Meta Quest 2 — Advanced All-In-One Virtual Reality Headset — 128 GB', 132, N'Experience total immersion with 3D positional audio, hand tracking and haptic feedback, working together to make virtual worlds feel real. ', 2345.0000, CAST(N'2022-10-13T15:48:51.653' AS DateTime), CAST(N'2022-10-13T15:48:51.653' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [Name], [CategoryID], [Description], [Price], [RowInsertTime], [RowUpdateTime]) VALUES (50, N'Apple Barrel Acrylic Paint in Assorted Colors (8 Ounce)', 22, N'Apple Barrel is a non-toxic and water-based formula, great for crafting with all ages. ', 200.0000, CAST(N'2022-10-13T15:50:07.330' AS DateTime), CAST(N'2022-10-13T15:50:07.330' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [Name], [CategoryID], [Description], [Price], [RowInsertTime], [RowUpdateTime]) VALUES (51, N'Apple Lightning to Digital AV Adapter', 62, N'Use the Lightning Digital AV Adapter with your iPhone, iPad, or iPod with Lightning connector.', 500.0000, CAST(N'2022-10-13T15:51:11.457' AS DateTime), CAST(N'2022-10-13T15:51:11.457' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [Name], [CategoryID], [Description], [Price], [RowInsertTime], [RowUpdateTime]) VALUES (52, N'Maxell 190319 Stereo Headphone', 136, N'Connectivity Technology: Wired', 99.0000, CAST(N'2022-10-13T15:52:29.720' AS DateTime), CAST(N'2022-10-13T15:52:29.720' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [Name], [CategoryID], [Description], [Price], [RowInsertTime], [RowUpdateTime]) VALUES (53, N'Razer DeathAdder Essential Gaming Mouse', 136, N'High-Precision 6,400 DPI Optical Sensor', 500.0000, CAST(N'2022-10-13T15:53:15.403' AS DateTime), CAST(N'2022-10-13T15:53:15.403' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [Name], [CategoryID], [Description], [Price], [RowInsertTime], [RowUpdateTime]) VALUES (54, N'Perler Beads Bead Tweezer Tools', 64, N'Perler bead tweezers measure 4.25'''' each.', 10.0000, CAST(N'2022-10-13T15:54:42.063' AS DateTime), CAST(N'2022-10-13T15:54:42.063' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [Name], [CategoryID], [Description], [Price], [RowInsertTime], [RowUpdateTime]) VALUES (55, N'Dremel 120-Volt Engraver Rotary Tool', 22, N'Kit includes one 9924 carbide point and letter/number stencil template ideal for decorative engraving and personalization', 55.0000, CAST(N'2022-10-13T15:55:38.607' AS DateTime), CAST(N'2022-10-13T15:55:38.607' AS DateTime))
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Item_RowInsertTime]  DEFAULT (getutcdate()) FOR [RowInsertTime]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Item_RowUpdateTime]  DEFAULT (getutcdate()) FOR [RowUpdateTime]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO

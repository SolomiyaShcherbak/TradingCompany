USE [TradingCompany]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 10/13/2022 7:54:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[PostID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](300) NOT NULL,
	[Content] [nvarchar](1000) NOT NULL,
	[RowInsertTime] [datetime] NOT NULL,
	[RowUpdateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[PostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Post] ON 

INSERT [dbo].[Post] ([PostID], [Title], [Content], [RowInsertTime], [RowUpdateTime]) VALUES (1, N'Truck hurtles into sea after both sets of brakes fail', N'Luckily, no one is injured in this extraordinary occurence, which could have been fatal, both for the driver and anyone else in the vicinity.', CAST(N'2022-10-09T08:55:03.077' AS DateTime), CAST(N'2022-10-09T08:55:03.077' AS DateTime))
INSERT [dbo].[Post] ([PostID], [Title], [Content], [RowInsertTime], [RowUpdateTime]) VALUES (2, N'Italian police find cocaine in wheelchair of airline passenger pretending to be disabled', N'After a drug detection dog flagged the drugs to officers at an airport in Milan, the wheelchair user got up and started walking unaided. Police said they found the drugs stuffed into the wheelchair''s upholstery.', CAST(N'2022-10-09T08:55:12.577' AS DateTime), CAST(N'2022-10-09T08:55:12.577' AS DateTime))
INSERT [dbo].[Post] ([PostID], [Title], [Content], [RowInsertTime], [RowUpdateTime]) VALUES (3, N'Police find cocaine worth £1.2m hidden in wheelchair at Milan airport', N'After the sniffer dog flagged the drugs to officers, the wheelchair user got up and started walking unaided. Police said they found the drugs stuffed into the wheelchair''s upholstery.', CAST(N'2022-10-09T08:55:19.307' AS DateTime), CAST(N'2022-10-09T08:55:19.307' AS DateTime))
INSERT [dbo].[Post] ([PostID], [Title], [Content], [RowInsertTime], [RowUpdateTime]) VALUES (4, N'''Meteor'' seen in US as boom heard', N'A meteor is thought to have crashed into the atmosphere causing a loud boom sound in parts of Utah and Idaho. Local residents have been sharing videos of what they heard.', CAST(N'2022-10-09T08:55:28.043' AS DateTime), CAST(N'2022-10-09T08:55:28.043' AS DateTime))
INSERT [dbo].[Post] ([PostID], [Title], [Content], [RowInsertTime], [RowUpdateTime]) VALUES (6, N'Art work stolen from elderly widow ''in bizarre soothsayer plot'' found by police in Brazil', N'A video showed the moment officers recovered the stolen paintings, with one exclaiming: "Oh, little beauty. Glory". ', CAST(N'2022-10-13T08:19:29.380' AS DateTime), CAST(N'2022-10-13T08:19:29.380' AS DateTime))
INSERT [dbo].[Post] ([PostID], [Title], [Content], [RowInsertTime], [RowUpdateTime]) VALUES (7, N'Lidl told to destroy gold chocolate bunnies after it loses copyright case with Lindt', N'The chocolate bunny row went to Switzerland''s highest court, who sided with Lindt, and the German supermarket may now melt down its entire stock.', CAST(N'2022-10-13T15:39:08.340' AS DateTime), CAST(N'2022-10-13T15:39:08.340' AS DateTime))
INSERT [dbo].[Post] ([PostID], [Title], [Content], [RowInsertTime], [RowUpdateTime]) VALUES (8, N'Worth first plaice? Cheating scandal rocks competitive fishing world after weights found in Ohio catches', N'The world of competitive fishing is reeling over the scandal after footage of the moment the lead balls were found inside the walleye fish went viral online. ', CAST(N'2022-10-13T15:39:30.307' AS DateTime), CAST(N'2022-10-13T15:39:30.307' AS DateTime))
INSERT [dbo].[Post] ([PostID], [Title], [Content], [RowInsertTime], [RowUpdateTime]) VALUES (9, N'NASA''s James Webb Space Telescope takes image of dust ''fingerprint'' created by two stars', N'Each of the 17 dust rings was created when the two stars came close together and the streams of gas they blow into space collided, compressing the gas and forming dust.', CAST(N'2022-10-13T15:40:12.473' AS DateTime), CAST(N'2022-10-13T15:40:12.473' AS DateTime))
INSERT [dbo].[Post] ([PostID], [Title], [Content], [RowInsertTime], [RowUpdateTime]) VALUES (10, N'Jumbo jet to launch UK''s first rocket into space', N'The LauncherOne rocket will be released at an altitude of 35,000ft over the Atlantic Ocean. It will then accelerate to 8,000mph before deploying seven satellites into orbit.', CAST(N'2022-10-13T15:40:33.187' AS DateTime), CAST(N'2022-10-13T15:40:33.187' AS DateTime))
SET IDENTITY_INSERT [dbo].[Post] OFF
GO
ALTER TABLE [dbo].[Post] ADD  CONSTRAINT [DF_Post_RowInsertTime]  DEFAULT (getutcdate()) FOR [RowInsertTime]
GO
ALTER TABLE [dbo].[Post] ADD  CONSTRAINT [DF_Post_RowUpdateTime]  DEFAULT (getutcdate()) FOR [RowUpdateTime]
GO

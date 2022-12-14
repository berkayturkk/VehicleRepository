USE [VehicleRepository]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 26.08.2022 15:35:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Boats]    Script Date: 26.08.2022 15:35:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boats](
	[BoatID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Type] [nvarchar](max) NULL,
	[Brand] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[ColorID] [int] NOT NULL,
	[OnHeadlights] [bit] NOT NULL,
 CONSTRAINT [PK_Boats] PRIMARY KEY CLUSTERED 
(
	[BoatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Buses]    Script Date: 26.08.2022 15:35:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buses](
	[BusID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Type] [nvarchar](max) NULL,
	[Brand] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[ColorID] [int] NOT NULL,
	[OnHeadlights] [bit] NOT NULL,
 CONSTRAINT [PK_Buses] PRIMARY KEY CLUSTERED 
(
	[BusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 26.08.2022 15:35:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Type] [nvarchar](max) NULL,
	[Brand] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[ColorID] [int] NOT NULL,
	[OnHeadlights] [bit] NOT NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 26.08.2022 15:35:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[ColorID] [int] IDENTITY(1,1) NOT NULL,
	[ColorName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[ColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 26.08.2022 15:35:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220826075351_mig_add_all_tables', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[Boats] ON 

INSERT [dbo].[Boats] ([BoatID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (2, 1, N'Boat', N'Barbaros', N'M25', 2, 0)
INSERT [dbo].[Boats] ([BoatID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (3, 2, N'Boat', N'Beneteau', N'Oceanis', 3, 0)
INSERT [dbo].[Boats] ([BoatID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (4, 2, N'Boat', N'Contest', N'62CS', 4, 0)
INSERT [dbo].[Boats] ([BoatID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (5, 3, N'Boat', N'Elan', N'Impression', 1, 0)
INSERT [dbo].[Boats] ([BoatID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (6, 3, N'Boat', N'Apache', N'Mercury', 2, 0)
INSERT [dbo].[Boats] ([BoatID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (7, 4, N'Boat', N'Azzurro', N'ZR9', 3, 0)
INSERT [dbo].[Boats] ([BoatID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (8, 4, N'Boat', N'Galia', N'770 Sundeck', 4, 0)
SET IDENTITY_INSERT [dbo].[Boats] OFF
GO
SET IDENTITY_INSERT [dbo].[Buses] ON 

INSERT [dbo].[Buses] ([BusID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (2, 1, N'Bus', N'Iveco', N'M27', 2, 0)
INSERT [dbo].[Buses] ([BusID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (3, 2, N'Bus', N'Karsan', N'Atak', 3, 0)
INSERT [dbo].[Buses] ([BusID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (4, 2, N'Bus', N'MAN', N'Lions', 1, 0)
INSERT [dbo].[Buses] ([BusID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (5, 3, N'Bus', N'Mercedes', N'Travego', 4, 0)
INSERT [dbo].[Buses] ([BusID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (6, 3, N'Bus', N'Neoplan', N'Tourliner', 2, 0)
INSERT [dbo].[Buses] ([BusID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (7, 4, N'Bus', N'Otokar', N'Doruk', 3, 0)
INSERT [dbo].[Buses] ([BusID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (8, 4, N'Bus', N'Temsa', N'Diamond', 1, 0)
SET IDENTITY_INSERT [dbo].[Buses] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([CarID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (1, 2, N'Car', N'Audi', N'A8', 3, 0)
INSERT [dbo].[Cars] ([CarID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (2, 2, N'Car', N'Bentley', N'Arrage', 1, 0)
INSERT [dbo].[Cars] ([CarID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (4, 1, N'Car', N'BMW', N'Z8', 2, 0)
INSERT [dbo].[Cars] ([CarID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (5, 3, N'Car', N'Hondo', N'Integra', 2, 0)
INSERT [dbo].[Cars] ([CarID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (6, 3, N'Car', N'Ferrari', N'Roma', 4, 0)
INSERT [dbo].[Cars] ([CarID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (7, 4, N'Car', N'Hyundai', N'Elantra', 3, 0)
INSERT [dbo].[Cars] ([CarID], [UserID], [Type], [Brand], [Model], [ColorID], [OnHeadlights]) VALUES (8, 4, N'Car', N'Lamborghini', N'Gallardo', 4, 0)
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Colors] ON 

INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (1, N'Kırmızı')
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (2, N'Mavi')
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (3, N'Siyah')
INSERT [dbo].[Colors] ([ColorID], [ColorName]) VALUES (4, N'Beyaz')
SET IDENTITY_INSERT [dbo].[Colors] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [UserName]) VALUES (1, N'Berkay TURK')
INSERT [dbo].[Users] ([UserID], [UserName]) VALUES (2, N'Osman BAS')
INSERT [dbo].[Users] ([UserID], [UserName]) VALUES (3, N'Furkan TASCI')
INSERT [dbo].[Users] ([UserID], [UserName]) VALUES (4, N'Mehmet Ali OKUDAN')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Boats]  WITH CHECK ADD  CONSTRAINT [FK_Boats_Colors_ColorID] FOREIGN KEY([ColorID])
REFERENCES [dbo].[Colors] ([ColorID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Boats] CHECK CONSTRAINT [FK_Boats_Colors_ColorID]
GO
ALTER TABLE [dbo].[Boats]  WITH CHECK ADD  CONSTRAINT [FK_Boats_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Boats] CHECK CONSTRAINT [FK_Boats_Users_UserID]
GO
ALTER TABLE [dbo].[Buses]  WITH CHECK ADD  CONSTRAINT [FK_Buses_Colors_ColorID] FOREIGN KEY([ColorID])
REFERENCES [dbo].[Colors] ([ColorID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Buses] CHECK CONSTRAINT [FK_Buses_Colors_ColorID]
GO
ALTER TABLE [dbo].[Buses]  WITH CHECK ADD  CONSTRAINT [FK_Buses_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Buses] CHECK CONSTRAINT [FK_Buses_Users_UserID]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Colors_ColorID] FOREIGN KEY([ColorID])
REFERENCES [dbo].[Colors] ([ColorID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Colors_ColorID]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Users_UserID]
GO

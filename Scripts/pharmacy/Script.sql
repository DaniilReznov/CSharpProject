USE [dbPharmacy]
GO
/****** Object:  Table [dbo].[dbAuth]    Script Date: 06.02.2023 21:27:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbAuth](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dbAuth] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dbStock1]    Script Date: 06.02.2023 21:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbStock1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ATX] [nvarchar](max) NOT NULL,
	[Dec] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [nvarchar](max) NOT NULL,
	[Quantity] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbStock1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dbStock2]    Script Date: 06.02.2023 21:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbStock2](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ATX] [nvarchar](max) NOT NULL,
	[Dec] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [nvarchar](max) NOT NULL,
	[Quantity] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbStock2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[dbAuth] ON 

INSERT [dbo].[dbAuth] ([id], [login], [password]) VALUES (1, N'admin', N'12345')
INSERT [dbo].[dbAuth] ([id], [login], [password]) VALUES (2, N'user', N'qwerty')
SET IDENTITY_INSERT [dbo].[dbAuth] OFF
GO
SET IDENTITY_INSERT [dbo].[dbStock1] ON 

INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (1, N'A02BA', N'блокаторы Н2-гистаминовых рецепторов', N'ранитидин', N'33', N'1364')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (2, N'A02BA', N'блокаторы Н2-гистаминовых рецепторов', N'фамотидин', N'27.99', N'564')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (3, N'A02BC', N'ингибиторы протонного насоса', N'омепразол', N'55,32', N'1610')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (4, N'A02BC', N'ингибиторы протонного насоса', N'эзомепразол', N'142', N'758')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (5, N'A03AA', N'синтетические антихолинергические средства, эфиры с третичной аминогруппой', N'мебеверин', N'294', N'838')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (6, N'A03AA', N'синтетические антихолинергические средства, эфиры с третичной аминогруппой', N'платифиллин', N'66', N'1227')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (7, N'A03AD', N'папаверин и его производные', N'дротаверин', N'87', N'1712')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (8, N'A03BA', N'алкалоиды белладонны, третичные амины', N'атропин', N'56', N'415')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (9, N'A03FA', N'стимуляторы моторики желудочнокишечного тракта', N'метоклопрамид', N'73', N'339')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (10, N'A04AA', N'блокаторы серотониновых  5HT3-рецепторов', N'ондансетрон', N'233', N'1935')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (11, N'A06AB', N'контактные слабительные средства', N'бисакодил', N'20', N'749')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (12, N'A06AD', N'осмотические слабительные средства', N'макрогол', N'230', N'731')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (13, N'A07DA', N'препараты, снижающие моторику желудочнокишечного тракта', N'лоперамид', N'28', N'1905')
INSERT [dbo].[dbStock1] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (14, N'A07EC', N'аминосалициловая кислота и аналогичные препараты', N'месалазин', N'610', N'1483')
SET IDENTITY_INSERT [dbo].[dbStock1] OFF
GO
SET IDENTITY_INSERT [dbo].[dbStock2] ON 

INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (1, N'A07EC', N'аминосалициловая кислота и аналогичные препараты', N'сульфасалазин', N'535', N'1663')
INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (2, N'A09AA', N'ферментные препараты', N'панкреатин', N'133', N'183')
INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (3, N'A10AB', N'инсулины короткого действия', N'инсулин аспарт', N'1661', N'413')
INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (4, N'A10AB', N'инсулины короткого действия', N'инсулин глулизин', N'1979', N'1876')
INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (5, N'A10AB', N'инсулины короткого действия', N'инсулин лизпро', N'1426', N'288')
INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (6, N'A10AC', N'инсулины средней продолжительности действия и их аналоги для инъекционного введения', N'инсулин-изофан', N'284', N'1496')
INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (7, N'A10BA', N'бигуаниды', N'метформин', N'156', N'1809')
INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (8, N'A10BB', N'производные сульфонилмочевины', N'глибенкламид', N'120', N'143')
INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (9, N'A10BH', N'ингибиторы дипептидилпептидазы-4 (ДПП-4)', N'алоглиптин', N'796', N'355')
INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (10, N'A10BH', N'ингибиторы дипептидилпептидазы-4 (ДПП-4)', N'вилдаглиптин', N'1365', N'1208')
INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (11, N'A10BH', N'ингибиторы дипептидилпептидазы-4 (ДПП-4)', N'линаглиптин', N'1501', N'728')
INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (12, N'A10BH', N'ингибиторы дипептидилпептидазы-4 (ДПП-4)', N'саксаглиптин', N'2017', N'1785')
INSERT [dbo].[dbStock2] ([id], [ATX], [Dec], [Name], [Price], [Quantity]) VALUES (13, N'A10BH', N'ингибиторы дипептидилпептидазы-4 (ДПП-4)', N'ситаглиптин', N'1344', N'922')
SET IDENTITY_INSERT [dbo].[dbStock2] OFF
GO

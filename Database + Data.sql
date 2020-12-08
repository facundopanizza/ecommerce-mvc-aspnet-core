CREATE DATABASE hardwarestore;
GO
USE hardwarestore;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 8/12/2020 17:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[ShortDescription] [nvarchar](max) NOT NULL,
	[LongDescription] [nvarchar](max) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[ImageName] [nvarchar](max) NULL,
	[IsProductOfTheWeek] [bit] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoppingCartItems]    Script Date: 8/12/2020 17:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoppingCartItems](
	[ShoppingCartItemId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[Amount] [int] NOT NULL,
	[ShoppingCartId] [nvarchar](max) NULL,
 CONSTRAINT [PK_ShoppingCartItems] PRIMARY KEY CLUSTERED 
(
	[ShoppingCartItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'Processor')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'GPU')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'RAM')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [Name], [ShortDescription], [LongDescription], [Price], [ImageName], [IsProductOfTheWeek], [CategoryId]) VALUES (1, N'Intel i9 9900K', N'8 Cores up to 5.0GHz Turbo unlocked', N'Specifications Mfr Part Number: BX80684I99900K Model: Intel Core i9-9900K Processor Core Name: Coffee Lake Core Count: 8 Thread Count: 16 Clock Speed: 3. 6 GHz Max Turbo Frequency: 5. 0 GHz Smart Cache: 16 MB DMI3: 8. 0 GT/s Lithography: 14nm Socket: LGA 1151 Max Thermal Design Power: 95W Memory Type: DDR4-2666 Processor Graphics: Intel UHD Graphics 630 Graphics Base Frequency: 350 MHz Graphics Max Dynamic Frequency: 1. 20 GHz Max CPU Configuration: 1 Advanced Technologies: Intel Optane Memory Supported Intel Turbo Boost 2. 0 Technology Intel vPro Platform Eligibility Intel Hyper-Threading Technology Intel Virtualization Technology (VT-x) Intel Virtualization Technology for Directed I/O (VT-d) Intel TSX-NI Intel 64 Instruction Set 64-bit Instruction Set Extensions - Intel SSE4. 1, Intel SSE4. 2, Intel AVX2 Idle States Enhanced Intel Speed Step Technology Thermal Monitoring Technologies Intel Identity Protection Technology Intel Stable Image Platform Program (SIPP) Intel AES New Instructions Secure Key Intel Software Guard Extensions (Intel SGX) Intel Memory Protection Extensions (Intel MPX) Intel OS Guard Intel Trusted Execution Technology Execute Disable Bit Intel Boot Guard.', CAST(60000.00 AS Decimal(18, 2)), N'1.jpg', 1, 1)
INSERT [dbo].[Products] ([ProductId], [Name], [ShortDescription], [LongDescription], [Price], [ImageName], [IsProductOfTheWeek], [CategoryId]) VALUES (2, N'AMD Ryzen 9 3900X ', N'12-core, 24-thread unlocked', N'AMD Ryzen 9 3900X 12-core, 24-thread unlocked desktop processor with Wraith Prism LED Cooler', CAST(65000.00 AS Decimal(18, 2)), N'2.jpg', 1, 1)
INSERT [dbo].[Products] ([ProductId], [Name], [ShortDescription], [LongDescription], [Price], [ImageName], [IsProductOfTheWeek], [CategoryId]) VALUES (3, N'XFX Radeon RX 580', N'GTS XXX Edition 1386MHz OC+, 8GB GDDR5', N'XFX Radeon RX 580 GTS XXX Edition 1386MHz OC+, 8GB GDDR5, VR Ready, Dual BIOS, 3xDP HDMI DVI, AMD Graphics Card (RX-580P8DFD6)', CAST(24000.00 AS Decimal(18, 2)), N'3.jpg', 0, 2)
INSERT [dbo].[Products] ([ProductId], [Name], [ShortDescription], [LongDescription], [Price], [ImageName], [IsProductOfTheWeek], [CategoryId]) VALUES (4, N'Crucial Ballistix RGB 3200 MGz DDR4 8GBx2', N'Crucial Ballistix RGB 3200 MHz DDR4 DRAM Desktop Gaming Memory Kit 16GB (8GBx2)', N'Crucial Ballistix RGB 3200 MHz DDR4 DRAM Desktop Gaming Memory Kit 16GB (8GBx2) CL16 BL2K8G32C16U4BL (Black) ', CAST(60000.00 AS Decimal(18, 2)), N'4.jpg', 1, 3)
INSERT [dbo].[Products] ([ProductId], [Name], [ShortDescription], [LongDescription], [Price], [ImageName], [IsProductOfTheWeek], [CategoryId]) VALUES (5, N'Intel Core i7-9700K', N'Intel Core i7-9700K Desktop Processor 8 Cores', N'Intel Core i7-9700K Desktop Processor 8 Cores up to 4.9 GHz Turbo unlocked LGA1151 300 Series 95W', CAST(45000.00 AS Decimal(18, 2)), N'5.jpg', 0, 1)
INSERT [dbo].[Products] ([ProductId], [Name], [ShortDescription], [LongDescription], [Price], [ImageName], [IsProductOfTheWeek], [CategoryId]) VALUES (6, N'XFX RX 5600 XT THICC III PRO', N'XFX RX 5600 XT THICC III PRO - 14GBPS 6GB GDDR6', N'XFX RX 5600 XT THICC III PRO - 14GBPS 6GB GDDR6 BOOST UP TO 1750MHz 3xDP HDMI Graphics Card RX-56XT6TF48 ', CAST(50000.00 AS Decimal(18, 2)), N'6.jpg', 1, 2)
INSERT [dbo].[Products] ([ProductId], [Name], [ShortDescription], [LongDescription], [Price], [ImageName], [IsProductOfTheWeek], [CategoryId]) VALUES (7, N'G.Skill 2x16GB DDR4 Trident Z Royal Gold', N'G.Skill 32GB DDR4 Trident Z Royal Gold 3200Mhz PC4-25600', N'G.Skill 32GB DDR4 Trident Z Royal Gold 3200Mhz PC4-25600 CL16 1.35V Dual Channel Kit (2x16GB) ', CAST(60000.00 AS Decimal(18, 2)), N'7.jpg', 1, 3)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ShoppingCartItems] ON 

INSERT [dbo].[ShoppingCartItems] ([ShoppingCartItemId], [ProductId], [Amount], [ShoppingCartId]) VALUES (1, 2, 1, N'96540ecf-9782-43a2-9369-0d4a773207c8')
SET IDENTITY_INSERT [dbo].[ShoppingCartItems] OFF
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 8/12/2020 17:19:53 ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ShoppingCartItems_ProductId]    Script Date: 8/12/2020 17:19:53 ******/
CREATE NONCLUSTERED INDEX [IX_ShoppingCartItems_ProductId] ON [dbo].[ShoppingCartItems]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[ShoppingCartItems]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingCartItems_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[ShoppingCartItems] CHECK CONSTRAINT [FK_ShoppingCartItems_Products_ProductId]
GO
USE [master]
GO
ALTER DATABASE [hardwarestore] SET  READ_WRITE 
GO

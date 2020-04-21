USE [AnyStore]
GO
/****** Object:  Table [dbo].[tbl_categories]    Script Date: 4/21/2020 10:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[description] [text] NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_dea_cust]    Script Date: 4/21/2020 10:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_dea_cust](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NULL,
	[name] [varchar](150) NULL,
	[email] [varchar](150) NULL,
	[contact] [varchar](15) NULL,
	[address] [text] NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_dea_cust] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_products]    Script Date: 4/21/2020 10:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[category] [varchar](50) NULL,
	[description] [text] NULL,
	[rate] [decimal](18, 2) NULL,
	[qty] [decimal](18, 2) NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_transaction_detail]    Script Date: 4/21/2020 10:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_transaction_detail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[rate] [decimal](18, 2) NULL,
	[qty] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NULL,
	[dea_cust_id] [int] NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_transaction_detail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_transactions]    Script Date: 4/21/2020 10:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_transactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NULL,
	[dea_cust_id] [int] NULL,
	[grandTotal] [decimal](18, 2) NULL,
	[transaction_date] [datetime] NULL,
	[tax] [decimal](18, 2) NULL,
	[discount] [decimal](18, 2) NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_transactions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_users]    Script Date: 4/21/2020 10:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[email] [varchar](150) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[contact] [varchar](15) NULL,
	[address] [text] NULL,
	[gender] [varchar](10) NULL,
	[user_type] [varchar](15) NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_categories] ON 

INSERT [dbo].[tbl_categories] ([id], [title], [description], [added_date], [added_by]) VALUES (1, N'Foods', N'All the products related to foods', CAST(N'2020-04-21T21:18:29.020' AS DateTime), 4)
INSERT [dbo].[tbl_categories] ([id], [title], [description], [added_date], [added_by]) VALUES (3, N'Clothes', N'All the products related to Clothes', CAST(N'2020-04-21T18:17:50.273' AS DateTime), 4)
INSERT [dbo].[tbl_categories] ([id], [title], [description], [added_date], [added_by]) VALUES (4, N'Drinks', N'All the products related to drinks', CAST(N'2020-04-21T21:20:58.997' AS DateTime), 4)
SET IDENTITY_INSERT [dbo].[tbl_categories] OFF
SET IDENTITY_INSERT [dbo].[tbl_users] ON 

INSERT [dbo].[tbl_users] ([id], [first_name], [last_name], [email], [username], [password], [contact], [address], [gender], [user_type], [added_date], [added_by]) VALUES (1, N'huan', N'hoa hong', N'test@test.com', N'test', N'test', N'3453453', N'asdfskdgf', N'Bede', N'User', CAST(N'2020-04-20T22:52:57.043' AS DateTime), 1)
INSERT [dbo].[tbl_users] ([id], [first_name], [last_name], [email], [username], [password], [contact], [address], [gender], [user_type], [added_date], [added_by]) VALUES (2, N'daubuoi', N'ancut', N'test1@test.com', N'test1', N'test1', N'2345345', N'fdghdfg2345', N'Male', N'User', CAST(N'2020-04-20T21:47:20.850' AS DateTime), 1)
INSERT [dbo].[tbl_users] ([id], [first_name], [last_name], [email], [username], [password], [contact], [address], [gender], [user_type], [added_date], [added_by]) VALUES (4, N'admin', N'ngo ba kha', N'admin@admin.com', N'admin', N'admin', N'93234234', N'dfgdfg2345', N'Male', N'Admin', CAST(N'2020-04-20T23:43:05.490' AS DateTime), 1)
INSERT [dbo].[tbl_users] ([id], [first_name], [last_name], [email], [username], [password], [contact], [address], [gender], [user_type], [added_date], [added_by]) VALUES (5, N'normal', N'user', N'user@user.com', N'user', N'user', N'2345345', N'fdghdfg2345', N'Male', N'User', CAST(N'2020-04-20T23:42:52.247' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[tbl_users] OFF

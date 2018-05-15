USE [SHSdb4]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 2018/05/15 11:08:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 2018/05/15 11:08:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Street] [nvarchar](max) NULL,
	[StreetNum] [int] NOT NULL,
	[Zipcode] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Province] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Addresses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Billinginfoes]    Script Date: 2018/05/15 11:08:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Billinginfoes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CardName] [nvarchar](max) NULL,
	[CardNum] [nvarchar](max) NULL,
	[CardCVV] [nvarchar](max) NULL,
	[CardExpireDate] [nvarchar](max) NULL,
	[CardType] [nvarchar](max) NULL,
	[Person_ID] [int] NULL,
 CONSTRAINT [PK_dbo.Billinginfoes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carts]    Script Date: 2018/05/15 11:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TotalPrice] [float] NOT NULL,
 CONSTRAINT [PK_dbo.Carts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2018/05/15 11:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DateJoined] [datetime] NOT NULL,
	[Person_ID] [int] NULL,
 CONSTRAINT [PK_dbo.Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contracts]    Script Date: 2018/05/15 11:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contracts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ContractName] [nvarchar](max) NULL,
	[Discription] [nvarchar](max) NULL,
	[DateExpire] [datetime] NOT NULL,
	[Date] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Contracts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConvienceProducts]    Script Date: 2018/05/15 11:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConvienceProducts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Discription] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[Warrenty_ID] [int] NULL,
	[System_ID] [int] NULL,
 CONSTRAINT [PK_dbo.ConvienceProducts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnergyProducts]    Script Date: 2018/05/15 11:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnergyProducts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Discription] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[Warrenty_ID] [int] NULL,
	[System_ID] [int] NULL,
 CONSTRAINT [PK_dbo.EnergyProducts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Maintenances]    Script Date: 2018/05/15 11:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maintenances](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DateStart] [nvarchar](max) NULL,
	[DateEnd] [nvarchar](max) NULL,
	[Contract_ID] [int] NULL,
 CONSTRAINT [PK_dbo.Maintenances] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 2018/05/15 11:08:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[EmailAddress] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[SSID] [nvarchar](max) NULL,
	[DOB] [nvarchar](max) NULL,
	[CellNumber] [nvarchar](max) NULL,
	[Address_ID] [int] NULL,
	[Department] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.People] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SafetyProducts]    Script Date: 2018/05/15 11:08:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SafetyProducts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Discription] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[Warrenty_ID] [int] NULL,
	[System_ID] [int] NULL,
 CONSTRAINT [PK_dbo.SafetyProducts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale_Emp]    Script Date: 2018/05/15 11:08:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale_Emp](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DateJoined] [datetime] NOT NULL,
	[Person_ID] [int] NULL,
 CONSTRAINT [PK_dbo.Sale_Emp] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 2018/05/15 11:08:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedules](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InsDateStart] [datetime] NOT NULL,
	[MainDateStart] [datetime] NOT NULL,
	[TechnicianEmp_ID] [int] NULL,
 CONSTRAINT [PK_dbo.Schedules] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Systems]    Script Date: 2018/05/15 11:08:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Systems](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[Cart_ID] [int] NULL,
 CONSTRAINT [PK_dbo.Systems] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TechnicianEmps]    Script Date: 2018/05/15 11:08:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnicianEmps](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DateJoined] [datetime] NOT NULL,
	[Experience] [nvarchar](max) NULL,
	[Person_ID] [int] NULL,
 CONSTRAINT [PK_dbo.TechnicianEmps] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 2018/05/15 11:08:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Cart_ID] [int] NULL,
	[Client_ID] [int] NULL,
	[Contract_ID] [int] NULL,
	[SaleEmp_ID] [int] NULL,
	[TechnicianEmp_ID] [int] NULL,
 CONSTRAINT [PK_dbo.Transactions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warrenties]    Script Date: 2018/05/15 11:08:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warrenties](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Discription] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Warrenties] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Billinginfoes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Billinginfoes_dbo.People_Person_ID] FOREIGN KEY([Person_ID])
REFERENCES [dbo].[People] ([ID])
GO
ALTER TABLE [dbo].[Billinginfoes] CHECK CONSTRAINT [FK_dbo.Billinginfoes_dbo.People_Person_ID]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Clients_dbo.People_Person_ID] FOREIGN KEY([Person_ID])
REFERENCES [dbo].[People] ([ID])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_dbo.Clients_dbo.People_Person_ID]
GO
ALTER TABLE [dbo].[ConvienceProducts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ConvienceProducts_dbo.Systems_System_ID] FOREIGN KEY([System_ID])
REFERENCES [dbo].[Systems] ([ID])
GO
ALTER TABLE [dbo].[ConvienceProducts] CHECK CONSTRAINT [FK_dbo.ConvienceProducts_dbo.Systems_System_ID]
GO
ALTER TABLE [dbo].[ConvienceProducts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ConvienceProducts_dbo.Warrenties_Warrenty_ID] FOREIGN KEY([Warrenty_ID])
REFERENCES [dbo].[Warrenties] ([ID])
GO
ALTER TABLE [dbo].[ConvienceProducts] CHECK CONSTRAINT [FK_dbo.ConvienceProducts_dbo.Warrenties_Warrenty_ID]
GO
ALTER TABLE [dbo].[EnergyProducts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EnergyProducts_dbo.Systems_System_ID] FOREIGN KEY([System_ID])
REFERENCES [dbo].[Systems] ([ID])
GO
ALTER TABLE [dbo].[EnergyProducts] CHECK CONSTRAINT [FK_dbo.EnergyProducts_dbo.Systems_System_ID]
GO
ALTER TABLE [dbo].[EnergyProducts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EnergyProducts_dbo.Warrenties_Warrenty_ID] FOREIGN KEY([Warrenty_ID])
REFERENCES [dbo].[Warrenties] ([ID])
GO
ALTER TABLE [dbo].[EnergyProducts] CHECK CONSTRAINT [FK_dbo.EnergyProducts_dbo.Warrenties_Warrenty_ID]
GO
ALTER TABLE [dbo].[Maintenances]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Maintenances_dbo.Contracts_Contract_ID] FOREIGN KEY([Contract_ID])
REFERENCES [dbo].[Contracts] ([ID])
GO
ALTER TABLE [dbo].[Maintenances] CHECK CONSTRAINT [FK_dbo.Maintenances_dbo.Contracts_Contract_ID]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_dbo.People_dbo.Addresses_Address_ID] FOREIGN KEY([Address_ID])
REFERENCES [dbo].[Addresses] ([ID])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_dbo.People_dbo.Addresses_Address_ID]
GO
ALTER TABLE [dbo].[SafetyProducts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SafetyProducts_dbo.Systems_System_ID] FOREIGN KEY([System_ID])
REFERENCES [dbo].[Systems] ([ID])
GO
ALTER TABLE [dbo].[SafetyProducts] CHECK CONSTRAINT [FK_dbo.SafetyProducts_dbo.Systems_System_ID]
GO
ALTER TABLE [dbo].[SafetyProducts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SafetyProducts_dbo.Warrenties_Warrenty_ID] FOREIGN KEY([Warrenty_ID])
REFERENCES [dbo].[Warrenties] ([ID])
GO
ALTER TABLE [dbo].[SafetyProducts] CHECK CONSTRAINT [FK_dbo.SafetyProducts_dbo.Warrenties_Warrenty_ID]
GO
ALTER TABLE [dbo].[Sale_Emp]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Sale_Emp_dbo.People_Person_ID] FOREIGN KEY([Person_ID])
REFERENCES [dbo].[People] ([ID])
GO
ALTER TABLE [dbo].[Sale_Emp] CHECK CONSTRAINT [FK_dbo.Sale_Emp_dbo.People_Person_ID]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Schedules_dbo.TechnicianEmps_TechnicianEmp_ID] FOREIGN KEY([TechnicianEmp_ID])
REFERENCES [dbo].[TechnicianEmps] ([ID])
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_dbo.Schedules_dbo.TechnicianEmps_TechnicianEmp_ID]
GO
ALTER TABLE [dbo].[Systems]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Systems_dbo.Carts_Cart_ID] FOREIGN KEY([Cart_ID])
REFERENCES [dbo].[Carts] ([ID])
GO
ALTER TABLE [dbo].[Systems] CHECK CONSTRAINT [FK_dbo.Systems_dbo.Carts_Cart_ID]
GO
ALTER TABLE [dbo].[TechnicianEmps]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TechnicianEmps_dbo.People_Person_ID] FOREIGN KEY([Person_ID])
REFERENCES [dbo].[People] ([ID])
GO
ALTER TABLE [dbo].[TechnicianEmps] CHECK CONSTRAINT [FK_dbo.TechnicianEmps_dbo.People_Person_ID]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Transactions_dbo.Carts_Cart_ID] FOREIGN KEY([Cart_ID])
REFERENCES [dbo].[Carts] ([ID])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_dbo.Transactions_dbo.Carts_Cart_ID]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Transactions_dbo.Clients_Client_ID] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Clients] ([ID])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_dbo.Transactions_dbo.Clients_Client_ID]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Transactions_dbo.Contracts_Contract_ID] FOREIGN KEY([Contract_ID])
REFERENCES [dbo].[Contracts] ([ID])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_dbo.Transactions_dbo.Contracts_Contract_ID]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Transactions_dbo.Sale_Emp_SaleEmp_ID] FOREIGN KEY([SaleEmp_ID])
REFERENCES [dbo].[Sale_Emp] ([ID])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_dbo.Transactions_dbo.Sale_Emp_SaleEmp_ID]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Transactions_dbo.TechnicianEmps_TechnicianEmp_ID] FOREIGN KEY([TechnicianEmp_ID])
REFERENCES [dbo].[TechnicianEmps] ([ID])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_dbo.Transactions_dbo.TechnicianEmps_TechnicianEmp_ID]
GO

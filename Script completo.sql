USE [master]
GO
/****** Object:  Database [Labosys]    Script Date: 10/3/2019 15:09:45 ******/
CREATE DATABASE [Labosys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Labosys', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Labosys.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Labosys_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Labosys_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Labosys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Labosys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Labosys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Labosys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Labosys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Labosys] SET ARITHABORT OFF 
GO
ALTER DATABASE [Labosys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Labosys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Labosys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Labosys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Labosys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Labosys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Labosys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Labosys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Labosys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Labosys] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Labosys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Labosys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Labosys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Labosys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Labosys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Labosys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Labosys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Labosys] SET RECOVERY FULL 
GO
ALTER DATABASE [Labosys] SET  MULTI_USER 
GO
ALTER DATABASE [Labosys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Labosys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Labosys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Labosys] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Labosys] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Labosys', N'ON'
GO
USE [Labosys]
GO
/****** Object:  Table [dbo].[Analisis]    Script Date: 10/3/2019 15:09:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Analisis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[cantNBU] [nchar](10) NULL,
 CONSTRAINT [PK_Analisis] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnalisisExamen]    Script Date: 10/3/2019 15:09:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnalisisExamen](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idExamen] [int] NOT NULL,
	[idAnalisis] [int] NOT NULL,
	[costo] [nchar](10) NULL,
 CONSTRAINT [PK_AnalisisExamen] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examenes]    Script Date: 10/3/2019 15:09:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examenes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[idPaciente] [int] NOT NULL,
	[idOS] [int] NOT NULL,
	[costo] [nchar](10) NULL,
 CONSTRAINT [PK_Examenes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ObrasSociales]    Script Date: 10/3/2019 15:09:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObrasSociales](
	[nombre] [nvarchar](50) NOT NULL,
	[porcentaje] [nchar](10) NOT NULL,
	[nbu] [nchar](10) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[habilitado] [bit] NOT NULL,
	[actoBioquimico] [nchar](10) NULL,
 CONSTRAINT [PK_ObrasSociales] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PacienteOS]    Script Date: 10/3/2019 15:09:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PacienteOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idOS] [int] NOT NULL,
	[IdPaciente] [int] NOT NULL,
	[afiliado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PacienteOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 10/3/2019 15:09:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[apellido] [nvarchar](50) NULL,
	[nombre] [nvarchar](50) NULL,
	[dni] [nchar](10) NULL,
	[habilitado] [bit] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Analisis] ON 

INSERT [dbo].[Analisis] ([id], [codigo], [nombre], [cantNBU]) VALUES (1, N'02020202020', N'jujuaas', N'2,5       ')
INSERT [dbo].[Analisis] ([id], [codigo], [nombre], [cantNBU]) VALUES (2, N'0505', N'sdg', N'0,56      ')
INSERT [dbo].[Analisis] ([id], [codigo], [nombre], [cantNBU]) VALUES (3, N'123', N'Piyo', N'3         ')
SET IDENTITY_INSERT [dbo].[Analisis] OFF
SET IDENTITY_INSERT [dbo].[AnalisisExamen] ON 

INSERT [dbo].[AnalisisExamen] ([id], [idExamen], [idAnalisis], [costo]) VALUES (7, 41, 2, N'12,32     ')
INSERT [dbo].[AnalisisExamen] ([id], [idExamen], [idAnalisis], [costo]) VALUES (8, 41, 3, N'66        ')
INSERT [dbo].[AnalisisExamen] ([id], [idExamen], [idAnalisis], [costo]) VALUES (9, 42, 1, N'50        ')
INSERT [dbo].[AnalisisExamen] ([id], [idExamen], [idAnalisis], [costo]) VALUES (10, 43, 1, N'105       ')
INSERT [dbo].[AnalisisExamen] ([id], [idExamen], [idAnalisis], [costo]) VALUES (11, 43, 2, N'23,52     ')
INSERT [dbo].[AnalisisExamen] ([id], [idExamen], [idAnalisis], [costo]) VALUES (12, 43, 3, N'126       ')
SET IDENTITY_INSERT [dbo].[AnalisisExamen] OFF
SET IDENTITY_INSERT [dbo].[Examenes] ON 

INSERT [dbo].[Examenes] ([id], [fecha], [idPaciente], [idOS], [costo]) VALUES (41, CAST(N'2015-03-03' AS Date), 1, 1, N'122,32    ')
INSERT [dbo].[Examenes] ([id], [fecha], [idPaciente], [idOS], [costo]) VALUES (42, CAST(N'2019-03-09' AS Date), 3, 4, N'70        ')
INSERT [dbo].[Examenes] ([id], [fecha], [idPaciente], [idOS], [costo]) VALUES (43, CAST(N'2019-03-09' AS Date), 4, 5, N'338,52    ')
SET IDENTITY_INSERT [dbo].[Examenes] OFF
SET IDENTITY_INSERT [dbo].[ObrasSociales] ON 

INSERT [dbo].[ObrasSociales] ([nombre], [porcentaje], [nbu], [id], [habilitado], [actoBioquimico]) VALUES (N'Ospac Gold', N'80        ', N'22        ', 1, 1, N'2         ')
INSERT [dbo].[ObrasSociales] ([nombre], [porcentaje], [nbu], [id], [habilitado], [actoBioquimico]) VALUES (N'Federada', N'60        ', N'10        ', 2, 1, N'4         ')
INSERT [dbo].[ObrasSociales] ([nombre], [porcentaje], [nbu], [id], [habilitado], [actoBioquimico]) VALUES (N'Ospac Gark', N'0.5       ', N'10        ', 3, 1, N'3         ')
INSERT [dbo].[ObrasSociales] ([nombre], [porcentaje], [nbu], [id], [habilitado], [actoBioquimico]) VALUES (N'Pami', N'60        ', N'20        ', 4, 1, N'1         ')
INSERT [dbo].[ObrasSociales] ([nombre], [porcentaje], [nbu], [id], [habilitado], [actoBioquimico]) VALUES (N'Swiss', N'100       ', N'42        ', 5, 0, N'2         ')
INSERT [dbo].[ObrasSociales] ([nombre], [porcentaje], [nbu], [id], [habilitado], [actoBioquimico]) VALUES (N'Ospac Premium', N'90        ', N'50        ', 6, 1, N'5         ')
INSERT [dbo].[ObrasSociales] ([nombre], [porcentaje], [nbu], [id], [habilitado], [actoBioquimico]) VALUES (N'Ninguna', N'0         ', N'1000      ', 7, 0, N'0         ')
SET IDENTITY_INSERT [dbo].[ObrasSociales] OFF
SET IDENTITY_INSERT [dbo].[PacienteOS] ON 

INSERT [dbo].[PacienteOS] ([id], [idOS], [IdPaciente], [afiliado]) VALUES (1, 1, 1, N'123456789')
INSERT [dbo].[PacienteOS] ([id], [idOS], [IdPaciente], [afiliado]) VALUES (2, 2, 1, N'0303456')
INSERT [dbo].[PacienteOS] ([id], [idOS], [IdPaciente], [afiliado]) VALUES (3, 1, 2, N'0303456')
INSERT [dbo].[PacienteOS] ([id], [idOS], [IdPaciente], [afiliado]) VALUES (4, 4, 3, N'0303456')
INSERT [dbo].[PacienteOS] ([id], [idOS], [IdPaciente], [afiliado]) VALUES (5, 5, 4, N'123456')
SET IDENTITY_INSERT [dbo].[PacienteOS] OFF
SET IDENTITY_INSERT [dbo].[Pacientes] ON 

INSERT [dbo].[Pacientes] ([apellido], [nombre], [dni], [habilitado], [id]) VALUES (N'De Lisio', N'Augusto', N'12345678  ', 1, 1)
INSERT [dbo].[Pacientes] ([apellido], [nombre], [dni], [habilitado], [id]) VALUES (N'Gimenez', N'Seba', N'32165487  ', 1, 2)
INSERT [dbo].[Pacientes] ([apellido], [nombre], [dni], [habilitado], [id]) VALUES (N'Gimenez', N'Sebastian', N'38541538  ', 1, 3)
INSERT [dbo].[Pacientes] ([apellido], [nombre], [dni], [habilitado], [id]) VALUES (N'asdg', N'agdfgaf', N'38456123  ', 0, 4)
SET IDENTITY_INSERT [dbo].[Pacientes] OFF
ALTER TABLE [dbo].[AnalisisExamen]  WITH CHECK ADD  CONSTRAINT [FK_AnalisisExamen_Analisis] FOREIGN KEY([idAnalisis])
REFERENCES [dbo].[Analisis] ([id])
GO
ALTER TABLE [dbo].[AnalisisExamen] CHECK CONSTRAINT [FK_AnalisisExamen_Analisis]
GO
ALTER TABLE [dbo].[AnalisisExamen]  WITH CHECK ADD  CONSTRAINT [FK_AnalisisExamen_Examenes] FOREIGN KEY([idExamen])
REFERENCES [dbo].[Examenes] ([id])
GO
ALTER TABLE [dbo].[AnalisisExamen] CHECK CONSTRAINT [FK_AnalisisExamen_Examenes]
GO
ALTER TABLE [dbo].[Examenes]  WITH CHECK ADD  CONSTRAINT [FK_Examenes_ObrasSociales] FOREIGN KEY([idOS])
REFERENCES [dbo].[ObrasSociales] ([id])
GO
ALTER TABLE [dbo].[Examenes] CHECK CONSTRAINT [FK_Examenes_ObrasSociales]
GO
ALTER TABLE [dbo].[Examenes]  WITH CHECK ADD  CONSTRAINT [FK_Examenes_Pacientes] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Pacientes] ([id])
GO
ALTER TABLE [dbo].[Examenes] CHECK CONSTRAINT [FK_Examenes_Pacientes]
GO
ALTER TABLE [dbo].[PacienteOS]  WITH CHECK ADD  CONSTRAINT [FK_PacienteOS_ObrasSociales] FOREIGN KEY([idOS])
REFERENCES [dbo].[ObrasSociales] ([id])
GO
ALTER TABLE [dbo].[PacienteOS] CHECK CONSTRAINT [FK_PacienteOS_ObrasSociales]
GO
ALTER TABLE [dbo].[PacienteOS]  WITH CHECK ADD  CONSTRAINT [FK_PacienteOS_Pacientes] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Pacientes] ([id])
GO
ALTER TABLE [dbo].[PacienteOS] CHECK CONSTRAINT [FK_PacienteOS_Pacientes]
GO
USE [master]
GO
ALTER DATABASE [Labosys] SET  READ_WRITE 
GO

USE [Labosys]
GO
/****** Object:  Table [dbo].[Analisis]    Script Date: 8/3/2019 10:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Analisis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[cantUG] [nchar](10) NULL,
	[cantUH] [nchar](10) NULL,
	[cantNBU] [nchar](10) NULL,
 CONSTRAINT [PK_Analisis] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PacienteOS]    Script Date: 8/3/2019 10:59:05 ******/
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
SET IDENTITY_INSERT [dbo].[Analisis] ON 

INSERT [dbo].[Analisis] ([id], [codigo], [nombre], [cantUG], [cantUH], [cantNBU]) VALUES (1, N'02020202020', N'jujuaas', N'0.85      ', N'0.85      ', N'0.85      ')
INSERT [dbo].[Analisis] ([id], [codigo], [nombre], [cantUG], [cantUH], [cantNBU]) VALUES (2, N'0505', N'sdg', N'0.14      ', N'0.22      ', N'0.56      ')
SET IDENTITY_INSERT [dbo].[Analisis] OFF
SET IDENTITY_INSERT [dbo].[PacienteOS] ON 

INSERT [dbo].[PacienteOS] ([id], [idOS], [IdPaciente], [afiliado]) VALUES (1, 1, 1, N'123456789')
INSERT [dbo].[PacienteOS] ([id], [idOS], [IdPaciente], [afiliado]) VALUES (2, 2, 1, N'0303456')
INSERT [dbo].[PacienteOS] ([id], [idOS], [IdPaciente], [afiliado]) VALUES (3, 1, 2, N'0303456')
SET IDENTITY_INSERT [dbo].[PacienteOS] OFF
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

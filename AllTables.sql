USE [Labosys]
GO
/****** Object:  Table [dbo].[Analisis]    Script Date: 08/03/2019 01:46:35 p.m. ******/
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
/****** Object:  Table [dbo].[AnalisisExamen]    Script Date: 08/03/2019 01:46:35 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnalisisExamen](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idExamen] [int] NOT NULL,
	[idAnalisis] [int] NOT NULL,
 CONSTRAINT [PK_AnalisisExamen] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Examenes]    Script Date: 08/03/2019 01:46:35 p.m. ******/
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
/****** Object:  Table [dbo].[ObrasSociales]    Script Date: 08/03/2019 01:46:35 p.m. ******/
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
/****** Object:  Table [dbo].[PacienteOS]    Script Date: 08/03/2019 01:46:35 p.m. ******/
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
/****** Object:  Table [dbo].[Pacientes]    Script Date: 08/03/2019 01:46:35 p.m. ******/
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

INSERT [dbo].[Analisis] ([id], [codigo], [nombre], [cantNBU]) VALUES (1, N'02020202020', N'jujuaas', N'0.85      ')
INSERT [dbo].[Analisis] ([id], [codigo], [nombre], [cantNBU]) VALUES (2, N'0505', N'sdg', N'0.56      ')
INSERT [dbo].[Analisis] ([id], [codigo], [nombre], [cantNBU]) VALUES (3, N'123', N'Piyo', N'3         ')
SET IDENTITY_INSERT [dbo].[Analisis] OFF
SET IDENTITY_INSERT [dbo].[Examenes] ON 

INSERT [dbo].[Examenes] ([id], [fecha], [idPaciente], [idOS], [costo]) VALUES (1, CAST(N'2019-03-08' AS Date), 1, 1, NULL)
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
SET IDENTITY_INSERT [dbo].[PacienteOS] OFF
SET IDENTITY_INSERT [dbo].[Pacientes] ON 

INSERT [dbo].[Pacientes] ([apellido], [nombre], [dni], [habilitado], [id]) VALUES (N'De Lisio', N'Augusto', N'12345678  ', 1, 1)
INSERT [dbo].[Pacientes] ([apellido], [nombre], [dni], [habilitado], [id]) VALUES (N'Gimenez', N'Seba', N'32165487  ', 1, 2)
INSERT [dbo].[Pacientes] ([apellido], [nombre], [dni], [habilitado], [id]) VALUES (N'asdf', N'sadfasd', N'38541538  ', 1, 3)
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

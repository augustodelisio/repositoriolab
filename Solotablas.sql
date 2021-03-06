USE [Labosys]
GO
/****** Object:  Table [dbo].[Analisis]    Script Date: 11/03/2019 08:09:07 p.m. ******/
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
/****** Object:  Table [dbo].[AnalisisExamen]    Script Date: 11/03/2019 08:09:07 p.m. ******/
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
/****** Object:  Table [dbo].[Examenes]    Script Date: 11/03/2019 08:09:07 p.m. ******/
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
	[actoBioquimico] [nchar](10) NULL,
 CONSTRAINT [PK_Examenes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ObrasSociales]    Script Date: 11/03/2019 08:09:07 p.m. ******/
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
/****** Object:  Table [dbo].[PacienteOS]    Script Date: 11/03/2019 08:09:07 p.m. ******/
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
/****** Object:  Table [dbo].[Pacientes]    Script Date: 11/03/2019 08:09:07 p.m. ******/
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

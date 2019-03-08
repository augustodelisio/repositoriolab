USE [Labosys]
GO
/****** Object:  Table [dbo].[AnalisisExamen]    Script Date: 08/03/2019 01:45:42 p.m. ******/
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
/****** Object:  Table [dbo].[Examenes]    Script Date: 08/03/2019 01:45:42 p.m. ******/
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
SET IDENTITY_INSERT [dbo].[Examenes] ON 

INSERT [dbo].[Examenes] ([id], [fecha], [idPaciente], [idOS], [costo]) VALUES (1, CAST(N'2019-03-08' AS Date), 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[Examenes] OFF
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

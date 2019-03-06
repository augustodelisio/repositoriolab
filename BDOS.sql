USE [Labosys]
GO
/****** Object:  Table [dbo].[ObrasSociales]    Script Date: 06/03/2019 05:15:12 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObrasSociales](
	[nombre] [nvarchar](50) NOT NULL,
	[porcentaje] [nchar](10) NOT NULL,
	[tipo] [bit] NOT NULL,
	[arancel] [nchar](10) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[habilitado] [bit] NOT NULL,
 CONSTRAINT [PK_ObrasSociales] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ObrasSociales] ON 

INSERT [dbo].[ObrasSociales] ([nombre], [porcentaje], [tipo], [arancel], [id], [habilitado]) VALUES (N'Ospac Gold', N'80        ', 1, N'22        ', 1, 1)
INSERT [dbo].[ObrasSociales] ([nombre], [porcentaje], [tipo], [arancel], [id], [habilitado]) VALUES (N'potasio', N'60        ', 0, N'10        ', 2, 0)
INSERT [dbo].[ObrasSociales] ([nombre], [porcentaje], [tipo], [arancel], [id], [habilitado]) VALUES (N'Ospac Gark', N'5         ', 0, N'10        ', 3, 1)
SET IDENTITY_INSERT [dbo].[ObrasSociales] OFF

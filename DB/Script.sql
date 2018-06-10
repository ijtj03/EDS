USE [HorasBecaDB]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 6/8/2018 4:26:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[IdCurso] [int] UNIQUE NOT NULL,
	[Codigo] [varchar](6) NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[IdCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 6/8/2018 4:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[IdDepartamento] [int] IDENTITY(1,1) UNIQUE NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Descripcion] [varchar](300) NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[IdDepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTADO]    Script Date: 6/8/2018 4:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADO](
	[Id] [int] NOT NULL UNIQUE,
	[Estado] [varchar](10) NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoSolicitud]    Script Date: 6/8/2018 4:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoSolicitud](
	[IdEstado] [int] UNIQUE IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estudiantes]    Script Date: 6/8/2018 4:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estudiantes](
	[carne] [varchar](11) UNIQUE NOT NULL,
	[correo_electronico] [varchar](100) NOT NULL,
	[primer_nombre] [varchar](20) NOT NULL,
	[segundo_nombre] [varchar](20) NULL,
	[primer_apellido] [varchar](20) NOT NULL,
	[segundo_apellido] [varchar](20) NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
 CONSTRAINT [estudiantes_pkey] PRIMARY KEY CLUSTERED 
(
	[carne] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[correo_electronico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstudiantexFormulario]    Script Date: 6/8/2018 4:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstudiantexFormulario](
	[IdCarnet] [varchar](11) NOT NULL,
	[IdFormulario] [int] NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
 CONSTRAINT [PK_EstudiantexFormulario] PRIMARY KEY CLUSTERED 
(
	[IdCarnet] ASC,
	[IdFormulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formulario]    Script Date: 6/8/2018 4:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formulario](
	[IdFormulario] [int] IDENTITY(1,1) UNIQUE NOT NULL,
	[IdCurso] [int] NULL,
	[IdDepartamento] [int] NOT NULL,
	[Telefono] [varchar](8) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[PromedioCurso] [decimal](9, 7) NULL,
	[PromedioPonderadoAnterior] [decimal](9, 7) NOT NULL,
	[PromedioPonderadoGeneral] [decimal](9, 7) NOT NULL,
	[CuentaBancaria] [int] NOT NULL,
	[ImgCuentaBancaria] [varchar](max) NOT NULL,
	[ImgPromedioPonderado] [varchar](max) NOT NULL,
	[ImgPromedioGeneral] [varchar](max) NOT NULL,
	[ImgCedula] [varchar](max) NOT NULL,
	[OtraBeca] [varchar](2) NULL,
	[OtraBecaHoras] [int] NOT NULL,
	[Cedula] [varchar](9) NOT NULL,
	[IdTipoBeca] [int] NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[IdFormulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MENSAJE]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MENSAJE](
	[Id] [int] NOT NULL,
	[EmailOrigen] [varchar](50) NOT NULL,
	[EmailDestino] [varchar](50) NOT NULL,
	[Tema] [varchar](50) NULL,
	[Mensaje] [varchar](250) NOT NULL,
	[Estado] [int] NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MensajeHTML]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MensajeHTML](
	[IdMensajeHTML] [int] IDENTITY(1,1) NOT NULL,
	[Mensaje] [nvarchar](1) NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[IdMensajeHTML] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MensajeHTMLxSistema]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MensajeHTMLxSistema](
	[IdSistema] [int] NOT NULL,
	[IdMensajeHTML] [int] NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[IdSistema] ASC,
	[IdMensajeHTML] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MENSAJENUEVO]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MENSAJENUEVO](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmailOrigen] [varchar](50) NOT NULL,
	[EmailDestino] [varchar](50) NOT NULL,
	[Tema] [varchar](50) NULL,
	[Mensaje] [varchar](250) NOT NULL,
	[Intentos] [int] NOT NULL,
	[Prioridad] [int] NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parametro](
	[IdParametro] [int] IDENTITY(1,1) NOT NULL,
	[FechaAjuste] [date] NOT NULL,
	[FechaInicialSol] [date] NOT NULL,
	[FechaFinalSol] [date] NOT NULL,
	[FechaInicialCal] [date] NOT NULL,
	[FechaFinalCal] [date] NOT NULL,
	[HorasBecaTotales] [int] NOT NULL,
	[HorasBecaEstudiante] [int] NOT NULL,
	[HorasBecaAsis] [int] NOT NULL,
	[HorasBecaAsEsp] [int] NOT NULL,
	[HorasBecaTutoria] [int] NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[IdParametro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParametroxSistema]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParametroxSistema](
	[IdSistema] [int] NOT NULL,
	[IdParametro] [int] NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[IdSistema] ASC,
	[IdParametro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[sistema] [int] NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
 CONSTRAINT [rol_pkey] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles_por_usuario]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles_por_usuario](
	[usuario] [int] NOT NULL,
	[rol] [int] NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
 CONSTRAINT [roles_por_usuario_pkey] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC,
	[rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sistema_informacion]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sistema_informacion](
	[id_sistema] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
 CONSTRAINT [sistema_informacion_pkey] PRIMARY KEY CLUSTERED 
(
	[id_sistema] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Solicitud]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Solicitud](
	[IdSolicitud] [int] NOT NULL,
	[IdCarnet] [varchar](11) NOT NULL,
	[IdFormulario] [int] NOT NULL,
	[IdEstado] [int] NOT NULL,
	[Observacion] [varchar](300) NOT NULL,
	[FechaSolicitud] [date] NOT NULL,
	[PeriodoSolicitud] [varchar](2) NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[IdSolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SolicitudxFormulario]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SolicitudxFormulario](
	[IdSolicitud] [int] NOT NULL,
	[IdFormulario] [int] NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
 CONSTRAINT [PK_SolicitudxFormulario] PRIMARY KEY CLUSTERED 
(
	[IdSolicitud] ASC,
	[IdFormulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoBeca]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoBeca](
	[IdTipoBeca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
PRIMARY KEY CLUSTERED 
(
	[IdTipoBeca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](9) NOT NULL,
	[correo_electronico] [varchar](100) NOT NULL,
	[contrasenna] [varchar](max) NOT NULL,
	[primer_nombre] [varchar](20) NOT NULL,
	[segundo_nombre] [varchar](20) NULL,
	[primer_apellido] [varchar](20) NOT NULL,
	[segundo_apellido] [varchar](20) NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
 CONSTRAINT [usuario_pkey] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[correo_electronico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioxEstudiante]    Script Date: 6/8/2018 4:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioxEstudiante](
	[IdUsuario] [int] NOT NULL,
	[IdCarnet] [varchar](11) NOT NULL,
	[Observaciones] [varchar](300) NULL,
	[Recomienda] [bit] NOT NULL,
	[HorasAsignadas] [int] NOT NULL,
	[HorasLaboradas] [int] NOT NULL,
	[Delete] [bit] NOT NULL DEFAULT 0,
 CONSTRAINT [PK_UsuarioxEstudiante] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdCarnet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EstudiantexFormulario]  WITH CHECK ADD  CONSTRAINT [FK_IdCarnetEstudiantexFormulario] FOREIGN KEY([IdCarnet])
REFERENCES [dbo].[estudiantes] ([carne])
GO
ALTER TABLE [dbo].[EstudiantexFormulario] CHECK CONSTRAINT [FK_IdCarnetEstudiantexFormulario]
GO
ALTER TABLE [dbo].[EstudiantexFormulario]  WITH CHECK ADD  CONSTRAINT [FK_IdEstudiantexIdFormulario] FOREIGN KEY([IdFormulario])
REFERENCES [dbo].[Formulario] ([IdFormulario])
GO
ALTER TABLE [dbo].[EstudiantexFormulario] CHECK CONSTRAINT [FK_IdEstudiantexIdFormulario]
GO
ALTER TABLE [dbo].[Formulario]  WITH CHECK ADD FOREIGN KEY([IdCurso])
REFERENCES [dbo].[Curso] ([IdCurso])
GO
ALTER TABLE [dbo].[Formulario]  WITH CHECK ADD FOREIGN KEY([IdDepartamento])
REFERENCES [dbo].[Departamento] ([IdDepartamento])
GO
ALTER TABLE [dbo].[Formulario]  WITH CHECK ADD FOREIGN KEY([IdTipoBeca])
REFERENCES [dbo].[TipoBeca] ([IdTipoBeca])
GO
ALTER TABLE [dbo].[MENSAJE]  WITH CHECK ADD  CONSTRAINT [FK_MENSAJE_ESTADO] FOREIGN KEY([Estado])
REFERENCES [dbo].[ESTADO] ([Id])
GO
ALTER TABLE [dbo].[MENSAJE] CHECK CONSTRAINT [FK_MENSAJE_ESTADO]
GO
ALTER TABLE [dbo].[MensajeHTMLxSistema]  WITH CHECK ADD  CONSTRAINT [FK_IdMensajeHTMLMensajeHTMLxSistema] FOREIGN KEY([IdMensajeHTML])
REFERENCES [dbo].[MensajeHTML] ([IdMensajeHTML])
GO
ALTER TABLE [dbo].[MensajeHTMLxSistema] CHECK CONSTRAINT [FK_IdMensajeHTMLMensajeHTMLxSistema]
GO
ALTER TABLE [dbo].[MensajeHTMLxSistema]  WITH CHECK ADD  CONSTRAINT [FK_IdSistemaMensajeHTMLxSistema] FOREIGN KEY([IdSistema])
REFERENCES [dbo].[sistema_informacion] ([id_sistema])
GO
ALTER TABLE [dbo].[MensajeHTMLxSistema] CHECK CONSTRAINT [FK_IdSistemaMensajeHTMLxSistema]
GO
ALTER TABLE [dbo].[ParametroxSistema]  WITH CHECK ADD  CONSTRAINT [FK_IdParametroParametroxSistema] FOREIGN KEY([IdParametro])
REFERENCES [dbo].[Parametro] ([IdParametro])
GO
ALTER TABLE [dbo].[ParametroxSistema] CHECK CONSTRAINT [FK_IdParametroParametroxSistema]
GO
ALTER TABLE [dbo].[ParametroxSistema]  WITH CHECK ADD  CONSTRAINT [FK_IdSistemaParametroxSistema] FOREIGN KEY([IdSistema])
REFERENCES [dbo].[sistema_informacion] ([id_sistema])
GO
ALTER TABLE [dbo].[ParametroxSistema] CHECK CONSTRAINT [FK_IdSistemaParametroxSistema]
GO
ALTER TABLE [dbo].[rol]  WITH CHECK ADD  CONSTRAINT [rol_sistema_fkey] FOREIGN KEY([sistema])
REFERENCES [dbo].[sistema_informacion] ([id_sistema])
GO
ALTER TABLE [dbo].[rol] CHECK CONSTRAINT [rol_sistema_fkey]
GO
ALTER TABLE [dbo].[roles_por_usuario]  WITH CHECK ADD  CONSTRAINT [email_rol_p_usario_fkey] FOREIGN KEY([usuario])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[roles_por_usuario] CHECK CONSTRAINT [email_rol_p_usario_fkey]
GO
ALTER TABLE [dbo].[roles_por_usuario]  WITH CHECK ADD  CONSTRAINT [rol_rol_p_usario_fkey] FOREIGN KEY([rol])
REFERENCES [dbo].[rol] ([id_rol])
GO
ALTER TABLE [dbo].[roles_por_usuario] CHECK CONSTRAINT [rol_rol_p_usario_fkey]
GO
ALTER TABLE [dbo].[Solicitud]  WITH CHECK ADD  CONSTRAINT [FK_IdCarnetSolicitud] FOREIGN KEY([IdCarnet])
REFERENCES [dbo].[estudiantes] ([carne])
GO
ALTER TABLE [dbo].[Solicitud] CHECK CONSTRAINT [FK_IdCarnetSolicitud]
GO
ALTER TABLE [dbo].[Solicitud]  WITH CHECK ADD  CONSTRAINT [FK_IdEstadoSolicitud] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[EstadoSolicitud] ([IdEstado])
GO
ALTER TABLE [dbo].[Solicitud] CHECK CONSTRAINT [FK_IdEstadoSolicitud]
GO
ALTER TABLE [dbo].[SolicitudxFormulario]  WITH CHECK ADD FOREIGN KEY([IdFormulario])
REFERENCES [dbo].[Formulario] ([IdFormulario])
GO
ALTER TABLE [dbo].[SolicitudxFormulario]  WITH CHECK ADD FOREIGN KEY([IdSolicitud])
REFERENCES [dbo].[Solicitud] ([IdSolicitud])
GO
ALTER TABLE [dbo].[UsuarioxEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_IdCarnetUsuarioxEstudiante] FOREIGN KEY([IdCarnet])
REFERENCES [dbo].[estudiantes] ([carne])
GO
ALTER TABLE [dbo].[UsuarioxEstudiante] CHECK CONSTRAINT [FK_IdCarnetUsuarioxEstudiante]
GO
ALTER TABLE [dbo].[UsuarioxEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_IdUsuarioxEstudiante] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[UsuarioxEstudiante] CHECK CONSTRAINT [FK_IdUsuarioxEstudiante]
GO

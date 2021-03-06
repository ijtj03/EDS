USE [HorasBecaDB]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 6/16/2018 9:50:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[IdCurso] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](6) NOT NULL,
	[Delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[IdCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 6/16/2018 9:50:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[IdDepartamento] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Descripcion] [varchar](300) NOT NULL,
	[Delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[IdDepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTADO]    Script Date: 6/16/2018 9:50:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADO](
	[Id] [int] NOT NULL,
	[Estado] [varchar](10) NOT NULL,
	[Delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoSolicitud]    Script Date: 6/16/2018 9:50:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoSolicitud](
	[IdEstado] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estudiantes]    Script Date: 6/16/2018 9:50:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estudiantes](
	[carne] [varchar](11) NOT NULL,
	[correo_electronico] [varchar](100) NOT NULL,
	[primer_nombre] [varchar](20) NOT NULL,
	[segundo_nombre] [varchar](20) NULL,
	[primer_apellido] [varchar](20) NOT NULL,
	[segundo_apellido] [varchar](20) NOT NULL,
	[Delete] [bit] NOT NULL,
 CONSTRAINT [estudiantes_pkey] PRIMARY KEY CLUSTERED 
(
	[carne] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[carne] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[correo_electronico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstudiantexFormulario]    Script Date: 6/16/2018 9:50:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstudiantexFormulario](
	[IdCarnet] [varchar](11) NOT NULL,
	[IdFormulario] [int] NOT NULL,
	[Delete] [bit] NOT NULL,
 CONSTRAINT [PK_EstudiantexFormulario] PRIMARY KEY CLUSTERED 
(
	[IdCarnet] ASC,
	[IdFormulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluacion]    Script Date: 6/16/2018 9:50:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluacion](
	[IdUsuario] [int] NOT NULL,
	[IdSolicitud] [int] NOT NULL,
	[Observaciones] [varchar](300) NULL,
	[Recomienda] [bit] NULL,
	[HorasAsignadas] [int] NOT NULL,
	[HorasLaboradas] [int] NULL,
	[Delete] [bit] NOT NULL,
	[IdEvaluacion] [int] IDENTITY(1,1) NOT NULL,
UNIQUE NONCLUSTERED 
(
	[IdEvaluacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formulario]    Script Date: 6/16/2018 9:50:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formulario](
	[IdFormulario] [int] IDENTITY(1,1) NOT NULL,
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
	[Delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFormulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[IdFormulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MENSAJE]    Script Date: 6/16/2018 9:50:51 PM ******/
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
	[Delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MENSAJENUEVO]    Script Date: 6/16/2018 9:50:52 PM ******/
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
	[Delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 6/16/2018 9:50:52 PM ******/
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
	[Delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdParametro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParametroxSistema]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParametroxSistema](
	[IdSistema] [int] NOT NULL,
	[IdParametro] [int] NOT NULL,
	[Delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSistema] ASC,
	[IdParametro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[sistema] [int] NOT NULL,
	[Delete] [bit] NOT NULL,
 CONSTRAINT [rol_pkey] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles_por_usuario]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles_por_usuario](
	[usuario] [int] NOT NULL,
	[rol] [int] NOT NULL,
	[Delete] [bit] NOT NULL,
 CONSTRAINT [roles_por_usuario_pkey] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC,
	[rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sistema_informacion]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sistema_informacion](
	[id_sistema] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
	[Delete] [bit] NOT NULL,
 CONSTRAINT [sistema_informacion_pkey] PRIMARY KEY CLUSTERED 
(
	[id_sistema] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Solicitud]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Solicitud](
	[IdSolicitud] [int] IDENTITY(1,1) NOT NULL,
	[IdCarnet] [varchar](11) NOT NULL,
	[IdFormulario] [int] NOT NULL,
	[IdEstado] [int] NOT NULL,
	[Observacion] [varchar](300) NULL,
	[FechaSolicitud] [date] NOT NULL,
	[PeriodoSolicitud] [varchar](2) NOT NULL,
	[Delete] [bit] NOT NULL,
	[HorasSolicitadas] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoBeca]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoBeca](
	[IdTipoBeca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Delete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoBeca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 6/16/2018 9:50:52 PM ******/
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
	[Delete] [bit] NOT NULL,
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
ALTER TABLE [dbo].[Curso] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[Departamento] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[ESTADO] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[EstadoSolicitud] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[estudiantes] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[EstudiantexFormulario] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[Evaluacion] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[Formulario] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[MENSAJE] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[MENSAJENUEVO] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[Parametro] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[ParametroxSistema] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[rol] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[roles_por_usuario] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[sistema_informacion] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[Solicitud] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[TipoBeca] ADD  DEFAULT ((0)) FOR [Delete]
GO
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ((0)) FOR [Delete]
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
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_IdCarnetEvaluacion] FOREIGN KEY([IdSolicitud])
REFERENCES [dbo].[Solicitud] ([IdSolicitud])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_IdCarnetEvaluacion]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_IdEvaluacion] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_IdEvaluacion]
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
/****** Object:  StoredProcedure [dbo].[AceptarSolicitud]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AceptarSolicitud]
    @IdSolicitud int , @IdUsuario int , @HA int
AS
    UPDATE Solicitud
    SET IdEstado = 4
    WHERE  IdSolicitud = @IdSolicitud

  INSERT Evaluacion (IdUsuario,IdSolicitud,HorasAsignadas,HorasLaboradas) VALUES (@IdUsuario,@IdSolicitud,@HA,0)
GO
/****** Object:  StoredProcedure [dbo].[ActualizarFormulario]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarFormulario]
    @IdFormulario int,@Carne VARCHAR(11),@Telefono VARCHAR(8),@Correo VARCHAR(100),@PromedioCurso DECIMAL(9,7), 
	@PromedioPonderadoAnterior DECIMAL(9,7),@PromedioPonderadoGeneral DECIMAL(9,7),@CuentaBancaria int,@ImgCuentaBancaria VARCHAR(MAX),
	@ImgPromedioPonderado VARCHAR(MAX),@ImgPromedioGeneral VARCHAR(MAX),@ImgCedula VARCHAR(MAX),@OtraBeca VARCHAR(20),
	@OtraBecaHoras int,@Cedula VARCHAR(9)
AS
    UPDATE F
    SET F.Telefono = @Telefono,F.Correo = @Correo,F.PromedioCurso=@PromedioCurso,F.PromedioPonderadoAnterior=@PromedioPonderadoAnterior,
    F.PromedioPonderadoGeneral = @PromedioPonderadoGeneral,F.CuentaBancaria=@CuentaBancaria,F.ImgCuentaBancaria=@ImgCuentaBancaria,
    F.ImgPromedioPonderado=@ImgPromedioPonderado,F.ImgPromedioGeneral=@ImgPromedioGeneral,F.ImgCedula=@ImgCedula,F.OtraBeca=@OtraBeca,
    F.OtraBecaHoras=@OtraBecaHoras,F.Cedula =@Cedula
    FROM Formulario AS F 
    INNER JOIN EstudiantexFormulario AS EF
        ON EF.IdFormulario = F.IdFormulario
    INNER JOIN estudiantes AS E
        ON E.carne = EF.IdCarnet
    WHERE @IdFormulario = F.IdFormulario AND  @Carne = E.carne
GO
/****** Object:  StoredProcedure [dbo].[ActualizarFormularioEnviado]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarFormularioEnviado]
    @IdFormulario int,@Carne VARCHAR(11),@Telefono VARCHAR(8),@Correo VARCHAR(100),@PromedioCurso DECIMAL(9,7), 
	@PromedioPonderadoAnterior DECIMAL(9,7),@PromedioPonderadoGeneral DECIMAL(9,7),@CuentaBancaria int,@ImgCuentaBancaria VARCHAR(MAX),
	@ImgPromedioPonderado VARCHAR(MAX),@ImgPromedioGeneral VARCHAR(MAX),@ImgCedula VARCHAR(MAX),@OtraBeca VARCHAR(20),
	@OtraBecaHoras int,@Cedula VARCHAR(9)
AS
    UPDATE F
    SET Telefono = @Telefono,Correo = @Correo,PromedioCurso=@PromedioCurso,PromedioPonderadoAnterior=@PromedioPonderadoAnterior,
    PromedioPonderadoGeneral = @PromedioPonderadoGeneral,CuentaBancaria=@CuentaBancaria,ImgCuentaBancaria=@ImgCuentaBancaria,
    ImgPromedioPonderado=@ImgPromedioPonderado,ImgPromedioGeneral=@ImgPromedioGeneral,ImgCedula=@ImgCedula,OtraBeca=@OtraBeca,
    OtraBecaHoras=@OtraBecaHoras,Cedula =@Cedula
	FROM Formulario AS F
    WHERE @IdFormulario = IdFormulario
	UPDATE S
	SET FechaSolicitud = GETDATE()
	FROM Solicitud AS S
	WHERE S.IdFormulario = @IdFormulario
GO
/****** Object:  StoredProcedure [dbo].[ActualizarParametros]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarParametros]
    @IdParametro int,@FechaAjuste date,@FechaInicialSol date, @FechaFinalSol date, @FechaInicialCal date, @FechaFinalCal date,
    @HorasBecaTotales int, @HorasBecaEstudiante int, @HorasBecaAsis int, @HorasBecaAsEsp int,@HorasBecaTutoria int
AS
    UPDATE Parametro 
    SET FechaAjuste=@FechaAjuste,FechaInicialSol=@FechaInicialSol,FechaFinalSol=@FechaFinalSol,FechaInicialCal=@FechaInicialCal,FechaFinalCal=@FechaFinalCal,
    HorasBecaTotales=@HorasBecaTotales,HorasBecaEstudiante=@HorasBecaEstudiante,HorasBecaAsis=@HorasBecaAsis,HorasBecaAsEsp=@HorasBecaAsEsp,HorasBecaTutoria=@HorasBecaTutoria
    WHERE IdParametro = @IdParametro
GO
/****** Object:  StoredProcedure [dbo].[CancelarSolicitudEstudiante]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CancelarSolicitudEstudiante]
    @IdSolicitud int
AS
    UPDATE Solicitud
    SET IdEstado = 6
    WHERE  IdSolicitud = @IdSolicitud
 
GO
/****** Object:  StoredProcedure [dbo].[CancelarSolicitudUsuario]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CancelarSolicitudUsuario]
    @IdSolicitud int
AS
    UPDATE Solicitud
    SET IdEstado = 2
    WHERE  IdSolicitud = @IdSolicitud
 
GO
/****** Object:  StoredProcedure [dbo].[EnviarFormulario]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EnviarFormulario]
    @IdFormulario int, @IdCarnet VARCHAR(11), @Periodo VARCHAR(2)
AS
    INSERT Solicitud(IdCarnet,IdFormulario,IdEstado,Observacion,FechaSolicitud,PeriodoSolicitud,HorasSolicitadas) VALUES
    (@IdCarnet,@IdFormulario,1,NULL,GETDATE(),@Periodo,50)
    
GO
/****** Object:  StoredProcedure [dbo].[EstadoSolicitudCumple]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EstadoSolicitudCumple]
    @IdSolicitud int, @Observacion varchar(300)
AS
    UPDATE Solicitud 
	SET IdEstado = 7, Observacion = @Observacion
	WHERE IdSolicitud= @IdSolicitud
GO
/****** Object:  StoredProcedure [dbo].[EstadoSolicitudNoCumple]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EstadoSolicitudNoCumple]
    @IdSolicitud int, @Observacion varchar(300) 
AS
    UPDATE Solicitud
	SET IdEstado = 8, Observacion = @Observacion
	WHERE IdSolicitud= @IdSolicitud
GO
/****** Object:  StoredProcedure [dbo].[EvaluarEstudiantes]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EvaluarEstudiantes]
    @IdEvaluacion int, @Recomienda bit, @HorasLaboradas int, @Observaciones VARCHAR(300)
AS
    UPDATE Evaluacion
    SET Observaciones = @Observaciones, Recomienda = @Recomienda, HorasLaboradas = @HorasLaboradas
    WHERE IdEvaluacion = @IdEvaluacion
GO
/****** Object:  StoredProcedure [dbo].[GuardarEnviarFormulario]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GuardarEnviarFormulario]
    @Carne VARCHAR(11),@IdCurso int,@IdDepartamento int,@IdTipoBeca int,@Telefono VARCHAR(8) ,@Correo VARCHAR(100) ,
	@PromedioCurso DECIMAL(9,7), @PromedioPonderadoAnterior DECIMAL(9,7),@PromedioPonderadoGeneral DECIMAL(9,7),@CuentaBancaria int,
	@ImgCuentaBancaria VARCHAR(MAX),@ImgPromedioPonderado VARCHAR(MAX),@ImgPromedioGeneral VARCHAR(MAX),@ImgCedula VARCHAR(MAX),
	@OtraBeca VARCHAR(20),@OtraBecaHoras int,@Cedula VARCHAR(9),@HorasSolicitadas int,@Periodo VARCHAR(2)
AS
    INSERT Formulario(IdCurso,IdDepartamento,IdTipoBeca,Telefono,Correo,PromedioCurso,PromedioPonderadoAnterior,PromedioPonderadoGeneral
	,CuentaBancaria,ImgCuentaBancaria,ImgPromedioPonderado,ImgPromedioGeneral,ImgCedula,OtraBeca,OtraBecaHoras,Cedula)
	VALUES (@IdCurso,@IdDepartamento,@IdTipoBeca,@Telefono,@Correo,@PromedioCurso,@PromedioPonderadoAnterior,@PromedioPonderadoGeneral,@CuentaBancaria,
	@ImgCuentaBancaria,@ImgPromedioPonderado,@ImgPromedioGeneral,@ImgCedula,@OtraBeca,@OtraBecaHoras,@Cedula);
    DECLARE @IdFormulario AS int = SCOPE_IDENTITY();
	INSERT EstudiantexFormulario(IdCarnet,IdFormulario) VALUES (@Carne,@IdFormulario)
	EXECUTE EnviarFormulario  @IdFormulario,@Carne,@Periodo
GO
/****** Object:  StoredProcedure [dbo].[GuardarFormulario]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GuardarFormulario]
	@Carne VARCHAR(11),@IdCurso int,@IdDepartamento int,@IdTipoBeca int,@Telefono VARCHAR(8) ,@Correo VARCHAR(100) ,
	@PromedioCurso DECIMAL(9,7), @PromedioPonderadoAnterior DECIMAL(9,7),@PromedioPonderadoGeneral DECIMAL(9,7),@CuentaBancaria int,
	@ImgCuentaBancaria VARCHAR(MAX),@ImgPromedioPonderado VARCHAR(MAX),@ImgPromedioGeneral VARCHAR(MAX),@ImgCedula VARCHAR(MAX),
	@OtraBeca VARCHAR(20),@OtraBecaHoras int,@Cedula VARCHAR(9)
AS
	INSERT Formulario(IdCurso,IdDepartamento,IdTipoBeca,Telefono,Correo,PromedioCurso,PromedioPonderadoAnterior,PromedioPonderadoGeneral
	,CuentaBancaria,ImgCuentaBancaria,ImgPromedioPonderado,ImgPromedioGeneral,ImgCedula,OtraBeca,OtraBecaHoras,Cedula)
	VALUES (@IdCurso,@IdDepartamento,@IdTipoBeca,@Telefono,@Correo,@PromedioCurso,@PromedioPonderadoAnterior,@PromedioPonderadoGeneral,@CuentaBancaria,
	@ImgCuentaBancaria,@ImgPromedioPonderado,@ImgPromedioGeneral,@ImgCedula,@OtraBeca,@OtraBecaHoras,@Cedula);
    INSERT EstudiantexFormulario(IdCarnet,IdFormulario) VALUES (@Carne, SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[GuardarParametros]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GuardarParametros]
    @FechaAjuste date,@FechaInicialSol date, @FechaFinalSol date, @FechaInicialCal date, @FechaFinalCal date,
    @HorasBecaTotales int, @HorasBecaEstudiante int, @HorasBecaAsis int, @HorasBecaAsEsp int,@HorasBecaTutoria int
AS
    INSERT Parametro(FechaAjuste,FechaInicialSol,FechaFinalSol,FechaInicialCal,FechaFinalCal,
    HorasBecaTotales,HorasBecaEstudiante,HorasBecaAsis,HorasBecaAsEsp,HorasBecaTutoria)
    VALUES (@FechaAjuste,@FechaInicialSol,@FechaFinalSol,@FechaInicialCal,@FechaFinalCal,
    @HorasBecaTotales,@HorasBecaEstudiante,@HorasBecaAsis,@HorasBecaAsEsp,@HorasBecaTutoria)
GO
/****** Object:  StoredProcedure [dbo].[ObtenerEstudiantesxEvaluar]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerEstudiantesxEvaluar]
    @IdUsuario int 
AS
    SELECT EV.Observaciones,E.carne, EV.IdEvaluacion, E.primer_nombre, E.segundo_nombre, E.primer_apellido, E.segundo_apellido,TB.Nombre, EV.HorasAsignadas
    FROM Evaluacion AS EV 
    INNER JOIN Solicitud AS S
        ON EV.IdSolicitud = S.IdSolicitud
    INNER JOIN estudiantes AS E     
        ON S.IdCarnet = E.carne
    INNER JOIN Formulario AS F 
        ON S.IdFormulario = F.IdFormulario
    INNER JOIN TipoBeca AS TB 
        ON F.IdTipoBeca = TB.IdTipoBeca
    WHERE EV.IdUsuario = @IdUsuario AND EV.Observaciones IS NULL
GO
/****** Object:  StoredProcedure [dbo].[ObtenerEvaluacionEstudiante]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerEvaluacionEstudiante]
    @Carnet VARCHAR(11)
AS
    select U.primer_nombre, U.segundo_nombre, U.primer_apellido, U.segundo_apellido, EV.HorasLaboradas, EV.Observaciones, YEAR(S.FechaSolicitud) as Anho, S.PeriodoSolicitud , TB.Nombre as TBNombre from Solicitud as S
inner join Formulario as F on F.IdFormulario=S.IdFormulario
inner join TipoBeca as TB on TB.IdTipoBeca = F.IdTipoBeca
inner join Evaluacion as EV on EV.IdSolicitud = S.IdSolicitud
inner join usuario as U on U.id = EV.IdUsuario
where S.IdCarnet=@Carnet and S.IdEstado = 4
GO
/****** Object:  StoredProcedure [dbo].[ObtenerEvaluacionProfesor]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerEvaluacionProfesor]
    @Cedula VARCHAR(9)
AS
  SELECT E.primer_nombre, E.segundo_nombre, E.primer_apellido, E.segundo_apellido, EV.HorasLaboradas, EV.Observaciones, TB.Nombre as TBNombre, S.PeriodoSolicitud, YEAR(S.FechaSolicitud) as Anho
    FROM Evaluacion AS EV
    INNER JOIN Solicitud AS  S 
        ON EV.IdSolicitud = S.IdSolicitud
    INNER JOIN estudiantes AS E
        ON S.IdCarnet = E.carne
    INNER JOIN usuario AS U 
        ON U.cedula = @Cedula
  INNER JOIN Formulario AS F 
    ON S.IdFormulario = F.IdFormulario
  INNER JOIN TipoBeca AS TB
    ON TB.IdTipoBeca = F.IdTipoBeca
  WHERE S.IdEstado = 4 and S.[Delete] = 0 and EV.Observaciones IS NOT NULL
GO
/****** Object:  StoredProcedure [dbo].[RechazarSolicitud]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RechazarSolicitud]
    @IdSolicitud int
AS
    UPDATE Solicitud
    SET IdEstado = 5
    WHERE  IdSolicitud = @IdSolicitud
GO
/****** Object:  StoredProcedure [dbo].[ReplicarSolicitud]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReplicarSolicitud]
	@IdSolicitud int
AS
INSERT INTO Solicitud (FechaSolicitud,HorasSolicitadas,IdCarnet,IdEstado,IdFormulario,Observacion,PeriodoSolicitud)
SELECT FechaSolicitud,HorasSolicitadas,IdCarnet,IdEstado,IdFormulario,Observacion,PeriodoSolicitud
FROM Solicitud
WHERE IdSolicitud = @IdSolicitud
GO
/****** Object:  StoredProcedure [dbo].[ReporteFinalGeneral]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteFinalGeneral]
    @Anno int, @Periodo  VARCHAR(2)
AS
    SELECT E.primer_nombre, E.segundo_nombre, E.primer_apellido, E.segundo_apellido,E.carne, F.PromedioPonderadoGeneral, TB.Nombre, EV.HorasAsignadas , EV.HorasLaboradas
    FROM Solicitud AS S 
    INNER JOIN estudiantes AS E
        ON S.IdCarnet = E.carne
    INNER JOIN Formulario AS F
        ON F.IdFormulario = S.IdFormulario
    INNER JOIN TipoBeca AS TB  
        ON TB.IdTipoBeca = F.IdTipoBeca
	INNER JOIN Evaluacion AS EV 
		ON EV.IdSolicitud = S.IdSolicitud
    WHERE YEAR(S.FechaSolicitud) = @Anno AND S.PeriodoSolicitud = @Periodo
GO
/****** Object:  StoredProcedure [dbo].[ReporteFinalxTipoBeca]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteFinalxTipoBeca]
    @Anno int, @TipoBeca int, @Periodo  VARCHAR(2)
AS
    SELECT E.primer_nombre, E.carne , E.segundo_nombre, E.primer_apellido, E.segundo_apellido,E.carne, F.PromedioPonderadoGeneral, EV.HorasAsignadas , EV.HorasLaboradas
    FROM Solicitud AS S 
    INNER JOIN estudiantes AS E
        ON S.IdCarnet = E.carne
    INNER JOIN Formulario AS F
        ON F.IdFormulario = S.IdFormulario
  INNER JOIN Evaluacion AS EV 
    ON EV.IdSolicitud = S.IdSolicitud
    WHERE YEAR(S.FechaSolicitud) = @Anno AND F.IdTipoBeca = @TipoBeca AND S.PeriodoSolicitud = @Periodo AND S.IdEstado = 4
GO
/****** Object:  StoredProcedure [dbo].[ReporteInicialGeneral]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteInicialGeneral]
    @Anno int, @Periodo  VARCHAR(2)
AS
    SELECT E.primer_nombre, E.segundo_nombre, E.primer_apellido, E.segundo_apellido,E.carne,S.HorasSolicitadas, F.PromedioPonderadoGeneral, TB.Nombre
    FROM Solicitud AS S 
    INNER JOIN estudiantes AS E
        ON S.IdCarnet = E.carne
    INNER JOIN Formulario AS F
        ON F.IdFormulario = S.IdFormulario
    INNER JOIN TipoBeca AS TB  
        ON TB.IdTipoBeca = F.IdTipoBeca
    WHERE YEAR(S.FechaSolicitud) = @Anno AND S.PeriodoSolicitud = @Periodo
GO
/****** Object:  StoredProcedure [dbo].[ReporteInicialxTipoBeca]    Script Date: 6/16/2018 9:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteInicialxTipoBeca]
    @Anno int, @TipoBeca int, @Periodo  VARCHAR(2)
AS
    SELECT E.primer_nombre, E.segundo_nombre, E.primer_apellido, E.segundo_apellido,E.carne,S.HorasSolicitadas, F.PromedioPonderadoGeneral
    FROM Solicitud AS S 
    INNER JOIN estudiantes AS E
        ON S.IdCarnet = E.carne
    INNER JOIN Formulario AS F
        ON F.IdFormulario = S.IdFormulario
    WHERE S.PeriodoSolicitud = @Periodo AND YEAR(S.FechaSolicitud) = @Anno AND F.IdTipoBeca = @TipoBeca and S.IdEstado = 4
GO

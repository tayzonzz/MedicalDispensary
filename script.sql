USE [master]
GO
/****** Object:  Database [Dispensario]    Script Date: 6/17/2016 2:04:41 AM ******/
CREATE DATABASE [Dispensario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Dispensario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS2\MSSQL\DATA\Dispensario.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Dispensario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS2\MSSQL\DATA\Dispensario_log.ldf' , SIZE = 6272KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Dispensario] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dispensario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dispensario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dispensario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dispensario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dispensario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dispensario] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dispensario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dispensario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dispensario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dispensario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dispensario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dispensario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dispensario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dispensario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dispensario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dispensario] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dispensario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dispensario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dispensario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dispensario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dispensario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dispensario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dispensario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dispensario] SET RECOVERY FULL 
GO
ALTER DATABASE [Dispensario] SET  MULTI_USER 
GO
ALTER DATABASE [Dispensario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dispensario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dispensario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dispensario] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Dispensario] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Dispensario]
GO
/****** Object:  Table [dbo].[Farmaco]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Farmaco](
	[Identificador] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Farmaco] PRIMARY KEY CLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Marca]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[Identificador] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[FechaRegitro] [datetime] NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medicamento]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamento](
	[Identificador] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[Dosis] [nvarchar](max) NOT NULL,
	[id_tipoFarmaco] [int] NOT NULL,
	[id_ubicacion] [int] NOT NULL,
	[id_marca] [int] NOT NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Medicamento] PRIMARY KEY CLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medico]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medico](
	[Identificador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Cedula] [nvarchar](50) NOT NULL,
	[Tanda] [nvarchar](max) NOT NULL,
	[Especialidad] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Medico] PRIMARY KEY CLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[Identificador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Cedula] [nvarchar](50) NOT NULL,
	[No_Carnet] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[Tipo_Paciente] [int] NOT NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Registro_Visita]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro_Visita](
	[Identificador] [int] IDENTITY(1,1) NOT NULL,
	[id_Medico] [int] NOT NULL,
	[Fecha_Visita] [datetime] NOT NULL,
	[Hora_Visita] [datetime] NULL,
	[Sintomas] [nvarchar](max) NOT NULL,
	[id_Medicamento] [int] NOT NULL,
	[Recomendaciones] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[id_Paciente] [int] NOT NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Registro_Visita] PRIMARY KEY CLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipo_Paciente]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Paciente](
	[Identificador] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Tipo_Paciente] PRIMARY KEY CLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipo_Usuario]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Usuario](
	[Identificador] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Tipo_Usuario] PRIMARY KEY CLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ubicacion]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ubicacion](
	[Identificador] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[Estante] [nvarchar](max) NOT NULL,
	[Tramo] [nvarchar](max) NOT NULL,
	[Celda] [nvarchar](max) NOT NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Ubicacion] PRIMARY KEY CLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Identificador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Usuario] [nvarchar](max) NOT NULL,
	[Contrasenia] [nvarchar](max) NOT NULL,
	[Primer_nombre] [nvarchar](max) NOT NULL,
	[Otros_Nombres] [nvarchar](max) NULL,
	[Primer_Apellido] [nvarchar](max) NOT NULL,
	[Segundo_Apellido] [nvarchar](max) NULL,
	[Fecha_Nacimiento] [date] NOT NULL,
	[Ocupacion] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[Tipo_Usuario] [int] NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[Foto] [image] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_Usuario]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Usuario]
AS
SELECT        Identificador, Nombre_Usuario AS Usuario, Primer_nombre AS Nombre, Primer_Apellido AS [Primer Apellido], Segundo_Apellido AS [Segundo Apellido], Fecha_Nacimiento AS [Fecha de Nacimiento], 
                         Ocupacion AS Ocupación, Estado, FechaRegistro AS [Fecha de Registro], Tipo_Usuario AS [Tipo de Usuario]
FROM            dbo.Usuario

GO
ALTER TABLE [dbo].[Medicamento]  WITH CHECK ADD FOREIGN KEY([id_marca])
REFERENCES [dbo].[Marca] ([Identificador])
GO
ALTER TABLE [dbo].[Medicamento]  WITH CHECK ADD FOREIGN KEY([id_tipoFarmaco])
REFERENCES [dbo].[Farmaco] ([Identificador])
GO
ALTER TABLE [dbo].[Medicamento]  WITH CHECK ADD FOREIGN KEY([id_tipoFarmaco])
REFERENCES [dbo].[Farmaco] ([Identificador])
GO
ALTER TABLE [dbo].[Medicamento]  WITH CHECK ADD FOREIGN KEY([id_ubicacion])
REFERENCES [dbo].[Ubicacion] ([Identificador])
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK__Paciente__Tipo_P__25869641] FOREIGN KEY([Tipo_Paciente])
REFERENCES [dbo].[Tipo_Paciente] ([Identificador])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK__Paciente__Tipo_P__25869641]
GO
ALTER TABLE [dbo].[Registro_Visita]  WITH CHECK ADD  CONSTRAINT [FK__Registro___id_Me__267ABA7A] FOREIGN KEY([id_Medicamento])
REFERENCES [dbo].[Medicamento] ([Identificador])
GO
ALTER TABLE [dbo].[Registro_Visita] CHECK CONSTRAINT [FK__Registro___id_Me__267ABA7A]
GO
ALTER TABLE [dbo].[Registro_Visita]  WITH CHECK ADD  CONSTRAINT [FK__Registro___id_Me__286302EC] FOREIGN KEY([id_Medico])
REFERENCES [dbo].[Medico] ([Identificador])
GO
ALTER TABLE [dbo].[Registro_Visita] CHECK CONSTRAINT [FK__Registro___id_Me__286302EC]
GO
ALTER TABLE [dbo].[Registro_Visita]  WITH CHECK ADD  CONSTRAINT [FK__Registro___id_Me__29572725] FOREIGN KEY([id_Medicamento])
REFERENCES [dbo].[Medicamento] ([Identificador])
GO
ALTER TABLE [dbo].[Registro_Visita] CHECK CONSTRAINT [FK__Registro___id_Me__29572725]
GO
ALTER TABLE [dbo].[Registro_Visita]  WITH CHECK ADD  CONSTRAINT [FK__Registro___id_Pa__3A81B327] FOREIGN KEY([id_Paciente])
REFERENCES [dbo].[Paciente] ([Identificador])
GO
ALTER TABLE [dbo].[Registro_Visita] CHECK CONSTRAINT [FK__Registro___id_Pa__3A81B327]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Tipo_Us__24927208] FOREIGN KEY([Tipo_Usuario])
REFERENCES [dbo].[Tipo_Usuario] ([Identificador])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__Usuario__Tipo_Us__24927208]
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarFarmaco]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarFarmaco]
@Identificador INT,
@Descripcion VARCHAR(40),
@Estado VARCHAR(40)
AS
BEGIN
	UPDATE Farmaco
	SET Descripcion = @Descripcion, Estado = @Estado
	WHERE Identificador = @Identificador
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarMarca]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarMarca]
@Identificador INT,
@Descripcion VARCHAR(40),
@Estado VARCHAR(40)
AS
BEGIN
	UPDATE Marca
	SET Descripcion = @Descripcion, Estado = @Estado
	WHERE Identificador = @Identificador;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarMedicamento]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarMedicamento]
@Identificador INT,
@Descripcion VARCHAR(40),
@Estado VARCHAR(40),
@Dosis VARCHAR(40),
@idTipoFarmaco INT,
@idUbicacion iNT,
@idMarca INT
AS
BEGIN
	UPDATE Medicamento 
	SET Descripcion = @Descripcion, Estado = @Estado, Dosis = @Dosis, id_tipoFarmaco = @idTipoFarmaco, id_ubicacion = @idUbicacion, id_marca = @idMarca
	WHERE Identificador = @Identificador;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarMedico]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarMedico]
@Identificador INT,
@Nombre VARCHAR(40),
@Cedula CHAR(12),
@Tanda VARCHAR(40),
@Especialidad VARCHAR(40),
@Estado VARCHAR(40)
AS
BEGIN
	UPDATE Medico
	SET Nombre = @Nombre, Cedula = @Cedula, Tanda = @Tanda, Especialidad = @Especialidad, Estado = @Estado
	WHERE Identificador = @Identificador;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarPaciente]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarPaciente]
@Identificador INT,
@Nombre VARCHAR(40),
@Cedula CHAR(12),
@No_Carnet VARCHAR(40),
@Estado VARCHAR(40),
@TipoPaciente INT
AS
BEGIN
	UPDATE Paciente
	SET Nombre = @Nombre, Cedula = @Cedula, No_Carnet = @No_Carnet, Estado = @Estado, Tipo_Paciente = @TipoPaciente
	WHERE Identificador = @Identificador
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarUbicacion]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ActualizarUbicacion]
@Identificador INT,
@Descripcion VARCHAR(40),
@Estado CHAR(12),
@Estante VARCHAR(40),
@Tramo VARCHAR(40),
@Celda VARCHAR(40)
AS
BEGIN
	UPDATE Ubicacion
	SET Descripcion = @Descripcion, Estado = @Estado, Estante = @Estante, Tramo = @Tramo, Celda = @Celda
	WHERE Identificador = @Identificador;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarUsuario]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarUsuario]
@Identificador INT,
@NombreUsuario VARCHAR(40),
@Contraseña VARCHAR(40),
@PrimerNombre VARCHAR(40),
@OtrosNombres VARCHAR(99),
@PrimerApellido VARCHAR(40),
@SegundoApellido VARCHAR(40),
@FechaNacimiento DATETIME,
@Ocupacion VARCHAR(40),
@Estado VARCHAR(40),
@TipoUsuario INT
AS
BEGIN
	UPDATE Usuario
	SET Nombre_Usuario = @NombreUsuario, Contrasenia = @Contraseña, Primer_nombre = @PrimerNombre, Otros_Nombres = @OtrosNombres, Primer_Apellido = @PrimerApellido, Segundo_Apellido = @SegundoApellido, Fecha_Nacimiento = @FechaNacimiento, Ocupacion = @Ocupacion, Estado = @Estado, Tipo_Usuario = @TipoUsuario
	WHERE Identificador = @Identificador
END;	
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarUsuarioConFoto]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarUsuarioConFoto]
@Identificador INT,
@NombreUsuario VARCHAR(40),
@Contraseña VARCHAR(40),
@PrimerNombre VARCHAR(40),
@OtrosNombres VARCHAR(99),
@PrimerApellido VARCHAR(40),
@SegundoApellido VARCHAR(40),
@FechaNacimiento DATETIME,
@Ocupacion VARCHAR(40),
@Estado VARCHAR(40),
@TipoUsuario INT,
@Foto IMAGE
AS
BEGIN
	UPDATE Usuario
	SET Nombre_Usuario = @NombreUsuario, Contrasenia = @Contraseña, Primer_nombre = @PrimerNombre, Otros_Nombres = @OtrosNombres, Primer_Apellido = @PrimerApellido, Segundo_Apellido = @SegundoApellido, Fecha_Nacimiento = @FechaNacimiento, Ocupacion = @Ocupacion, Estado = @Estado, Tipo_Usuario = @TipoUsuario, Foto = @Foto
	WHERE Identificador = @Identificador
END;	
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarVisita]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarVisita]
@Identificador INT,
@idMedico INT,
@FechaVisita DATETIME,
@Sintomas VARCHAR(40),
@idMedicamento INT,
@Recomendaciones VARCHAR(200),
@Estado VARCHAR(40),
@idPaciente INT
AS
BEGIN
	UPDATE Registro_Visita
	SET Fecha_Visita = @FechaVisita, Sintomas = @Sintomas, id_Medicamento = @idMedicamento, Recomendaciones = @Recomendaciones, Estado = @Estado, id_Paciente = @idPaciente
	WHERE Identificador = @Identificador
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarFarmaco]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BuscarFarmaco]
AS
BEGIN
	SELECT * FROM Farmaco;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarMarca]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BuscarMarca]
AS
BEGIN
	SELECT * FROM Marca
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarMedicamento]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_BuscarMedicamento]
AS
BEGIN
	SELECT * FROM Medicamento
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarMedico]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_BuscarMedico]
AS
BEGIN
	SELECT * FROM Medico
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarPaciente]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_BuscarPaciente]
AS
BEGIN
	SELECT * FROM Paciente
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarTipoPaciente]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BuscarTipoPaciente]
AS
BEGIN
	SELECT * FROM Tipo_Paciente
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarTipoUsuario]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BuscarTipoUsuario]
AS
BEGIN
	SELECT * FROM Tipo_Usuario
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarUbicacion]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_BuscarUbicacion]
AS
BEGIN
	SELECT * FROM Ubicacion
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarUsuario]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_BuscarUsuario]
AS
BEGIN
	SELECT * FROM Usuario
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarVisita]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_BuscarVisita]
AS
BEGIN
	SELECT * FROM Registro_Visita
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarFilaFarmaco]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarFilaFarmaco]
@id INT
AS
BEGIN
	DELETE FROM Farmaco WHERE Identificador = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarFilaMarca]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EliminarFilaMarca]
@id INT
AS
BEGIN
	DELETE FROM Marca WHERE Identificador = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarFilaMedicamento]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EliminarFilaMedicamento]
@id INT
AS
BEGIN
	DELETE FROM Medicamento WHERE Identificador = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarFilaMedico]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarFilaMedico]
@id INT
AS
BEGIN
	DELETE FROM Medico WHERE Identificador = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarFilaPaciente]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarFilaPaciente]
@id INT
AS
BEGIN
	DELETE FROM Paciente WHERE Identificador = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarFilaUbicacion]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EliminarFilaUbicacion]
@id INT
AS
BEGIN
	DELETE FROM Ubicacion WHERE Identificador = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarFilaUsuario]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EliminarFilaUsuario]
@id INT
AS
BEGIN
	DELETE FROM Usuario WHERE Identificador = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarFilaVisita]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EliminarFilaVisita]
@id INT
AS
BEGIN
	DELETE FROM Registro_Visita WHERE Identificador = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ExisteCedulaMedico]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ExisteCedulaMedico]
@cedula VARCHAR(12)
AS
BEGIN
	SELECT COUNT(Identificador) FROM Medico WHERE cedula = @cedula;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ExisteCedulaPaciente]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ExisteCedulaPaciente]
@cedula VARCHAR(12)
AS
BEGIN
	SELECT COUNT(Identificador) FROM Paciente WHERE cedula = @cedula;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ExisteUsuario]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ExisteUsuario]
@usuario VARCHAR(40)
AS
BEGIN
	SELECT COUNT(Identificador) FROM Usuario WHERE Nombre_Usuario = @usuario;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarFarmaco]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarFarmaco]
@Descripcion VARCHAR(40),
@Estado VARCHAR(40)
AS
BEGIN
	INSERT INTO Farmaco VALUES(@Descripcion, @Estado, (SELECT SYSDATETIME()))
END;


GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarMarca]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarMarca]
@Descripcion VARCHAR(40),
@Estado VARCHAR(40)
AS
BEGIN
	INSERT INTO Marca VALUES(@Descripcion, @Estado, (SELECT SYSDATETIME()))
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarMedicamento]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarMedicamento]
@Descripcion VARCHAR(40),
@Estado VARCHAR(40),
@Dosis VARCHAR(40),
@idTipoFarmaco INT,
@idUbicacion iNT,
@idMarca INT
AS
BEGIN
	INSERT INTO Medicamento VALUES(@Descripcion, @Estado, @Dosis, @idTipoFarmaco, @idUbicacion, @idMarca, (SELECT SYSDATETIME()));
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarMedico]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarMedico]
@Nombre VARCHAR(40),
@Cedula CHAR(12),
@Tanda VARCHAR(40),
@Especialidad VARCHAR(40),
@Estado VARCHAR(40)
AS
BEGIN
	INSERT INTO Medico VALUES(@Nombre, @Cedula, @Tanda, @Especialidad, @Estado, (SELECT SYSDATETIME()));
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarPaciente]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarPaciente]
@Nombre VARCHAR(40),
@Cedula CHAR(12),
@No_Carnet VARCHAR(40),
@Estado VARCHAR(40),
@TipoPaciente INT
AS
BEGIN
	INSERT INTO Paciente VALUES(@Nombre, @Cedula, @No_Carnet, @Estado, @TipoPaciente, (SELECT SYSDATETIME()));
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarUbicacion]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarUbicacion]
@Descripcion VARCHAR(40),
@Estado CHAR(12),
@Estante VARCHAR(40),
@Tramo VARCHAR(40),
@Celda INT
AS
BEGIN
	INSERT INTO Ubicacion VALUES(@Descripcion, @Estado, @Estante, @Tramo, @Celda, (SELECT SYSDATETIME()));
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarUsuario]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarUsuario]
@NombreUsuario VARCHAR(40),
@Contraseña VARCHAR(40),
@PrimerNombre VARCHAR(40),
@OtrosNombres VARCHAR(99),
@PrimerApellido VARCHAR(40),
@SegundoApellido VARCHAR(40),
@FechaNacimiento DATETIME,
@Ocupacion VARCHAR(40),
@Estado VARCHAR(40),
@TipoUsuario INT,
@Foto IMAGE = null
AS
BEGIN
	INSERT INTO Usuario VALUES(
	@NombreUsuario, 
	@Contraseña, 
	@PrimerNombre, 
	@OtrosNombres, 
	@PrimerApellido, 
	@SegundoApellido, 
	@FechaNacimiento, 
	@Ocupacion, 
	@Estado, 
	@TipoUsuario, 
	(SELECT SYSDATETIME()),
	@Foto)
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistrarVisita]    Script Date: 6/17/2016 2:04:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistrarVisita] 
@idMedico INT,
@FechaVisita DATETIME,
@Sintomas VARCHAR(MAX),
@idMedicamento INT,
@Recomendaciones VARCHAR(MAX),
@Estado VARCHAR(MAX),
@idPaciente INT
AS
BEGIN
	INSERT INTO Registro_Visita VALUES(@idMedico, @FechaVisita, @FechaVisita, @Sintomas, @idMedicamento, @Recomendaciones, @Estado, @idPaciente, (SELECT SYSDATETIME()))
END;

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[50] 4[25] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 1
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Usuario"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 267
               Right = 225
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
      PaneHidden = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3240
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Usuario'
GO
USE [master]
GO
ALTER DATABASE [Dispensario] SET  READ_WRITE 
GO

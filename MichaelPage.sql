USE [master]
GO
/****** Object:  Database [AppMichaelPage]    Script Date: 20/12/2022 1:26:25 p. m. ******/
CREATE DATABASE [AppMichaelPage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AppMichaelPage', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AppMichaelPage.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AppMichaelPage_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AppMichaelPage_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AppMichaelPage] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AppMichaelPage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AppMichaelPage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AppMichaelPage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AppMichaelPage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AppMichaelPage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AppMichaelPage] SET ARITHABORT OFF 
GO
ALTER DATABASE [AppMichaelPage] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AppMichaelPage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AppMichaelPage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AppMichaelPage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AppMichaelPage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AppMichaelPage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AppMichaelPage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AppMichaelPage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AppMichaelPage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AppMichaelPage] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AppMichaelPage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AppMichaelPage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AppMichaelPage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AppMichaelPage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AppMichaelPage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AppMichaelPage] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AppMichaelPage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AppMichaelPage] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AppMichaelPage] SET  MULTI_USER 
GO
ALTER DATABASE [AppMichaelPage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AppMichaelPage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AppMichaelPage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AppMichaelPage] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AppMichaelPage] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AppMichaelPage] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [AppMichaelPage] SET QUERY_STORE = OFF
GO
USE [AppMichaelPage]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 20/12/2022 1:26:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[Identificador] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[NumeroIdentificacion] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[TipoIdentificacion] [varchar](50) NULL,
	[FechaDeCreacion] [datetime] NULL,
	[TipoConIdentificacion] [varchar](50) NULL,
	[NombreCompleto] [varchar](500) NULL,
	[Estado] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 20/12/2022 1:26:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Identificador] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Pass] [varchar](50) NULL,
	[FechaDeCreacion] [datetime] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([Identificador], [Nombres], [Apellidos], [NumeroIdentificacion], [Email], [TipoIdentificacion], [FechaDeCreacion], [TipoConIdentificacion], [NombreCompleto], [Estado]) VALUES (1, N'juan', N'gm', N'1214', N'sebas', N'cc', CAST(N'2022-12-19T17:01:08.667' AS DateTime), N'cc1214', N'jhongm', 0)
INSERT [dbo].[Persona] ([Identificador], [Nombres], [Apellidos], [NumeroIdentificacion], [Email], [TipoIdentificacion], [FechaDeCreacion], [TipoConIdentificacion], [NombreCompleto], [Estado]) VALUES (2, N'string', N'string', N'string', N'string', N'string', CAST(N'2022-12-20T05:01:24.490' AS DateTime), N'stringstring', N'stringstring', 0)
INSERT [dbo].[Persona] ([Identificador], [Nombres], [Apellidos], [NumeroIdentificacion], [Email], [TipoIdentificacion], [FechaDeCreacion], [TipoConIdentificacion], [NombreCompleto], [Estado]) VALUES (3, N'string', N'string', N'string', N'string', N'string', CAST(N'2022-12-20T16:43:35.607' AS DateTime), N'stringstring', N'stringstring', 0)
INSERT [dbo].[Persona] ([Identificador], [Nombres], [Apellidos], [NumeroIdentificacion], [Email], [TipoIdentificacion], [FechaDeCreacion], [TipoConIdentificacion], [NombreCompleto], [Estado]) VALUES (4, N'a', N'a', N'a', N'a', N'a', CAST(N'2022-12-19T00:00:00.000' AS DateTime), N'aa', N'a a', 1)
INSERT [dbo].[Persona] ([Identificador], [Nombres], [Apellidos], [NumeroIdentificacion], [Email], [TipoIdentificacion], [FechaDeCreacion], [TipoConIdentificacion], [NombreCompleto], [Estado]) VALUES (5, N'pedro', N'JUAN', N'984778', N'una', N'ccc', CAST(N'2022-12-20T00:00:00.000' AS DateTime), N'ccc984778', N'pedroJUAN', 19)
INSERT [dbo].[Persona] ([Identificador], [Nombres], [Apellidos], [NumeroIdentificacion], [Email], [TipoIdentificacion], [FechaDeCreacion], [TipoConIdentificacion], [NombreCompleto], [Estado]) VALUES (6, N'dfghjkfd', N'dfghjgfd', N'456788', N'dfghfd', N'5678', CAST(N'2022-12-20T00:00:00.000' AS DateTime), N'5678456788', N'dfghjkfddfghjgfd', 8)
INSERT [dbo].[Persona] ([Identificador], [Nombres], [Apellidos], [NumeroIdentificacion], [Email], [TipoIdentificacion], [FechaDeCreacion], [TipoConIdentificacion], [NombreCompleto], [Estado]) VALUES (7, N'pedro', N'niel ramirez', N'876589', N'asdasd', N'CC', CAST(N'2022-12-20T00:00:00.000' AS DateTime), N'CC876589', N'pedro niel ramirez', 1)
SET IDENTITY_INSERT [dbo].[Persona] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Identificador], [Usuario], [Pass], [FechaDeCreacion]) VALUES (1, N'jhongm', N'123', NULL)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
/****** Object:  StoredProcedure [dbo].[spActualizarPersona]    Script Date: 20/12/2022 1:26:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jhon Giraldo
-- Create date: 19/12/2022
-- Description:	Actualizar persona
-- =============================================
CREATE PROCEDURE [dbo].[spActualizarPersona]
 @Identificador int,
 @Nombres varchar(50),
 @Apellidos varchar(50),
 @NumeroIdentificacion varchar(50),
 @Email varchar(50),
 @TipoIdentificacion varchar(50),
 @FechaDeCreacion datetime,
 @TipoConIdentificacion varchar(50),
 @NombreCompleto varchar(500) ,
@Estado int
AS
BEGIN

   UPDATE [dbo].[Persona]
   SET [Nombres] = @Nombres
      ,[Apellidos] = @Apellidos
      ,[NumeroIdentificacion] = @NumeroIdentificacion
      ,[Email] = @Email
      ,[TipoIdentificacion] = @TipoIdentificacion
      ,[FechaDeCreacion] = @FechaDeCreacion
      ,[TipoConIdentificacion] = @TipoConIdentificacion
      ,[NombreCompleto] = @NombreCompleto
	   ,[Estado] = @Estado
	WHERE Identificador = @Identificador


END
GO
/****** Object:  StoredProcedure [dbo].[spConsultarPersonas]    Script Date: 20/12/2022 1:26:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Jhon Giraldo>
-- Create date: <19/12/2022>
-- Description:	<Consulta de personas>
-- =============================================
CREATE PROCEDURE [dbo].[spConsultarPersonas]
AS
BEGIN
	SELECT [Identificador]
      ,[Nombres]
      ,[Apellidos]
      ,[NumeroIdentificacion]
      ,[Email]
      ,[TipoIdentificacion]
      ,[FechaDeCreacion]
      ,[TipoConIdentificacion]
      ,[NombreCompleto]
      ,[Estado]
	  FROM [dbo].[Persona] WHERE Estado=0

END
GO
/****** Object:  StoredProcedure [dbo].[spConsultarPersonasIdentificador]    Script Date: 20/12/2022 1:26:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Jhon Giraldo>
-- Create date: <19/12/2022>
-- Description:	<Consulta de personas>
-- =============================================
CREATE PROCEDURE [dbo].[spConsultarPersonasIdentificador]
 @Identificador int
AS
BEGIN
	SELECT [Identificador]
      ,[Nombres]
      ,[Apellidos]
      ,[NumeroIdentificacion]
      ,[Email]
      ,[TipoIdentificacion]
      ,[FechaDeCreacion]
      ,[TipoConIdentificacion]
      ,[NombreCompleto]
      ,[Estado]
	  FROM [dbo].[Persona] WHERE [Identificador]=@Identificador

END
GO
/****** Object:  StoredProcedure [dbo].[spConsultarUsuario]    Script Date: 20/12/2022 1:26:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jhon Giraldo
-- Create date: <19/12/2022>
-- Description:	<Description>
-- =============================================
CREATE PROCEDURE [dbo].[spConsultarUsuario] 
	@usuario varchar(50),
	@pass varchar(50)
AS
BEGIN

SELECT [Identificador]
      ,[Usuario]
      ,[Pass]
  FROM [dbo].[Usuario] WHERE [Usuario] = @usuario AND [Pass] = @pass

END
GO
/****** Object:  StoredProcedure [dbo].[spConusltarUsuario]    Script Date: 20/12/2022 1:26:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jhon Giraldo
-- Create date: <19/12/2022>
-- Description:	<Description>
-- =============================================
CREATE PROCEDURE [dbo].[spConusltarUsuario] 
	@usuario varchar(50),
	@password varchar(50)
AS
BEGIN

SELECT [Identificador]
      ,[Usuario]
      ,[Pass]
  FROM [dbo].[Usuario] WHERE [Usuario] = @usuario AND [Pass] = @password

END
GO
/****** Object:  StoredProcedure [dbo].[spCrearPersona]    Script Date: 20/12/2022 1:26:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jhon giraldo
-- Create date: 19/12/2022
-- Description:	insert persona
-- =============================================
CREATE PROCEDURE [dbo].[spCrearPersona]
 
 @Nombres varchar(50),
 @Apellidos varchar(50),
 @NumeroIdentificacion varchar(50),
 @Email varchar(50),
 @TipoIdentificacion varchar(50),
 @FechaDeCreacion Datetime,
 @TipoConIdentificacion varchar(50),
 @NombreCompleto varchar(50),
 @Estado int,
 @Identificador int output 
AS
BEGIN

	INSERT INTO [dbo].[Persona]
			  ([Nombres]
           ,[Apellidos]
           ,[NumeroIdentificacion]
           ,[Email]
           ,[TipoIdentificacion]
           ,[FechaDeCreacion]
           ,[TipoConIdentificacion]
           ,[NombreCompleto]
           ,[Estado])
		 VALUES
			   (@Nombres
			   ,@Apellidos
			   ,@NumeroIdentificacion
			   ,@Email
			   ,@TipoIdentificacion
			   ,@FechaDeCreacion
			   ,@TipoConIdentificacion
			   ,@NombreCompleto
			   ,@Estado)

	select  @Identificador=@@IDENTITY

END
GO
USE [master]
GO
ALTER DATABASE [AppMichaelPage] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [GestaoAtividadeEscolar]    Script Date: 01/11/2023 21:54:18 ******/
CREATE DATABASE [GestaoAtividadeEscolar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestaoAtividadeEscolar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS2019\MSSQL\DATA\GestaoAtividadeEscolar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestaoAtividadeEscolar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS2019\MSSQL\DATA\GestaoAtividadeEscolar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestaoAtividadeEscolar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET  MULTI_USER 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET QUERY_STORE = OFF
GO
USE [GestaoAtividadeEscolar]
GO
/****** Object:  Table [dbo].[Atividade]    Script Date: 01/11/2023 21:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atividade](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](300) NOT NULL,
	[IdTurma] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professor]    Script Date: 01/11/2023 21:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[Usuario] [varchar](30) NOT NULL,
	[Senha] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProfessorTurma]    Script Date: 01/11/2023 21:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessorTurma](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProfessor] [int] NOT NULL,
	[IdTurma] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turma]    Script Date: 01/11/2023 21:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turma](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Atividade]  WITH CHECK ADD  CONSTRAINT [fk_TurmaAtividade] FOREIGN KEY([IdTurma])
REFERENCES [dbo].[Turma] ([Id])
GO
ALTER TABLE [dbo].[Atividade] CHECK CONSTRAINT [fk_TurmaAtividade]
GO
ALTER TABLE [dbo].[ProfessorTurma]  WITH CHECK ADD  CONSTRAINT [fk_Professor] FOREIGN KEY([IdProfessor])
REFERENCES [dbo].[Professor] ([Id])
GO
ALTER TABLE [dbo].[ProfessorTurma] CHECK CONSTRAINT [fk_Professor]
GO
ALTER TABLE [dbo].[ProfessorTurma]  WITH CHECK ADD  CONSTRAINT [fk_Turma] FOREIGN KEY([IdTurma])
REFERENCES [dbo].[Turma] ([Id])
GO
ALTER TABLE [dbo].[ProfessorTurma] CHECK CONSTRAINT [fk_Turma]
GO
USE [master]
GO
ALTER DATABASE [GestaoAtividadeEscolar] SET  READ_WRITE 
GO

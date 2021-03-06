USE [master]
GO

/****** Object:  Database [Ticket]    Script Date: 12.01.2022 21:22:35 ******/
CREATE DATABASE [Ticket]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ticket', FILENAME = N'C:\Program Files\Microsoft SQL Server\C\MSSQL15.SQLEXPRESS\MSSQL\DATA\Ticket.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ticket_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\C\MSSQL15.SQLEXPRESS\MSSQL\DATA\Ticket_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ticket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Ticket] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Ticket] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Ticket] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Ticket] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Ticket] SET ARITHABORT OFF 
GO

ALTER DATABASE [Ticket] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Ticket] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Ticket] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Ticket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Ticket] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Ticket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Ticket] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Ticket] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Ticket] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Ticket] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Ticket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Ticket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Ticket] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Ticket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Ticket] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Ticket] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Ticket] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Ticket] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Ticket] SET  MULTI_USER 
GO

ALTER DATABASE [Ticket] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Ticket] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Ticket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Ticket] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Ticket] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Ticket] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Ticket] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Ticket] SET  READ_WRITE 
GO


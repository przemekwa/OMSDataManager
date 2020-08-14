USE [master]
GO

/****** Object:  Database [SelgrosMainDB_OMS]    Script Date: 14.08.2020 08:15:54 ******/
CREATE DATABASE [SelgrosMainDB_OMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SelgrosMainDb_OMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SelgrosMainDB_OMS.mdf' , SIZE = 1267520KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SelgrosMainDb_log_OMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SelgrosMainDB_log_OMS.ldf' , SIZE = 512KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SelgrosMainDB_OMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET ARITHABORT OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET  DISABLE_BROKER 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET  MULTI_USER 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET DB_CHAINING OFF 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET QUERY_STORE = OFF
GO

ALTER DATABASE [SelgrosMainDB_OMS] SET  READ_WRITE 
GO


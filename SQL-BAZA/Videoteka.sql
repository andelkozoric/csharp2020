USE [master]
GO
/****** Object:  Database [videoteka]    Script Date: 25.3.2020. 21:28:35 ******/
CREATE DATABASE [videoteka]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'videoteka', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\videoteka.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'videoteka_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\videoteka_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [videoteka] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [videoteka].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [videoteka] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [videoteka] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [videoteka] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [videoteka] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [videoteka] SET ARITHABORT OFF 
GO
ALTER DATABASE [videoteka] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [videoteka] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [videoteka] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [videoteka] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [videoteka] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [videoteka] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [videoteka] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [videoteka] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [videoteka] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [videoteka] SET  DISABLE_BROKER 
GO
ALTER DATABASE [videoteka] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [videoteka] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [videoteka] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [videoteka] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [videoteka] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [videoteka] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [videoteka] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [videoteka] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [videoteka] SET  MULTI_USER 
GO
ALTER DATABASE [videoteka] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [videoteka] SET DB_CHAINING OFF 
GO
ALTER DATABASE [videoteka] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [videoteka] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [videoteka] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [videoteka] SET QUERY_STORE = OFF
GO
USE [videoteka]
GO
/****** Object:  Table [dbo].[Prijatelji]    Script Date: 25.3.2020. 21:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prijatelji](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](50) NOT NULL,
	[prezime] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Prijatelji] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mediji]    Script Date: 25.3.2020. 21:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mediji](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](120) NOT NULL,
	[vrsta] [bit] NOT NULL,
 CONSTRAINT [PK_Mediji] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evidencije]    Script Date: 25.3.2020. 21:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evidencije](
	[prijatelji_id] [int] NOT NULL,
	[mediji_id] [int] NOT NULL,
	[datum_posudbe] [date] NOT NULL,
	[datum_vracanja] [date] NULL,
 CONSTRAINT [PK_Evidencije] PRIMARY KEY CLUSTERED 
(
	[prijatelji_id] ASC,
	[mediji_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_nevraceni]    Script Date: 25.3.2020. 21:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_nevraceni]
AS
SELECT dbo.Mediji.naziv, dbo.Mediji.vrsta, dbo.Evidencije.prijatelji_id, dbo.Evidencije.mediji_id, dbo.Prijatelji.ime, dbo.Prijatelji.prezime, dbo.Evidencije.datum_vracanja, dbo.Evidencije.datum_posudbe, DATEDIFF(day, dbo.Evidencije.datum_posudbe, SYSDATETIME()) AS dani
FROM   dbo.Mediji INNER JOIN
             dbo.Evidencije ON dbo.Mediji.id = dbo.Evidencije.mediji_id INNER JOIN
             dbo.Prijatelji ON dbo.Prijatelji.id = dbo.Evidencije.prijatelji_id
WHERE (dbo.Evidencije.datum_vracanja IS NULL)
GO
INSERT [dbo].[Evidencije] ([prijatelji_id], [mediji_id], [datum_posudbe], [datum_vracanja]) VALUES (1, 1, CAST(N'2020-03-14' AS Date), CAST(N'2020-03-25' AS Date))
INSERT [dbo].[Evidencije] ([prijatelji_id], [mediji_id], [datum_posudbe], [datum_vracanja]) VALUES (1, 2, CAST(N'2020-03-10' AS Date), CAST(N'2020-03-25' AS Date))
INSERT [dbo].[Evidencije] ([prijatelji_id], [mediji_id], [datum_posudbe], [datum_vracanja]) VALUES (2, 2, CAST(N'2020-03-05' AS Date), CAST(N'2020-03-25' AS Date))
SET IDENTITY_INSERT [dbo].[Mediji] ON 

INSERT [dbo].[Mediji] ([id], [naziv], [vrsta]) VALUES (1, N'LOTR', 0)
INSERT [dbo].[Mediji] ([id], [naziv], [vrsta]) VALUES (2, N'Novi fosili', 1)
INSERT [dbo].[Mediji] ([id], [naziv], [vrsta]) VALUES (3, N'Metallica', 1)
INSERT [dbo].[Mediji] ([id], [naziv], [vrsta]) VALUES (4, N'Queen', 1)
INSERT [dbo].[Mediji] ([id], [naziv], [vrsta]) VALUES (5, N'Armagedon', 0)
SET IDENTITY_INSERT [dbo].[Mediji] OFF
SET IDENTITY_INSERT [dbo].[Prijatelji] ON 

INSERT [dbo].[Prijatelji] ([id], [ime], [prezime]) VALUES (1, N'Iva', N'Soldo')
INSERT [dbo].[Prijatelji] ([id], [ime], [prezime]) VALUES (2, N'Marija', N'Filipovic')
INSERT [dbo].[Prijatelji] ([id], [ime], [prezime]) VALUES (3, N'Suzana', N'Modric')
INSERT [dbo].[Prijatelji] ([id], [ime], [prezime]) VALUES (4, N'Goran', N'Radic')
SET IDENTITY_INSERT [dbo].[Prijatelji] OFF
ALTER TABLE [dbo].[Evidencije]  WITH CHECK ADD  CONSTRAINT [FK_Evidencije_Mediji] FOREIGN KEY([mediji_id])
REFERENCES [dbo].[Mediji] ([id])
GO
ALTER TABLE [dbo].[Evidencije] CHECK CONSTRAINT [FK_Evidencije_Mediji]
GO
ALTER TABLE [dbo].[Evidencije]  WITH CHECK ADD  CONSTRAINT [FK_Evidencije_Prijatelji] FOREIGN KEY([prijatelji_id])
REFERENCES [dbo].[Prijatelji] ([id])
GO
ALTER TABLE [dbo].[Evidencije] CHECK CONSTRAINT [FK_Evidencije_Prijatelji]
GO
/****** Object:  StoredProcedure [dbo].[Vrati_sve_posudjeno]    Script Date: 25.3.2020. 21:28:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Vrati_sve_posudjeno]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Evidencije
SET datum_vracanja = CURRENT_TIMESTAMP
WHERE datum_vracanja IS NULL
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'mediji' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Evidencije', @level2type=N'CONSTRAINT',@level2name=N'FK_Evidencije_Mediji'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DVD=0 CD=1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Mediji', @level2type=N'COLUMN',@level2name=N'vrsta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[32] 4[28] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
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
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Mediji"
            Begin Extent = 
               Top = 29
               Left = 28
               Bottom = 242
               Right = 266
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Evidencije"
            Begin Extent = 
               Top = 85
               Left = 308
               Bottom = 356
               Right = 542
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Prijatelji"
            Begin Extent = 
               Top = 30
               Left = 639
               Bottom = 200
               Right = 861
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1490
         Width = 1260
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 6880
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_nevraceni'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_nevraceni'
GO
USE [master]
GO
ALTER DATABASE [videoteka] SET  READ_WRITE 
GO

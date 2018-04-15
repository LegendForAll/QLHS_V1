
USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLHS_V1')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLHS_V1') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLHS_V1]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLHS_V1]
GO

USE [QLHS_V1]
GO

/****** Object:  Table [dbo].[tbl_Gender]    Script Date: 4/15/2018 8:08:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Gender](
	[ID_Gender] [int] NOT NULL,
	[Gender] [nchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Gender] PRIMARY KEY CLUSTERED 
(
	[ID_Gender] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[tbl_Student]    Script Date: 4/15/2018 8:21:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Student](
	[id_Student] [nchar](10) NOT NULL,
	[ID_Gender] [int] NOT NULL,
	[student_name] [nchar](50) NOT NULL,
	[brithday] [datetime2](7) NOT NULL,
	[address] [nchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Student] PRIMARY KEY CLUSTERED 
(
	[id_Student] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLHS_V1]
GO

INSERT INTO[dbo].[tbl_Gender]([ID_Gender],[Gender]) VALUES(0,N'Male')
GO
INSERT INTO[dbo].[tbl_Gender]([ID_Gender],[Gender]) VALUES(2,N'Female')
GO
INSERT INTO[dbo].[tbl_Gender]([ID_Gender],[Gender]) VALUES(3,N'Other')
GO


USE [QLHS_V1]
GO


INSERT INTO [dbo].[tbl_Student]([id_Student],[ID_Gender],[student_name],[address],[brithday]) VALUES(N'16000001',0,N'Nguyễn Văn An',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2017 00:00:00',101))
GO
INSERT INTO [dbo].[tbl_Student]([id_Student],[ID_Gender],[student_name],[address],[brithday]) VALUES(N'16000002',1,N'Nguyễn Văn Huy',N'1 Cống Quỳnh, Quận 1, TP HCM',convert(datetime,'12/30/2017 00:00:00',101))
GO
INSERT INTO [dbo].[tbl_Student]([id_Student],[ID_Gender],[student_name],[address],[brithday]) VALUES(N'16000003',1,N'Nguyễn Văn Tùng',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2017 00:00:00',101))
GO
INSERT INTO [dbo].[tbl_Student]([id_Student],[ID_Gender],[student_name],[address],[brithday]) VALUES(N'16000004',0,N'Nguyễn Quang Minh',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2017 00:00:00',101))
GO
INSERT INTO [dbo].[tbl_Student]([id_Student],[ID_Gender],[student_name],[address],[brithday]) VALUES(N'16000005',1,N'Nguyễn Nhật Trường',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2017 00:00:00',101))
GO

USE [QLHS_V1]
GO

/****** Object:  Table [dbo].[tbl_semester]    Script Date: 4/15/2018 8:51:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_semester](
	[id_semester] [int] NOT NULL,
	[name_semester] [nchar](50) NOT NULL,
	[order_semester] [int] NOT NULL,
	[id_year_semester] [int] NOT NULL,
 CONSTRAINT [PK_tbl_semester] PRIMARY KEY CLUSTERED 
(
	[id_semester] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLHS_V1]
GO

/****** Object:  Table [dbo].[tbl_grade]    Script Date: 4/15/2018 8:55:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_grade](
	[id_grade] [int] NOT NULL,
	[name_grade] [nchar](50) NOT NULL,
	[order_grade] [int] NOT NULL,
 CONSTRAINT [PK_tbl_grade] PRIMARY KEY CLUSTERED 
(
	[id_grade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLHS_V1]
GO

/****** Object:  Table [dbo].[tbl_CLASS]    Script Date: 4/15/2018 10:32:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_CLASS](
	[id_CLASS] [int] NOT NULL,
	[name_CLASS] [nchar](50) NOT NULL,
	[id_grade] [int] NOT NULL,
	[id_semester] [int] NOT NULL,
 CONSTRAINT [PK_tbl_CLASS] PRIMARY KEY CLUSTERED 
(
	[id_CLASS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLHS_V1]
GO

/****** Object:  Table [dbo].[tbl_StudentCLASS]    Script Date: 4/15/2018 10:42:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_StudentCLASS](
	[id_Student] [int] NOT NULL,
	[id_CLASS] [int] NOT NULL,
 CONSTRAINT [PK_tbl_StudentCLASS] PRIMARY KEY CLUSTERED 
(
	[id_Student] ASC,
	[id_CLASS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

--ALTER TABLE [dbo].[tbl_StudentCLASS]  WITH CHECK ADD  CONSTRAINT [FK_tbl_StudentCLASS_tbl_StudentCLASS] FOREIGN KEY([id_Student])
--REFERENCES [dbo].[tbl_StudentCLASS] ([id_Student])
--GO
--ALTER TABLE [dbo].[tbl_StudentCLASS]  WITH CHECK ADD  CONSTRAINT [FK_tbl_StudentCLASS_tbl_StudentCLASS] FOREIGN KEY([id_CLASS])
--REFERENCES [dbo].[tbl_StudentCLASS] ([id_CLASS])
--GO
--ALTER TABLE [dbo].[tbl_StudentCLASS] CHECK CONSTRAINT [FK_tbl_StudentCLASS_tbl_StudentCLASS]
--GO


USE [QLHS_V1]
GO

/****** Object:  Table [dbo].[tbl_year]    Script Date: 4/15/2018 10:47:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_year](
	[id_year_semester] [int] NOT NULL,
	[name_year] [nchar](50) NOT NULL,
	[other_year] [int] NOT NULL,
 CONSTRAINT [PK_tbl_year] PRIMARY KEY CLUSTERED 
(
	[id_year_semester] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLHS_V1]
GO

/****** Object:  Table [dbo].[tbl_regulations]    Script Date: 4/15/2018 10:52:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_regulations](
	[id_regulations] [int] NOT NULL,
	[grade_max] [int] NOT NULL,
	[semester_max] [int] NOT NULL,
	--[CLASS_max] [int] NOT NULL,
	[Age_max] [int] NOT NULL,
	[Age_min] [int] NOT NULL,
 CONSTRAINT [PK_tbl_regulations] PRIMARY KEY CLUSTERED 
(
	[id_regulations] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLHS_V1]
GO

INSERT INTO [dbo].[tbl_year]
           ([id_year_semester]
           ,[name_year]
		   ,[other_year])
     VALUES
           (1
           ,N'2014-2015',
		   1)
GO
INSERT INTO [dbo].[tbl_year]
           ([id_year_semester]
           ,[name_year]
		   ,[other_year])
     VALUES
           (2
           ,N'2015-2016',
		   2)
GO
INSERT INTO [dbo].[tbl_year]
           ([id_year_semester]
           ,[name_year]
		   ,[other_year])
     VALUES
           (3
           ,N'2016-2017'
		   ,3)
GO
INSERT INTO [dbo].[tbl_year]
           ([id_year_semester]
           ,[name_year]
		   ,[other_year])
     VALUES
           (4
           ,N'2017-2018',
		   4)
GO

USE [QLHS_V1]
GO

INSERT INTO [dbo].[tbl_semester]
           ([name_semester]
           ,[id_semester]
		   ,[order_semester]
           ,[id_year_semester])
     VALUES
           (N'Học Kỳ I'
           ,1
		   ,1
           ,1)
GO

INSERT INTO [dbo].[tbl_semester]
           ([name_semester]
           ,[id_semester]
		   ,[order_semester]
           ,[id_year_semester])
     VALUES
           (N'Học Kỳ 2'
           ,2
		   ,2
           ,1)
GO

INSERT INTO [dbo].[tbl_semester]
           ([name_semester]
           ,[id_semester]
		   ,[order_semester]
           ,[id_year_semester])
     VALUES
           (N'Học Kỳ I'
           ,3
		   ,1
           ,2)
GO

INSERT INTO [dbo].[tbl_semester]
           ([name_semester]
           ,[id_semester]
		   ,[order_semester]
           ,[id_year_semester])
     VALUES
           (N'Học Kỳ 2'
           ,4
		   ,2
           ,2)
GO

INSERT INTO[dbo].[tbl_semester]
           ([name_semester]
           ,[id_semester]
		   ,[order_semester]
           ,[id_year_semester])
     VALUES
           (N'Học Kỳ I'
           ,5
		   ,1
           ,3)
GO

INSERT INTO [dbo].[tbl_semester]
           ([name_semester]
           ,[id_semester]
		   ,[order_semester]
           ,[id_year_semester])
     VALUES
           (N'Học Kỳ 2'
           ,6
		   ,2
           ,3)
GO

INSERT INTO [dbo].[tbl_semester]
           ([name_semester]
           ,[id_semester]
		   ,[order_semester]
           ,[id_year_semester])
     VALUES
           (N'Học Kỳ I'
           ,7
		   ,1
           ,4)
GO

INSERT INTO [dbo].[tbl_semester]
           ([name_semester]
           ,[id_semester]
		   ,[order_semester]
           ,[id_year_semester])
     VALUES
           (N'Học Kỳ 2'
           ,8
		   ,2
           ,4)
GO

USE [QLHS_V1]
GO

INSERT INTO [dbo].[tbl_grade]
           ([id_grade]
           ,[name_grade]
		   ,[order_grade])
     VALUES
           (1
           ,N'Khối 10'
		   ,1)
GO

INSERT INTO [dbo].[tbl_grade]
           ([id_grade]
           ,[name_grade]
		   ,[order_grade])
     VALUES
           (2
           ,N'Khối 11'
		   ,2)
GO

INSERT INTO [dbo].[tbl_grade]
           ([id_grade]
           ,[name_grade]
		   ,[order_grade])
     VALUES
           (3
           ,N'Khối 12'
		   ,3)
GO

USE [QLHS_V1]
GO

INSERT INTO [dbo].[tbl_CLASS]
           ([id_CLASS]
           ,[name_CLASS]
		   ,[id_semester]
           ,[id_grade])
     VALUES
           (1
           ,N'10A1'
		   ,1
           ,1)
GO

INSERT INTO [dbo].[tbl_CLASS]
           ([id_CLASS]
           ,[name_CLASS]
		   ,[id_semester]
           ,[id_grade])
     VALUES
           (2
           ,N'10A2'
		   ,1
           ,1)
GO

INSERT INTO [dbo].[tbl_CLASS]
           ([id_CLASS]
           ,[name_CLASS]
		   ,[id_semester]
           ,[id_grade])
     VALUES
           (3
           ,N'11A1'
		   ,1
           ,2)
GO

INSERT INTO [dbo].[tbl_CLASS]
           ([id_CLASS]
           ,[name_CLASS]
		   ,[id_semester]
           ,[id_grade])
     VALUES
           (4
           ,N'11A2'
		   ,1
           ,2)
GO

INSERT INTO[dbo].[tbl_CLASS]
           ([id_CLASS]
           ,[name_CLASS]
		   ,[id_semester]
           ,[id_grade])
     VALUES
           (5
           ,N'12A1'
		   ,1
           ,3)
GO

INSERT INTO [dbo].[tbl_CLASS]
           ([id_CLASS]
           ,[name_CLASS]
		   ,[id_semester]
           ,[id_grade])
     VALUES
           (6
           ,N'12A2'
		   ,1
           ,3)
GO

USE [QLHS_V1]
GO

INSERT INTO [dbo].[tbl_StudentCLASS]
           ([id_Student]
           ,[id_CLASS])

     VALUES
           (N'14000001'
           ,5)
GO

INSERT INTO [dbo].[tbl_StudentCLASS]
           ([id_Student]
           ,[id_CLASS])
		   
     VALUES
           (N'14000002'
           ,5)
GO

INSERT INTO [dbo].[tbl_StudentCLASS]
           ([id_Student]
           ,[id_CLASS])
		   
     VALUES
           (N'14000003'
           ,6)
GO

INSERT INTO[dbo].[tbl_StudentCLASS]
           ([id_Student]
           ,[id_CLASS])
     VALUES
           (N'14000004'
           ,6)
GO
INSERT INTO [dbo].[tbl_StudentCLASS]
           ([id_Student]
           ,[id_CLASS])
     VALUES
           (N'14000005'
           ,6)
GO

USE [QLHS_V1]
GO

INSERT INTO [dbo].[tbl_regulations]
           ([id_regulations]
		   ,[grade_max]
           ,[semester_max]
		   ,[Age_min]
		   ,[Age_max])
     VALUES
           (1
		   ,3
           ,3
		   ,15
		   ,20)
GO

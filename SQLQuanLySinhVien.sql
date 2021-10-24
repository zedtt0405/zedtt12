USE master
IF EXISTS(select * from sys.databases where name='QuanLySinhVien')
DROP DATABASE QuanLySinhVien

CREATE DATABASE QuanLySinhVien
GO

USE [QuanLySinhVien]
GO
/****** Object: Table [dbo].[Student] Script Date: 08/13/2019 23:16:37
******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [nvarchar](20) NOT NULL,
	[FullName] [nvarchar](200) NULL,
	[AverageScore] [float] NULL,
	[FacultyID] [int] NULL,
	CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED
	(
		[StudentID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY =
		OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
GO

/****** Object: Table [dbo].[Falculty] Script Date: 08/13/2019
23:16:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Falculty](
	[FacultyID] [int] NOT NULL,
	[FacultyName] [nvarchar](200) NULL,
	CONSTRAINT [PK_Falculty] PRIMARY KEY CLUSTERED
	(
		[FacultyID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY =
	OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
GO

insert into [dbo].[Falculty] values(1,N'Công Nghệ Thông Tin')
insert into [dbo].[Falculty] values(2,N'Điện Tử')
insert into [dbo].[Falculty] values(3,N'Kinh Tế')
insert into [dbo].[Falculty] values(4,N'Anh Văn')
GO

select * from Falculty
GO

insert into [dbo].[Student] values(N'SV01',N'PHẠM ĐÀO MINH VŨ','7.8',1)
insert into [dbo].[Student] values(N'SV02',N'VÕ TẤN DŨNG','6.3',2)
insert into [dbo].[Student] values(N'SV03',N'DƯƠNG THÀNH PHẾT','6.5',1)
insert into [dbo].[Student] values(N'SV04',N'VŨ THANH HIỀN','8.0',3)
insert into [dbo].[Student] values(N'SV05',N'TRẦN MINH THÁI','4.6',4)
insert into [dbo].[Student] values(N'SV06',N'LÊ VĂN HẠNH','7.5',1)
insert into [dbo].[Student] values(N'SV07',N'NGUYỄN THỊ TRANG','6.8',2)
GO

SELECT * FROM Student
GO

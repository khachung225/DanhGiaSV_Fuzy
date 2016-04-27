SET NOCOUNT ON
GO
USE [DIEMRENLUYEN]
GO
 

/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 04/28/2016 00:34:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GIAOVIEN]') AND type in (N'U'))
DROP TABLE [dbo].[GIAOVIEN]
GO
 

/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 04/28/2016 00:34:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GIAOVIEN](
	[MaGv] [nvarchar](50) NOT NULL,
	[TenGiaoVien] [nvarchar](100) NOT NULL,
	[Sex] [int] NOT NULL,
	[Adress] [nvarchar](150) NOT NULL,
	[UserLogin] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_GIAOVIEN] PRIMARY KEY CLUSTERED 
(
	[MaGv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAOVIEN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAOVIEN_Insert]
GO
CREATE PROCEDURE [dbo].[GIAOVIEN_Insert]
	@MaGv int output,
	@TenGiaoVien nvarchar(100) ,
	@Sex int ,
	@Adress nvarchar(150) ,
	@UserLogin nvarchar(50) ,
	@Password nvarchar(50) 

AS

INSERT [dbo].[GIAOVIEN]
(
	[TenGiaoVien],
	[Sex],
	[Adress],
	[UserLogin],
	[Password]

)
VALUES
(
	@TenGiaoVien,
	@Sex,
	@Adress,
	@UserLogin,
	@Password

)
	SELECT @MaGv=SCOPE_IDENTITY();


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAOVIEN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAOVIEN_Update]
GO
CREATE PROCEDURE [dbo].[GIAOVIEN_Update]
	@MaGv int,
	@TenGiaoVien nvarchar(100),
	@Sex int,
	@Adress nvarchar(150),
	@UserLogin nvarchar(50),
	@Password nvarchar(50)

AS

UPDATE [dbo].[GIAOVIEN]
SET
	[TenGiaoVien] = @TenGiaoVien,
	[Sex] = @Sex,
	[Adress] = @Adress,
	[UserLogin] = @UserLogin,
	[Password] = @Password
 WHERE 
	[MaGv] = @MaGv

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAOVIEN_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAOVIEN_SelectByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[GIAOVIEN_SelectByPrimaryKey]
	@MaGv int
AS

	SELECT 
		[MaGv], [TenGiaoVien], [Sex], [Adress], [UserLogin], [Password]
	FROM [dbo].[GIAOVIEN]
	WHERE 
			[MaGv] = @MaGv

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAOVIEN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAOVIEN_SelectAll]
GO
CREATE PROCEDURE [dbo].[GIAOVIEN_SelectAll]
AS

	SELECT 
		[MaGv], [TenGiaoVien], [Sex], [Adress], [UserLogin], [Password]
	FROM [dbo].[GIAOVIEN]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAOVIEN_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAOVIEN_SelectByField]
GO
CREATE PROCEDURE [dbo].[GIAOVIEN_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [MaGv], [TenGiaoVien], [Sex], [Adress], [UserLogin], [Password] FROM [dbo].[GIAOVIEN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAOVIEN_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAOVIEN_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[GIAOVIEN_DeleteByPrimaryKey]
	@MaGv int
AS

DELETE FROM [dbo].[GIAOVIEN]
 WHERE 
	[MaGv] = @MaGv

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAOVIEN_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAOVIEN_DeleteByField]
GO
CREATE PROCEDURE [dbo].[GIAOVIEN_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[GIAOVIEN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

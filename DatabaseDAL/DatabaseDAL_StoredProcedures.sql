SET NOCOUNT ON
GO
USE [DIEMRENLUYEN]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KETQUADANHGIA_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KETQUADANHGIA_Insert]
GO
CREATE PROCEDURE [dbo].[KETQUADANHGIA_Insert]
	@MASV nvarchar(50) = null ,
	@MASVDANHGIA nvarchar(50) = null ,
	@TC11 smallint = null ,
	@TC12 smallint = null ,
	@TC13 smallint = null ,
	@TC21 smallint = null ,
	@TC22 smallint = null ,
	@TC31 smallint = null ,
	@TC32 smallint = null ,
	@TC33 smallint = null ,
	@TC41 smallint = null ,
	@TC42 smallint = null ,
	@TC43 smallint = null ,
	@TC51 smallint = null ,
	@TC52 smallint = null ,
	@TC53 smallint = null 

AS

INSERT [dbo].[KETQUADANHGIA]
(
	[MASV],
	[MASVDANHGIA],
	[TC11],
	[TC12],
	[TC13],
	[TC21],
	[TC22],
	[TC31],
	[TC32],
	[TC33],
	[TC41],
	[TC42],
	[TC43],
	[TC51],
	[TC52],
	[TC53]

)
VALUES
(
	@MASV,
	@MASVDANHGIA,
	@TC11,
	@TC12,
	@TC13,
	@TC21,
	@TC22,
	@TC31,
	@TC32,
	@TC33,
	@TC41,
	@TC42,
	@TC43,
	@TC51,
	@TC52,
	@TC53

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KETQUADANHGIA_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KETQUADANHGIA_Update]
GO
CREATE PROCEDURE [dbo].[KETQUADANHGIA_Update]
	@MASV nvarchar(50) = null,
	@MASVDANHGIA nvarchar(50) = null,
	@TC11 smallint = null,
	@TC12 smallint = null,
	@TC13 smallint = null,
	@TC21 smallint = null,
	@TC22 smallint = null,
	@TC31 smallint = null,
	@TC32 smallint = null,
	@TC33 smallint = null,
	@TC41 smallint = null,
	@TC42 smallint = null,
	@TC43 smallint = null,
	@TC51 smallint = null,
	@TC52 smallint = null,
	@TC53 smallint = null

AS

UPDATE [dbo].[KETQUADANHGIA]
SET
	[MASV] = @MASV,
	[MASVDANHGIA] = @MASVDANHGIA,
	[TC11] = @TC11,
	[TC12] = @TC12,
	[TC13] = @TC13,
	[TC21] = @TC21,
	[TC22] = @TC22,
	[TC31] = @TC31,
	[TC32] = @TC32,
	[TC33] = @TC33,
	[TC41] = @TC41,
	[TC42] = @TC42,
	[TC43] = @TC43,
	[TC51] = @TC51,
	[TC52] = @TC52,
	[TC53] = @TC53
 WHERE 


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KETQUADANHGIA_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KETQUADANHGIA_SelectAll]
GO
CREATE PROCEDURE [dbo].[KETQUADANHGIA_SelectAll]
AS

	SELECT 
		[MASV], [MASVDANHGIA], [TC11], [TC12], [TC13], [TC21], [TC22], [TC31], [TC32], [TC33], [TC41], [TC42], [TC43], [TC51], [TC52], [TC53]
	FROM [dbo].[KETQUADANHGIA]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KETQUADANHGIA_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KETQUADANHGIA_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KETQUADANHGIA_DeleteByPrimaryKey]

AS

DELETE FROM [dbo].[KETQUADANHGIA]
 WHERE 


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KETQUARENLUYEN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KETQUARENLUYEN_Insert]
GO
CREATE PROCEDURE [dbo].[KETQUARENLUYEN_Insert]
	@MASV nvarchar(50) ,
	@HOTEN nvarchar(200) ,
	@KETQUA nvarchar(150) = null ,
	@XEPLOAI nvarchar(50) = null 

AS

INSERT [dbo].[KETQUARENLUYEN]
(
	[MASV],
	[HOTEN],
	[KETQUA],
	[XEPLOAI]

)
VALUES
(
	@MASV,
	@HOTEN,
	@KETQUA,
	@XEPLOAI

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KETQUARENLUYEN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KETQUARENLUYEN_Update]
GO
CREATE PROCEDURE [dbo].[KETQUARENLUYEN_Update]
	@MASV nvarchar(50),
	@HOTEN nvarchar(200),
	@KETQUA nvarchar(150) = null,
	@XEPLOAI nvarchar(50) = null

AS

UPDATE [dbo].[KETQUARENLUYEN]
SET
	[MASV] = @MASV,
	[HOTEN] = @HOTEN,
	[KETQUA] = @KETQUA,
	[XEPLOAI] = @XEPLOAI
 WHERE 
	[MASV] = @MASV

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KETQUARENLUYEN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KETQUARENLUYEN_SelectAll]
GO
CREATE PROCEDURE [dbo].[KETQUARENLUYEN_SelectAll]
AS

	SELECT 
		[MASV], [HOTEN], [KETQUA], [XEPLOAI]
	FROM [dbo].[KETQUARENLUYEN]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KETQUARENLUYEN_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KETQUARENLUYEN_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KETQUARENLUYEN_DeleteByPrimaryKey]
	@MASV nvarchar(50)
AS

DELETE FROM [dbo].[KETQUARENLUYEN]
 WHERE 
	[MASV] = @MASV

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHANDANHGIA_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHANDANHGIA_Insert]
GO
CREATE PROCEDURE [dbo].[NHANDANHGIA_Insert]
	@MALOAI smallint ,
	@TENLOAI nvarchar(150) = null ,
	@P1 float = null ,
	@P2 float = null ,
	@P3 float = null 

AS

INSERT [dbo].[NHANDANHGIA]
(
	[MALOAI],
	[TENLOAI],
	[P1],
	[P2],
	[P3]

)
VALUES
(
	@MALOAI,
	@TENLOAI,
	@P1,
	@P2,
	@P3

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHANDANHGIA_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHANDANHGIA_Update]
GO
CREATE PROCEDURE [dbo].[NHANDANHGIA_Update]
	@MALOAI smallint,
	@TENLOAI nvarchar(150) = null,
	@P1 float = null,
	@P2 float = null,
	@P3 float = null

AS

UPDATE [dbo].[NHANDANHGIA]
SET
	[MALOAI] = @MALOAI,
	[TENLOAI] = @TENLOAI,
	[P1] = @P1,
	[P2] = @P2,
	[P3] = @P3
 WHERE 
	[MALOAI] = @MALOAI

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHANDANHGIA_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHANDANHGIA_SelectAll]
GO
CREATE PROCEDURE [dbo].[NHANDANHGIA_SelectAll]
AS

	SELECT 
		[MALOAI], [TENLOAI], [P1], [P2], [P3]
	FROM [dbo].[NHANDANHGIA]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHANDANHGIA_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHANDANHGIA_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[NHANDANHGIA_DeleteByPrimaryKey]
	@MALOAI smallint
AS

DELETE FROM [dbo].[NHANDANHGIA]
 WHERE 
	[MALOAI] = @MALOAI

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SINHVIEN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SINHVIEN_Insert]
GO
CREATE PROCEDURE [dbo].[SINHVIEN_Insert]
	@MASV nvarchar(50) ,
	@HOTEN nvarchar(250) = null 

AS

INSERT [dbo].[SINHVIEN]
(
	[MASV],
	[HOTEN]

)
VALUES
(
	@MASV,
	@HOTEN

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SINHVIEN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SINHVIEN_Update]
GO
CREATE PROCEDURE [dbo].[SINHVIEN_Update]
	@MASV nvarchar(50),
	@HOTEN nvarchar(250) = null

AS

UPDATE [dbo].[SINHVIEN]
SET
	[MASV] = @MASV,
	[HOTEN] = @HOTEN
 WHERE 
	[MASV] = @MASV

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SINHVIEN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SINHVIEN_SelectAll]
GO
CREATE PROCEDURE [dbo].[SINHVIEN_SelectAll]
AS

	SELECT 
		[MASV], [HOTEN]
	FROM [dbo].[SINHVIEN]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SINHVIEN_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[SINHVIEN_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[SINHVIEN_DeleteByPrimaryKey]
	@MASV nvarchar(50)
AS

DELETE FROM [dbo].[SINHVIEN]
 WHERE 
	[MASV] = @MASV

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TIEUCHUAN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[TIEUCHUAN_Insert]
GO
CREATE PROCEDURE [dbo].[TIEUCHUAN_Insert]
	@MATIECHUAN int ,
	@TENTIEUCHUAN nvarchar(50) = null ,
	@P1 float = null ,
	@P2 float = null ,
	@P3 float = null 

AS

INSERT [dbo].[TIEUCHUAN]
(
	[MATIECHUAN],
	[TENTIEUCHUAN],
	[P1],
	[P2],
	[P3]

)
VALUES
(
	@MATIECHUAN,
	@TENTIEUCHUAN,
	@P1,
	@P2,
	@P3

)


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TIEUCHUAN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[TIEUCHUAN_Update]
GO
CREATE PROCEDURE [dbo].[TIEUCHUAN_Update]
	@MATIECHUAN int,
	@TENTIEUCHUAN nvarchar(50) = null,
	@P1 float = null,
	@P2 float = null,
	@P3 float = null

AS

UPDATE [dbo].[TIEUCHUAN]
SET
	[MATIECHUAN] = @MATIECHUAN,
	[TENTIEUCHUAN] = @TENTIEUCHUAN,
	[P1] = @P1,
	[P2] = @P2,
	[P3] = @P3
 WHERE 
	[MATIECHUAN] = @MATIECHUAN

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TIEUCHUAN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[TIEUCHUAN_SelectAll]
GO
CREATE PROCEDURE [dbo].[TIEUCHUAN_SelectAll]
AS

	SELECT 
		[MATIECHUAN], [TENTIEUCHUAN], [P1], [P2], [P3]
	FROM [dbo].[TIEUCHUAN]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TIEUCHUAN_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[TIEUCHUAN_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[TIEUCHUAN_DeleteByPrimaryKey]
	@MATIECHUAN int
AS

DELETE FROM [dbo].[TIEUCHUAN]
 WHERE 
	[MATIECHUAN] = @MATIECHUAN

GO

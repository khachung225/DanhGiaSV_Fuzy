USE [DIEMRENLUYEN]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 04/29/2016 23:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [nvarchar](50) NOT NULL,
	[HOTEN] [nvarchar](250) NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANDANHGIA]    Script Date: 04/29/2016 23:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANDANHGIA](
	[MALOAI] [smallint] NOT NULL,
	[TENLOAI] [nvarchar](150) NULL,
	[P1] [float] NULL,
	[P2] [float] NULL,
	[P3] [float] NULL,
 CONSTRAINT [PK_NHANDANHGIA] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KETQUATOTNGHIEP]    Script Date: 04/29/2016 23:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KETQUATOTNGHIEP](
	[MASV] [nvarchar](50) NOT NULL,
	[HOTEN] [nvarchar](200) NOT NULL,
	[KETQUA] [nvarchar](150) NULL,
	[XEPLOAI] [nvarchar](50) NULL,
 CONSTRAINT [PK_KETQUATOTNGHIEP] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KETQUADANHGIA]    Script Date: 04/29/2016 23:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KETQUADANHGIA](
	[MASV] [nvarchar](50) NULL,
	[MASVDANHGIA] [nvarchar](50) NULL,
	@TC11 smallint = null ,
	@TC12 smallint = null ,
	@TC13 smallint = null ,
	@TC21 smallint = null ,
	@TC22 smallint = null ,
	@TC23 smallint = null ,
	@TC31 smallint = null ,
	@TC32 smallint = null ,
	@TC33 smallint = null ,
	@TC34 smallint = null ,
	@TC35 smallint = null ,
	@TC36 smallint = null ,
	@TC37 smallint = null ,
	@TC38 smallint = null ,
	@TC39 smallint = null ,
	@TC310 smallint = null ,
	@TC311 smallint = null ,
	@TC41 smallint = null ,
	@TC42 smallint = null ,	 
	@TC51 smallint = null ,
	@TC52 smallint = null ,
	@TC53 smallint = null 
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GIAOVIEN_DeleteByField]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GIAOVIEN_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[GIAOVIEN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 04/29/2016 23:21:39 ******/
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
/****** Object:  StoredProcedure [dbo].[GIAOVIEN_SelectByField]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GIAOVIEN_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT [MaGv], [TenGiaoVien], [Sex], [Adress], [UserLogin], [Password] FROM [dbo].[GIAOVIEN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)
GO
/****** Object:  StoredProcedure [dbo].[sp_KETQUATOTNGHIEP_Update]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_KETQUATOTNGHIEP_Update]
	@masv nvarchar(50),@hoten nvarchar(200),@ketqua nvarchar(150),@xeploai nvarchar(50)
	
As
	UPDATE [KETQUATOTNGHIEP]
	SET
		[masv]=@masv,[hoten]=@hoten,[ketqua]=@ketqua
		,[XEPLOAI]=@xeploai
		
	WHERE  [MASV]=@masv
GO
/****** Object:  StoredProcedure [dbo].[sp_KETQUATOTNGHIEP_Insert]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_KETQUATOTNGHIEP_Insert]
	@masv nvarchar(50),@hoten nvarchar(200),@ketqua nvarchar(150),@xeploai nvarchar(50)
	
As
	INSERT INTO [dbo].[KETQUATOTNGHIEP]
		([MASV],[HOTEN],[KETQUA],[XEPLOAI]
)
	VALUES
		(@masv,@hoten,@ketqua,@xeploai)
GO
/****** Object:  StoredProcedure [dbo].[sp_KETQUATOTNGHIEP_GetByID]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_KETQUATOTNGHIEP_GetByID]
	@masv nvarchar(50)
AS
	Select * From [dbo].[KETQUATOTNGHIEP]
	Where  MASV=@masv
GO
/****** Object:  StoredProcedure [dbo].[sp_KETQUATOTNGHIEP_GetAll]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_KETQUATOTNGHIEP_GetAll]
AS
	Select * From [dbo].[KETQUATOTNGHIEP]
GO
/****** Object:  Table [dbo].[TIEUCHUAN]    Script Date: 04/29/2016 23:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIEUCHUAN](
	[MATIECHUAN] [int] NOT NULL,
	[TENTIEUCHUAN] [nvarchar](50) NULL,
	[P1] [float] NULL,
	[P2] [float] NULL,
	[P3] [float] NULL,
 CONSTRAINT [PK_TIEUCHUAN] PRIMARY KEY CLUSTERED 
(
	[MATIECHUAN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_XepLoai_GetAll]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_XepLoai_GetAll]
AS
	Select * From [dbo].[TIEUCHUAN]
GO
/****** Object:  StoredProcedure [dbo].[sp_TieuChuan_GetByID]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_TieuChuan_GetByID]
	@matieuchuan int
AS
	Select P1,P2,P3 From [dbo].[TIEUCHUAN]
	Where  [MATIECHUAN]=@matieuchuan
GO
/****** Object:  StoredProcedure [dbo].[sp_SinhVien_GetAll_Ex]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_SinhVien_GetAll_Ex]
@masv nvarchar(50)
AS
	if (@masv<>'1')
	Select * From [dbo].[SINHVIEN] where MASV<>@masv
	else
	Select * From [dbo].[SINHVIEN]
GO
/****** Object:  StoredProcedure [dbo].[sp_SinhVien_GetAll]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_SinhVien_GetAll]
AS
	Select * From [dbo].[SINHVIEN]
GO
/****** Object:  StoredProcedure [dbo].[sp_KetQuaDanhGia_Update]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_KetQuaDanhGia_Update]
	@masv nvarchar(50) output,@masvdanhgia nvarchar(50)
	,@tc11 smallint,@tc12 smallint,@tc13 smallint
	,@tc21 smallint,@tc22 smallint,@tc23 smallint
	,@tc31 smallint,@tc32 smallint,@tc33 smallint,@tc34 smallint,@tc35 smallint,@tc36 smallint,@tc37 smallint
	,@tc38 smallint,@tc39 smallint,@tc310 smallint,@tc311 smallint
	,@tc41 smallint,@tc42 smallint 
	,@tc51 smallint,@tc52 smallint,@tc53 smallint
As
	UPDATE [KETQUADANHGIA]
	SET
		[masv]=@masv,[masvdanhgia]=@masvdanhgia
		,[TC11]=@tc11,[TC12]=@tc12,[TC13]=@tc13,
		[TC21]=@tc21,[TC22]=@tc22,[TC23]=@tc23,
		[TC31]=@tc31,[TC32]=@tc32,[TC33]=@tc33,[TC34]=@tc34,[TC35]=@tc35,[TC36]=@tc36,[TC37]=@tc37,[TC38]=@tc38,
		[TC39]=@tc39,[TC310]=@tc310,[TC311]=@tc311,
		[TC41]=@tc41,[TC42]=@tc42, 
		[TC51]=@tc51,[TC52]=@tc52,[TC53]=@tc53
	WHERE  [MASV]=@masv and [masvdanhgia]=@masvdanhgia
GO
/****** Object:  StoredProcedure [dbo].[sp_KetQuaDanhGia_Insert]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_KetQuaDanhGia_Insert]
	@masv nvarchar(50) output,@masvdanhgia nvarchar(50)
	,@tc11 smallint,@tc12 smallint,@tc13 smallint
	,@tc21 smallint,@tc22 smallint,@tc23 smallint
	,@tc31 smallint,@tc32 smallint,@tc33 smallint,@tc34 smallint,@tc35 smallint,@tc36 smallint,@tc37 smallint
	,@tc38 smallint,@tc39 smallint,@tc310 smallint,@tc311 smallint
	,@tc41 smallint,@tc42 smallint 
	,@tc51 smallint,@tc52 smallint,@tc53 smallint
As
	INSERT INTO [dbo].[KETQUADANHGIA]
		([MASV],[MASVDANHGIA],
		[TC11],[TC12],[TC13],
		[TC21],[TC22],[TC23],
		[TC31],[TC32],[TC33],
		[TC41],[TC42],[TC43],
		[TC51],[TC52],[TC53]
)
	VALUES
		(@masv,@masvdanhgia,
		 @tc11,@tc12,@tc13
		,@tc21,@tc22,@tc23
		,@tc31,@tc32,@tc33,@tc34,@tc35,@tc36,@tc37,@tc38,@tc39,@tc310,@tc311
		,@tc41,@tc42,@tc43
		,@tc51,@tc52,@tc53)
GO
/****** Object:  StoredProcedure [dbo].[sp_KetQuaDanhGia_GetByMaSV]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_KetQuaDanhGia_GetByMaSV]
	@masvdanhgia nvarchar(50)
AS
	Select * From [dbo].[KETQUADANHGIA]
	Where  [MASVDANHGIA]=@masvdanhgia
GO
/****** Object:  StoredProcedure [dbo].[sp_KetQuaDanhGia_GetByID]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_KetQuaDanhGia_GetByID]
	@masvdanhgia nvarchar(50),@masv nvarchar(50)
AS
	Select * From [dbo].[KETQUADANHGIA]
	Where  [MASVDANHGIA]=@masvdanhgia and MASV=@masv
GO
/****** Object:  StoredProcedure [dbo].[sp_KetQua_TieuChuan]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_KetQua_TieuChuan]
AS
	Select sv.HOTEN,k.TC11,k.TC12,k.TC13,k.TC21,k.TC22,k.TC31,k.TC32,k.TC33, 
	k.TC41,k.TC42,k.TC43,k.TC51,k.TC52,k.TC53
	From [dbo].[KETQUADANHGIA] k inner join SINHVIEN sv on k.MASV=sv.MASV
GO
/****** Object:  StoredProcedure [dbo].[sp_KetQua_GetAll_GetByMaSV]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[sp_KetQua_GetAll_GetByMaSV]
	@masvdanhgia nvarchar(50)
AS
	Select * From [dbo].[KETQUADANHGIA]
	Where  MASV=@masvdanhgia
GO
/****** Object:  StoredProcedure [dbo].[sp_KetQua_GetAll]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[sp_KetQua_GetAll]
AS
	Select * From [dbo].[KETQUADANHGIA]
GO
/****** Object:  StoredProcedure [dbo].[GIAOVIEN_SelectAll]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GIAOVIEN_SelectAll]
AS

	SELECT 
		[MaGv], [TenGiaoVien], [Sex], [Adress], [UserLogin], [Password]
	FROM [dbo].[GIAOVIEN]
GO
/****** Object:  StoredProcedure [dbo].[GIAOVIEN_Insert]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[GIAOVIEN_DeleteByPrimaryKey]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GIAOVIEN_DeleteByPrimaryKey]
	@MaGv int
AS

DELETE FROM [dbo].[GIAOVIEN]
 WHERE 
	[MaGv] = @MaGv
GO
/****** Object:  StoredProcedure [dbo].[GIAOVIEN_Update]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[GIAOVIEN_SelectByPrimaryKey]    Script Date: 04/29/2016 23:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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

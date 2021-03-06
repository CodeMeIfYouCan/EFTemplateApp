USE [CustomerDb]
GO
/****** Object:  StoredProcedure [CUS].[CUSTOMERS_SELECT]    Script Date: 25.12.2017 15:10:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Sunucu: s0134dbdev02
-- Veritabanı: CustomerDB

-- ==========================================================================================
-- Author:SedaOzy
-- Create date:24.07.2013
-- Description: Temel musteri bilgisini listeler
-- ==========================================================================================
-- ==========================================================================================
-- Author:veyselk
-- Update date:03.11.2015
-- Description: Temel musteri bilgisini listeler,GIIN ara göre arama eklendi
-- ==========================================================================================
ALTER PROCEDURE [CUS].[CUSTOMERS_SELECT]
@External_Client_No BIGINT=0,
@Customer_Id BIGINT =0,
@Name VARCHAR(50)='',    
@Surname VARCHAR(50)='',    
@FathersName VARCHAR(50)='',    
@MothersName VARCHAR(50)='',    
@BirthDate DATETIME=NULL,
@IdentityType int=0,
@IdentityNo varchar(25) ='',
@DrivingLicenceNo varchar(8)='',
@RecordStatus VARCHAR(1)='' ,
@GIIN varchar(19)='',
@CitizenshipNumber varchar(20)='',
@TaxNo varchar(11)=''
AS  
BEGIN

IF @External_Client_No <> 0
EXEC CUS.CUSTOMERS_SELECT_BY_CLIENT_NO @External_Client_No,@RecordStatus 
ELSE
IF @Customer_Id <> 0
EXEC CUS.CUSTOMERS_SELECT_BY_ID @Customer_Id,@RecordStatus
ELSE
IF @Name <> '' AND @Surname <> '' AND @FathersName <> '' AND @MothersName <> '' AND @BirthDate IS NOT NULL
EXEC CUS.CUSTOMERS_SELECT_BY_FIVE_KEY @Name,@Surname,@FathersName,@MothersName,@BirthDate,@RecordStatus,@CitizenshipNumber,@TaxNo
ELSE
IF @IdentityType <> 0 AND  @IdentityNo <> ''
EXEC CUS.CUSTOMERS_SELECT_BY_IDENTITY_NO @IdentityType,@IdentityNo,@RecordStatus
ELSE
IF @DrivingLicenceNo <> '' 
EXEC CUS.CUSTOMERS_SELECT_BY_DRIVING_LICENCE_NO @DrivingLicenceNo,@RecordStatus
ELSE
IF @GIIN <> ''
EXEC CUS.CUSTOMERS_SELECT_BY_GIIN @GIIN,@RecordStatus
 
END
USE [MusicProject]
GO
/****** Object:  StoredProcedure [dbo].[TypeAdd]    Script Date: 8/14/2020 11:35:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	add Type
-- =============================================
CREATE PROCEDURE [dbo].[TypeAdd] 
	
	@TypeName NVARCHAR(50),
	@Poster nvarchar(max)
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
	
INSERT INTO [dbo].[Type]
           ([IsDetele]
           ,[TypeName]
		   ,Poster)
     VALUES
           (0
           ,@TypeName
		   ,@Poster)

SET @Message = 'Add Type has been created successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[TypeDelete]    Script Date: 8/14/2020 11:35:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Delete Type
-- =============================================
CREATE PROCEDURE [dbo].[TypeDelete] 
	@TypeId INT
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
	

UPDATE [dbo].[Type]
   SET [IsDetele] = 1
		
 WHERE TypeId = @TypeId

SET @Message = 'Delete Type has been created successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[TypeEdit]    Script Date: 8/14/2020 11:35:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Edit Type
-- =============================================
CREATE PROCEDURE [dbo].[TypeEdit] 
	@TypeId INT,
	@TypeName NVARCHAR(50),
	@Poster NVARCHAR(max)
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
	

UPDATE [dbo].[Type]
   SET [TypeName] = @TypeName,
		Poster = @Poster
		
 WHERE TypeId = @TypeId

SET @Message = 'Edit Type has been created successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[TypeGetByID]    Script Date: 8/14/2020 11:35:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Type Id Admin
-- =============================================
CREATE PROCEDURE [dbo].[TypeGetByID] 
	@TypeId INT
AS
BEGIN
SELECT [TypeID]
      ,[TypeName]
        ,Poster
   FROM [dbo].[Type]
  Where TypeId = @TypeId 

END
GO
/****** Object:  StoredProcedure [dbo].[TypeGetsIsDelete]    Script Date: 8/14/2020 11:35:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Type
-- =============================================
CREATE PROCEDURE [dbo].[TypeGetsIsDelete] 
	
AS
BEGIN

	
SELECT [TypeID]
      ,[TypeName]
	  ,[IsDetele]
	  ,Poster
      
   FROM [dbo].[Type]
	WHERE IsDetele = 0

END
GO
/****** Object:  StoredProcedure [dbo].[TypeGetsIsNotDelete]    Script Date: 8/14/2020 11:35:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Type
-- =============================================
CREATE PROCEDURE [dbo].[TypeGetsIsNotDelete] 
	
AS
BEGIN

	
SELECT [TypeID]
      ,[TypeName]
        ,Poster
   FROM [dbo].[Type]
	WHERE IsDetele = 0

END
GO
/****** Object:  StoredProcedure [dbo].[TypeRestore]    Script Date: 8/14/2020 11:35:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Delete Type
-- =============================================
CREATE PROCEDURE [dbo].[TypeRestore] 
	@TypeId INT
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
	

UPDATE [dbo].[Type]
   SET [IsDetele] = 0
		
 WHERE TypeId = @TypeId

SET @Message = 'Delete Type has been restore successfully!'

SELECT @Message AS [Message]
	
END
GO

USE [MusicProject]
GO
/****** Object:  StoredProcedure [dbo].[AuthorAdd]    Script Date: 8/14/2020 11:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	add Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorAdd] 
	
	@AuthorName NVARCHAR(50),
	@Avatar NVARCHAR (MAX),
	@Introduce NVARCHAR(200)
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
INSERT INTO [dbo].[Author]
           ([AuthorName]
           ,[Avatar]
           ,[IsDelete]
		   ,[Views]
           ,[Introduce])
     VALUES
           (@AuthorName
           ,@Avatar
           ,0
		   ,0
           ,@Introduce)

SET @Message = 'Author has been created successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[AuthorDelete]    Script Date: 8/14/2020 11:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Delete Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorDelete] 
	@AuthorId INT	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

UPDATE [dbo].[Author]
   SET [IsDelete] = 1
      
 WHERE AuthorId = @AuthorId 

SET @Message = 'Author has been Delete successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[AuthorEdit]    Script Date: 8/14/2020 11:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Edit Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorEdit] 
	@AuthorId INT,
	@AuthorName NVARCHAR(50),
	@Avatar NVARCHAR (MAX),
	
	@Introduce NVARCHAR(200)
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

UPDATE [dbo].[Author]
   SET 
      [AuthorName] = @AuthorName
      ,[Avatar] = @Avatar      
      ,[Introduce] = @Introduce
 WHERE AuthorId = @AuthorId 

SET @Message = 'Author has been Edit successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[AuthorGetByID]    Script Date: 8/14/2020 11:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorGetByID] 
	@AuthorId INT
AS
BEGIN
DECLARE @FoundView int
SELECT @FoundView =  [Views] FROm [Author] where  @AuthorId = [AuthorID]
UPDATE [Author] SET [Views] = @FoundView +1 WHERE @AuthorId = [AuthorID]
SELECT [AuthorID]
      ,[Views]
      ,[AuthorName]
      ,[Avatar]
      ,[Introduce]
  FROM [dbo].[Author]
WHERE AuthorId = @AuthorId 

END
GO
/****** Object:  StoredProcedure [dbo].[AuthorGetsIsDelete]    Script Date: 8/14/2020 11:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorGetsIsDelete] 
AS
BEGIN
SELECT [AuthorID]
      ,[Views]
      ,[AuthorName]
      ,[Avatar]
	  ,isDelete
      ,[Introduce]
  FROM [dbo].[Author]
  WHERE IsDelete = 0
END
GO
/****** Object:  StoredProcedure [dbo].[AuthorGetsIsNotDelete]    Script Date: 8/14/2020 11:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorGetsIsNotDelete] 
AS
BEGIN
SELECT [AuthorID]
      ,[Views]
      ,[AuthorName]
      ,[Avatar]
    
  FROM [dbo].[Author]
  WhERE [IsDelete] = 0
  ORDER By [Views] DESC
END
GO
/****** Object:  StoredProcedure [dbo].[AuthorRestore]    Script Date: 8/14/2020 11:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Delete Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorRestore] 
	@AuthorId INT	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

UPDATE [dbo].[Author]
   SET [IsDelete] = 0
      
 WHERE AuthorId = @AuthorId 

SET @Message = 'Author has been Restore successfully!'

SELECT @Message AS [Message]
	
END
GO

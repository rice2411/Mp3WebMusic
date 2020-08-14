USE [MusicProject]
GO
/****** Object:  StoredProcedure [dbo].[TopicAdd]    Script Date: 8/14/2020 11:35:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/29/2020
-- Description: Create Topic 
-- =============================================
CREATE PROCEDURE [dbo].[TopicAdd]
	@TopicName NVARCHAR(50),
	@Poster nvarchar(max)
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

	
INSERT INTO [dbo].[Topic]
           ([IsDelete]
           ,[TopicName]
		   ,Poster)
     VALUES
           (0
           ,@TopicName
		   ,@Poster)
			SET @Message = 'Topic has been created successfully!'
		
		SELECT  @Message AS [Message]
END

GO
/****** Object:  StoredProcedure [dbo].[TopicDelete]    Script Date: 8/14/2020 11:35:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description: Delete Topic 
-- =============================================
Create PROCEDURE [dbo].[TopicDelete]
	@TopicID Int
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

	UPDATE [dbo].[Topic]
		SET [IsDelete] = 1
		WHERE TopicID= @TopicID

	SET @Message = 'Topic has been delete successfully!'
		
		SELECT  @Message AS [Message]
END

GO
/****** Object:  StoredProcedure [dbo].[TopicEdit]    Script Date: 8/14/2020 11:35:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description: Edit Topic 
-- =============================================
CREATE PROCEDURE [dbo].[TopicEdit]
	@TopicID Int,
	@TopicName NVARCHAR(50),
	@Poster nvarchar(max)
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

	UPDATE [dbo].[Topic]
		SET 
		 [TopicName] = @TopicName,
		 Poster = @Poster
		 WHERE TopicID= @TopicID

	SET @Message = 'Topic has been edit successfully!'
		
		SELECT  @Message AS [Message]
END

GO
/****** Object:  StoredProcedure [dbo].[TopicGetByID]    Script Date: 8/14/2020 11:35:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/29/2020
-- Description:	get Topic by TopicId
-- =============================================
CREATE PROCEDURE [dbo].[TopicGetByID]
	@TopicId INT
AS
BEGIN

SELECT [TopicId]
      ,[TopicName]
	  ,Poster
  FROM [dbo].[Topic]
   WHERE TopicId= @TopicId AND IsDelete = 0

END
GO
/****** Object:  StoredProcedure [dbo].[TopicGets]    Script Date: 8/14/2020 11:35:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	Get Topics
-- =============================================
CREATE PROCEDURE [dbo].[TopicGets]
	
AS
BEGIN

SELECT [TopicID]
      ,[IsDelete]
      ,[TopicName]
  FROM [dbo].[Topic]
  ORDER BY [TopicName] 

END
GO
/****** Object:  StoredProcedure [dbo].[TopicGetsIsDelete]    Script Date: 8/14/2020 11:35:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Type Id
-- =============================================
CREATE PROCEDURE [dbo].[TopicGetsIsDelete] 
AS
BEGIN	
SELECT [TopicID]
      ,[TopicName]
	  ,IsDelete
	  ,Poster
   FROM [dbo].[Topic]
   
END

/****** Object:  StoredProcedure [dbo].[GetListTypeIdAdmin]    Script Date: 7/31/2020 8:35:26 AM ******/
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[TopicGetsIsNotDelete]    Script Date: 8/14/2020 11:35:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	Get Topics for User
-- =============================================
CREATE PROCEDURE [dbo].[TopicGetsIsNotDelete]
	
AS
BEGIN

SELECT [TopicID]
      ,[IsDelete]
      ,[TopicName]
	  ,Poster
  FROM [dbo].[Topic]
  WHERE IsDelete= 0
  ORDER BY [TopicName] 

END
GO
/****** Object:  StoredProcedure [dbo].[TopicRestore]    Script Date: 8/14/2020 11:35:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description: Delete Topic 
-- =============================================
CREATE PROCEDURE [dbo].[TopicRestore]
	@TopicID Int
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

	UPDATE [dbo].[Topic]
		SET [IsDelete] = 0
		WHERE TopicID= @TopicID

	SET @Message = 'Topic has been restore successfully!'
		
		SELECT  @Message AS [Message]
END

GO

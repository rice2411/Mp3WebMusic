USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[TopicAdd]    Script Date: 8/17/2020 10:54:40 AM ******/
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

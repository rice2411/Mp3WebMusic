USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[TopicEdit]    Script Date: 8/17/2020 10:54:40 AM ******/
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

USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[AuthorRestore]    Script Date: 8/17/2020 10:54:40 AM ******/
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

USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[AuthorEdit]    Script Date: 8/17/2020 10:54:40 AM ******/
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

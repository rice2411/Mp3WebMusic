USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[AuthorAdd]    Script Date: 8/17/2020 10:54:40 AM ******/
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

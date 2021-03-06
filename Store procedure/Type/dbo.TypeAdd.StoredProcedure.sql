USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[TypeAdd]    Script Date: 8/17/2020 10:54:40 AM ******/
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

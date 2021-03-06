USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[TypeEdit]    Script Date: 8/17/2020 10:54:40 AM ******/
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

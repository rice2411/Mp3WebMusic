USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[TypeRestore]    Script Date: 8/17/2020 10:54:40 AM ******/
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

USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[TypeDelete]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Delete Type
-- =============================================
CREATE PROCEDURE [dbo].[TypeDelete] 
	@TypeId INT
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
	

UPDATE [dbo].[Type]
   SET [IsDetele] = 1
		
 WHERE TypeId = @TypeId

SET @Message = 'Delete Type has been created successfully!'

SELECT @Message AS [Message]
	
END
GO

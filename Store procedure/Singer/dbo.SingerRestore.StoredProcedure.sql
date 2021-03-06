USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SingerRestore]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description: Delete Singer
-- =============================================
CREATE PROCEDURE [dbo].[SingerRestore]
	@SingerID Int
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

	UPDATE [dbo].[Singer]
		SET [IsDelete] = 0
		WHERE SingerID= @SingerID

	SET @Message = 'Singer has been restore successfully!'
		
		SELECT  @Message AS [Message]
END

GO

USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SingerDelete]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description: Delete Singer
-- =============================================
Create PROCEDURE [dbo].[SingerDelete]
	@SingerID Int
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

	UPDATE [dbo].[Singer]
		SET [IsDelete] = 1
		WHERE SingerID= @SingerID

	SET @Message = 'Singer has been delete successfully!'
		
		SELECT  @Message AS [Message]
END

GO

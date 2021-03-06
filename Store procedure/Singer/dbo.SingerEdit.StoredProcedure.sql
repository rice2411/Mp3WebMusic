USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SingerEdit]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	 Edit Singer 
-- =============================================
CREATE PROCEDURE [dbo].[SingerEdit]
	@SingerID INT,
	@SingerName Nvarchar(50),
	@SingerNickName Nvarchar(50),
	@Introduce nvarchar(200),
	@Avatar nvarchar(max)
AS
BEGIN
DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

UPDATE [dbo].[Singer]
   SET [SingerName] = @SingerName
      ,[SingerNickName] = @SingerNickName
      ,[Introduce] = @Introduce
      ,[Avatar] = @Avatar

	WHERE SingerID= @SingerID
	SET @Message = 'Singer has been edit successfully!'
		
	SELECT  @Message AS [Message]

END
GO

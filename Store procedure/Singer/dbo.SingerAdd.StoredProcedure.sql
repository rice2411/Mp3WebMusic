USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SingerAdd]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	 Create Singer 
-- =============================================
CREATE PROCEDURE [dbo].[SingerAdd]
	@SingerName Nvarchar(50),
	@SingerNickName Nvarchar(50),
	@Introduce nvarchar(200),
	@Avatar nvarchar(max)
AS
BEGIN
DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
INSERT INTO [dbo].[Singer]
           ([SingerName]
           ,[SingerNickName]
           ,[Introduce]
           ,[Views]
           ,[IsDelete]
           ,[Avatar])
     VALUES
           (@SingerName
           ,@SingerNickName
           ,@Introduce
           ,0
           ,0
           ,@Avatar)
	SET @Message = 'Singer has been created successfully!'
		
	SELECT  @Message AS [Message]

END
GO

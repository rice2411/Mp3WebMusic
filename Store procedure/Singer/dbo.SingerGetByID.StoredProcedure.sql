USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SingerGetByID]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	Get Singer by SingerId
-- =============================================
CREATE PROCEDURE [dbo].[SingerGetByID]
	@SingerID INT
	
AS
BEGIN
DECLARE @FoundView int
SELECT @FoundView =  [Views] FROm [Singer] where  @SingerID = [SingerID]
UPDATE [Singer] SET [Views] = @FoundView +1 WHERE @SingerID = [SingerID]
SELECT [SingerID]
      ,[SingerName]
      ,[SingerNickName]
      ,[Introduce]
      ,[Views]
      ,[IsDelete]
      ,[Avatar]
  FROM [dbo].[Singer]
  WHERE SingerID = @SingerID
END
GO

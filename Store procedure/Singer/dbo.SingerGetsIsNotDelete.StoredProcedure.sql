USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SingerGetsIsNotDelete]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	Get Singers for user
-- =============================================
CREATE PROCEDURE [dbo].[SingerGetsIsNotDelete]
	
AS
BEGIN

SELECT [SingerID]
      ,[SingerName]
      ,[SingerNickName]
      ,[Views]
	  ,[Introduce]
      ,[Avatar]
  FROM [dbo].[Singer]
  WHERE IsDelete = 0
  ORDER BY [Views] DESC
END
GO

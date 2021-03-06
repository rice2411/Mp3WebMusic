USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SingerGetsIsDelete]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	Get Singers
-- =============================================
CREATE PROCEDURE [dbo].[SingerGetsIsDelete]
	
AS
BEGIN

SELECT [SingerID]
      ,[SingerName]
      ,[SingerNickName]
      ,[Introduce]
      ,[Views]
      ,[IsDelete]
      ,[Avatar]
	  ,IsDelete
  FROM [dbo].[Singer]

  ORDER BY [Views] DESC
END
GO

USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SingerGetsTop4]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SingerGetsTop4]

AS
BEGIN
SELECT Top(4) [SingerID]
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

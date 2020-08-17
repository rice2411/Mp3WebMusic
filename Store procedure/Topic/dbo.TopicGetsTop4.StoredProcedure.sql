USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[TopicGetsTop4]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TopicGetsTop4]

AS
BEGIN
SELECT Top(4) [TopicID]
      ,[IsDelete]
      ,[TopicName]
	    ,Poster
  FROM [dbo].[Topic]
  WHERE IsDelete = 0
  ORDER BY [TopicName]
END

GO

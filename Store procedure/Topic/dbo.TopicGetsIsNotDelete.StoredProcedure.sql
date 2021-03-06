USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[TopicGetsIsNotDelete]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	Get Topics for User
-- =============================================
CREATE PROCEDURE [dbo].[TopicGetsIsNotDelete]
	
AS
BEGIN

SELECT [TopicID]
      ,[IsDelete]
      ,[TopicName]
	  ,Poster
  FROM [dbo].[Topic]
  WHERE IsDelete= 0
  ORDER BY [TopicName] 

END
GO

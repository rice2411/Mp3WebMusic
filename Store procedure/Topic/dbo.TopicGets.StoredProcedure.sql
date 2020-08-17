USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[TopicGets]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	Get Topics
-- =============================================
CREATE PROCEDURE [dbo].[TopicGets]
	
AS
BEGIN

SELECT [TopicID]
      ,[IsDelete]
      ,[TopicName]
  FROM [dbo].[Topic]
  ORDER BY [TopicName] 

END
GO

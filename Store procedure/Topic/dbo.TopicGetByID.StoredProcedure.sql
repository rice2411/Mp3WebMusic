USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[TopicGetByID]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/29/2020
-- Description:	get Topic by TopicId
-- =============================================
CREATE PROCEDURE [dbo].[TopicGetByID]
	@TopicId INT
AS
BEGIN

SELECT [TopicId]
      ,[TopicName]
	  ,Poster
  FROM [dbo].[Topic]
   WHERE TopicId= @TopicId AND IsDelete = 0

END
GO

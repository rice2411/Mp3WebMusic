USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[TopicGetsIsDelete]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Type Id
-- =============================================
CREATE PROCEDURE [dbo].[TopicGetsIsDelete] 
AS
BEGIN	
SELECT [TopicID]
      ,[TopicName]
	  ,IsDelete
	  ,Poster
   FROM [dbo].[Topic]
   
END

/****** Object:  StoredProcedure [dbo].[GetListTypeIdAdmin]    Script Date: 7/31/2020 8:35:26 AM ******/
SET ANSI_NULLS ON
GO

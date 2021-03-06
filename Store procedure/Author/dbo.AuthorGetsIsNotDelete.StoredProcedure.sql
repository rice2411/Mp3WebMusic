USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[AuthorGetsIsNotDelete]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorGetsIsNotDelete] 
AS
BEGIN
SELECT [AuthorID]
      ,[Views]
      ,[AuthorName]
      ,[Avatar]
    
  FROM [dbo].[Author]
  WhERE [IsDelete] = 0
  ORDER By [Views] DESC
END
GO

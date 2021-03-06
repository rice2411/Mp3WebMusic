USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[AuthorGetByID]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorGetByID] 
	@AuthorId INT
AS
BEGIN
DECLARE @FoundView int
SELECT @FoundView =  [Views] FROm [Author] where  @AuthorId = [AuthorID]
UPDATE [Author] SET [Views] = @FoundView +1 WHERE @AuthorId = [AuthorID]
SELECT [AuthorID]
      ,[Views]
      ,[AuthorName]
      ,[Avatar]
      ,[Introduce]
  FROM [dbo].[Author]
WHERE AuthorId = @AuthorId 

END
GO

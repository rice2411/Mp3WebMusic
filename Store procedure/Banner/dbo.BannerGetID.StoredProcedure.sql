USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[BannerGetID]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BannerGetID]
@BannerID int
	
AS
BEGIN


SELECT [BannerID]
      ,[Banner]
  FROM [dbo].[Banner]
  where BannerID = @BannerID


END

GO

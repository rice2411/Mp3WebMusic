USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[BannerGets]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BannerGets]

	
AS
BEGIN


SELECT [BannerID]
      ,[Banner]
	  ,IsDelete
  FROM [dbo].[Banner]


END

GO

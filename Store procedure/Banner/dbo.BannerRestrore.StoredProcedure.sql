USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[BannerRestrore]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BannerRestrore]
	@BannerID int
AS
BEGIN
	DECLARE @Message nvarchar(50)='Restore Success'

UPDATE [dbo].[Banner]
   SET IsDelete =0
 WHERE BannerID =@BannerID

SELECT @Message as [Message]
END

GO

USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[BannerEdit]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BannerEdit]
	@BannerID int,
	@Banner nvarchar(max)
AS
BEGIN
DECLARE @Message nvarchar(50)='Edit Success'

UPDATE [dbo].[Banner]
   SET [Banner] = @Banner
 WHERE BannerID =@BannerID




SELECT @Message as [Message]

END

GO

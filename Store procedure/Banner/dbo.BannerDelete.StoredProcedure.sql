USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[BannerDelete]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BannerDelete]
	@BannerID int
	
AS
BEGIN
DECLARE @Message nvarchar(50)='Delete Success'

UPDATE [dbo].[Banner]
   SET IsDelete =1
 WHERE BannerID =@BannerID

SELECT @Message as [Message]

END

GO

USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SongDelete]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SongDelete]
	@SongID int
AS
BEGIN
DECLARE @Message nvarchar(50) ='Delete Succese'
UPDATE [dbo].[Song]
   SET 
      [IsDelete] = 1
 WHERE SongID = @SongID
 SELECT @Message as [Message]
END

GO

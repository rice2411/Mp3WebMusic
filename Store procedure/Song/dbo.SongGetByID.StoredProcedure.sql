USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SongGetByID]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SongGetByID]
	@SongID int
AS
BEGIN
DECLARE @FoundView int
SELECT @FoundView =  [Views] FROm song where  @SongID = SongID
UPDATE Song SET [Views] = @FoundView +1 WHERE @SongID = SongID
		SELECT s.SongID,sg.SingerID,s.SongName, s.Poster,sg.SingerNickName,s.Audio,s.[Views],a.AuthorName,a.AuthorID,s.TypeID,s.TopicID
		FROM Song as s
		INNER JOIN AuthorSong as aus on s.SongID = aus.SongID  
		INNER JOIN Author as a on a.AuthorID = aus.AuthorID
		INNER JOIN SingerSong as sgs on sgs.SongID = s.SongID
		INNER JOIN Singer as sg on sgs.SingerID =sg.SingerID
		WHERE s.SongID = @SongID 
		
END
GO

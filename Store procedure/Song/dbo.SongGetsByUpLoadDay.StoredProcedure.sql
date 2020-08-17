USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SongGetsByUpLoadDay]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SongGetsByUpLoadDay]
	
AS
BEGIN
		SELECT s.SongID,sg.SingerID,s.SongName, s.Poster,sg.SingerNickName,a.AuthorName, s.Views
		FROM Song as s
		JOIN AuthorSong as aus on s.SongID = aus.SongID
		JOIN Author as a on a.AuthorID = aus.AuthorID
		JOIN SingerSong as sgs on sgs.SongID = s.SongID
		JOIN Singer as sg on sgs.SingerID =sg.SingerID
		WHERE s.IsDelete = 0
		ORDER BY s.UploadDate DESC
END
GO

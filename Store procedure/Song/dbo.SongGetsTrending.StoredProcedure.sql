USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SongGetsTrending]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SongGetsTrending]	
AS
BEGIN	
		SELECT TOP(5) s.SongID,sg.SingerID,s.SongName, s.Poster,sg.SingerNickName,s.Audio
		FROM Song as s
		JOIN AuthorSong as aus on s.SongID = aus.SongID and s.IsDelete = 0
		JOIN Author as a on a.AuthorID = aus.AuthorID
		JOIN SingerSong as sgs on sgs.SongID = s.SongID
		JOIN Singer as sg on sgs.SingerID =sg.SingerID	
		ORDER BY s.[Views] DESC
END

GO

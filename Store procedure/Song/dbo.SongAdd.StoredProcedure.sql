USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SongAdd]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SongAdd] 
	@SongName nvarchar(50),
	@Audio nvarchar(max),
	@Poster	nvarchar(max),
	@TypeID int,
	@TopicID int,
	@SingerNickName nvarchar(50),
	@AuthorName nvarchar(50)
	
AS
BEGIN
DECLARE @Message nvarchar(200) ='Add success', @FoundSingerID int, @FoundSongID int, @FoundAuthorID int

IF( @SingerNickName in (SELECT SingerNickName FROM Singer WHERE @SingerNickName = SingerNickName)) and (@AuthorName in (SELECT AuthorName FROM Author WHERE @AuthorName = AuthorName))
	BEGIN
	INSERT INTO [dbo].[Song]
           ([SongName]
           ,[Audio]
           ,[Poster]
           ,[TypeID]
           ,[TopicID]
           ,[IsDelete]
		   ,[UploadDate]
           ,[Views])
     VALUES
           (@SongName
           ,@Audio
           ,@Poster
           ,@TypeID
           ,@TopicID
           ,0
		   ,GetDATE()
           ,0)
		SELECT @FoundSingerID = SingerID FROM Singer WHERE @SingerNickName = SingerNickName
		SELECT @FoundAuthorID = AuthorID FROM Author WHERE @AuthorName = AuthorName
		SELECT @FoundSongID = SongID FROM Song WHERE SongName = @SongName
		INSERT INTO [dbo].[SingerSong]
				   ([SongID]
				   ,[SingerID])
			 VALUES
				   (@FoundSongID
				   ,@FoundSingerID)
		INSERT INTO [dbo].[AuthorSong]
				   ([SongID]
				   ,[AuthorID])
			 VALUES
				   (@FoundSongID
				   ,@FoundAuthorID)
	END
ELSE
	BEGIN
		SET @Message ='Something went wrong'
	END
SELECT @Message as [Message]
END

GO

USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[SongEdit]    Script Date: 8/17/2020 10:54:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SongEdit]
	@SongID int,
	@SongName nvarchar(50),
	@Audio nvarchar(max),
	@Poster	nvarchar(max),
	@TypeID int,
	@TopicID int,
	@SingerNickName nvarchar(50),
	@AuthorName nvarchar(50)
	
AS
BEGIN
DECLARE @Message nvarchar(200) ='Edit success', @FoundSingerID int,@FoundAuthorID int

IF( @SingerNickName in (SELECT SingerNickName FROM Singer WHERE @SingerNickName = SingerNickName)) and (@AuthorName in (SELECT AuthorName FROM Author WHERE @AuthorName = AuthorName))
	BEGIN
		UPDATE [dbo].[Song]
		   SET [SongName] = @SongName
			  ,[Audio] = @Audio
			  ,[Poster] = @Poster
			  ,[TypeID] = @TypeID
			  ,[TopicID] = @TopicID
		 WHERE @SongID = SongID

		SELECT @FoundSingerID = SingerID FROM Singer WHERE @SingerNickName = SingerNickName
		SELECT @FoundAuthorID = AuthorID FROM Author WHERE @AuthorName = AuthorName
	

		UPDATE [dbo].[SingerSong]
		   SET [SongID] = @SongID
			  ,[SingerID] = @FoundSingerID
		 WHERE SongID = @SongID
		UPDATE [dbo].[AuthorSong]
		SET [SongID] = @SongID
			,[AuthorID] = @FoundAuthorID
		WHERE SongID = @SongID
	END
ELSE
	BEGIN
		SET @Message ='The singer or author cant not be found, please make sure the singer or author is correct or create them'
	END
SELECT @Message as [Message]
END


GO

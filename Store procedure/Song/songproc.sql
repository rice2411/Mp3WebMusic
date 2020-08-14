USE [MusicProject]
GO
/****** Object:  StoredProcedure [dbo].[SongAdd]    Script Date: 8/14/2020 11:35:22 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongDelete]    Script Date: 8/14/2020 11:35:22 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongEdit]    Script Date: 8/14/2020 11:35:22 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongGetByID]    Script Date: 8/14/2020 11:35:22 AM ******/
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
		JOIN AuthorSong as aus on s.SongID = aus.SongID
		JOIN Author as a on a.AuthorID = aus.AuthorID
		JOIN SingerSong as sgs on sgs.SongID = s.SongID
		JOIN Singer as sg on sgs.SingerID =sg.SingerID
		WHERE s.SongID = @SongID 
		
END
GO
/****** Object:  StoredProcedure [dbo].[SongGetsByAuthor]    Script Date: 8/14/2020 11:35:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SongGetsByAuthor] 
	@AuthorID int
AS
BEGIN
		SELECT s.SongID,sg.SingerID,s.SongName, s.Poster,sg.SingerNickName
		FROM Song as s
		JOIN AuthorSong as aus on s.SongID = aus.SongID
		JOIN Author as a on a.AuthorID = aus.AuthorID
		JOIN SingerSong as sgs on sgs.SongID = s.SongID
		JOIN Singer as sg on sgs.SingerID =sg.SingerID
		WHERE a.AuthorID = @AuthorID and s.IsDelete = 0
		ORDER BY s.[Views] DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SongGetsBySinger]    Script Date: 8/14/2020 11:35:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SongGetsBySinger]
	@SingerID int
AS
BEGIN
		SELECT s.SongID,sg.SingerID,s.SongName, s.Poster,sg.SingerNickName
		FROM Song as s
		JOIN AuthorSong as aus on s.SongID = aus.SongID
		JOIN Author as a on a.AuthorID = aus.AuthorID
		JOIN SingerSong as sgs on sgs.SongID = s.SongID
		JOIN Singer as sg on sgs.SingerID =sg.SingerID
		WHERE sg.SingerID = @SingerID and s.IsDelete = 0
		ORDER BY s.[Views] DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SongGetsByTopic]    Script Date: 8/14/2020 11:35:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SongGetsByTopic] 
	@TopicID int
AS
BEGIN
		SELECT s.SongID,sg.SingerID,s.SongName, s.Poster,sg.SingerNickName
		FROM Song as s
		JOIN AuthorSong as aus on s.SongID = aus.SongID
		JOIN Author as a on a.AuthorID = aus.AuthorID
		JOIN SingerSong as sgs on sgs.SongID = s.SongID
		JOIN Singer as sg on sgs.SingerID =sg.SingerID
		WHERE s.TopicID = @TopicID and s.IsDelete = 0
		ORDER BY s.[Views] DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SongGetsByType]    Script Date: 8/14/2020 11:35:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SongGetsByType] 
	@TypeID int
AS
BEGIN
		SELECT s.SongID,sg.SingerID,s.SongName, s.Poster,sg.SingerNickName
		FROM Song as s
		JOIN AuthorSong as aus on s.SongID = aus.SongID
		JOIN Author as a on a.AuthorID = aus.AuthorID
		JOIN SingerSong as sgs on sgs.SongID = s.SongID
		JOIN Singer as sg on sgs.SingerID =sg.SingerID
		WHERE s.TypeID = @TypeID and s.IsDelete = 0
		ORDER BY s.[Views] DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SongGetsByUpLoadDay]    Script Date: 8/14/2020 11:35:22 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongGetsIsDelete]    Script Date: 8/14/2020 11:35:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SongGetsIsDelete]

AS
BEGIN
		SELECT s.SongID,sg.SingerID,s.SongName, s.Poster,sg.SingerNickName,a.AuthorName,s.Views, s.IsDelete
		FROM Song as s
		JOIN AuthorSong as aus on s.SongID = aus.SongID
		JOIN Author as a on a.AuthorID = aus.AuthorID
		JOIN SingerSong as sgs on sgs.SongID = s.SongID
		JOIN Singer as sg on sgs.SingerID =sg.SingerID
	
		ORDER BY s.SongName 
END
GO
/****** Object:  StoredProcedure [dbo].[SongGetsTrending]    Script Date: 8/14/2020 11:35:22 AM ******/
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
		SELECT TOP(5) s.SongID,sg.SingerID,s.SongName, s.Poster,sg.SingerNickName
		FROM Song as s
		JOIN AuthorSong as aus on s.SongID = aus.SongID
		JOIN Author as a on a.AuthorID = aus.AuthorID
		JOIN SingerSong as sgs on sgs.SongID = s.SongID
		JOIN Singer as sg on sgs.SingerID =sg.SingerID
		WHERE  s.IsDelete = 0
		ORDER BY s.[Views] DESC
END

GO
/****** Object:  StoredProcedure [dbo].[SongRestore]    Script Date: 8/14/2020 11:35:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SongRestore] 
	@SongID int
AS
BEGIN
DECLARE @Message nvarchar(50) ='Restore success'
UPDATE [dbo].[Song]
   SET 
      [IsDelete] = 0
     
 WHERE @SongID = SongID
  SELECT @Message as [Message]
END

GO

USE [Mp3WebMusic]
GO
/****** Object:  StoredProcedure [dbo].[AuthorAdd]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	add Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorAdd] 
	
	@AuthorName NVARCHAR(50),
	@Avatar NVARCHAR (MAX),
	@Introduce NVARCHAR(200)
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
INSERT INTO [dbo].[Author]
           ([AuthorName]
           ,[Avatar]
           ,[IsDelete]
		   ,[Views]
           ,[Introduce])
     VALUES
           (@AuthorName
           ,@Avatar
           ,0
		   ,0
           ,@Introduce)

SET @Message = 'Author has been created successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[AuthorDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Delete Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorDelete] 
	@AuthorId INT	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

UPDATE [dbo].[Author]
   SET [IsDelete] = 1
      
 WHERE AuthorId = @AuthorId 

SET @Message = 'Author has been Delete successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[AuthorEdit]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Edit Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorEdit] 
	@AuthorId INT,
	@AuthorName NVARCHAR(50),
	@Avatar NVARCHAR (MAX),
	
	@Introduce NVARCHAR(200)
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

UPDATE [dbo].[Author]
   SET 
      [AuthorName] = @AuthorName
      ,[Avatar] = @Avatar      
      ,[Introduce] = @Introduce
 WHERE AuthorId = @AuthorId 

SET @Message = 'Author has been Edit successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[AuthorGetByID]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorGetByID] 
	@AuthorId INT
AS
BEGIN
DECLARE @FoundView int
SELECT @FoundView =  [Views] FROm [Author] where  @AuthorId = [AuthorID]
UPDATE [Author] SET [Views] = @FoundView +1 WHERE @AuthorId = [AuthorID]
SELECT [AuthorID]
      ,[Views]
      ,[AuthorName]
      ,[Avatar]
      ,[Introduce]
  FROM [dbo].[Author]
WHERE AuthorId = @AuthorId 

END
GO
/****** Object:  StoredProcedure [dbo].[AuthorGetsIsDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorGetsIsDelete] 
AS
BEGIN
SELECT [AuthorID]
      ,[Views]
      ,[AuthorName]
      ,[Avatar]
      ,[Introduce]
  FROM [dbo].[Author]
  WHERE IsDelete = 1
END
GO
/****** Object:  StoredProcedure [dbo].[AuthorGetsIsNotDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorGetsIsNotDelete] 
AS
BEGIN
SELECT [AuthorID]
      ,[Views]
      ,[AuthorName]
      ,[Avatar]
    
  FROM [dbo].[Author]
  WhERE [IsDelete] = 0
  ORDER By [Views] DESC
END
GO
/****** Object:  StoredProcedure [dbo].[AuthorRestore]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Delete Author
-- =============================================
CREATE PROCEDURE [dbo].[AuthorRestore] 
	@AuthorId INT	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

UPDATE [dbo].[Author]
   SET [IsDelete] = 0
      
 WHERE AuthorId = @AuthorId 

SET @Message = 'Author has been Restore successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[SingerAdd]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	 Create Singer 
-- =============================================
CREATE PROCEDURE [dbo].[SingerAdd]
	@SingerName Nvarchar(50),
	@SingerNickName Nvarchar(50),
	@Introduce nvarchar(200),
	@Avatar nvarchar(max)
AS
BEGIN
DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
INSERT INTO [dbo].[Singer]
           ([SingerName]
           ,[SingerNickName]
           ,[Introduce]
           ,[Views]
           ,[IsDelete]
           ,[Avatar])
     VALUES
           (@SingerName
           ,@SingerNickName
           ,@Introduce
           ,0
           ,0
           ,@Avatar)
	SET @Message = 'Singer has been created successfully!'
		
	SELECT  @Message AS [Message]

END
GO
/****** Object:  StoredProcedure [dbo].[SingerDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description: Delete Singer
-- =============================================
Create PROCEDURE [dbo].[SingerDelete]
	@SingerID Int
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

	UPDATE [dbo].[Singer]
		SET [IsDelete] = 1
		WHERE SingerID= @SingerID

	SET @Message = 'Singer has been delete successfully!'
		
		SELECT  @Message AS [Message]
END

GO
/****** Object:  StoredProcedure [dbo].[SingerEdit]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	 Edit Singer 
-- =============================================
CREATE PROCEDURE [dbo].[SingerEdit]
	@SingerID INT,
	@SingerName Nvarchar(50),
	@SingerNickName Nvarchar(50),
	@Introduce nvarchar(200),
	@Avatar nvarchar(max)
AS
BEGIN
DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

UPDATE [dbo].[Singer]
   SET [SingerName] = @SingerName
      ,[SingerNickName] = @SingerNickName
      ,[Introduce] = @Introduce
      ,[Avatar] = @Avatar

	WHERE SingerID= @SingerID
	SET @Message = 'Singer has been edit successfully!'
		
	SELECT  @Message AS [Message]

END
GO
/****** Object:  StoredProcedure [dbo].[SingerGetByID]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	Get Singer by SingerId
-- =============================================
CREATE PROCEDURE [dbo].[SingerGetByID]
	@SingerID INT
	
AS
BEGIN
DECLARE @FoundView int
SELECT @FoundView =  [Views] FROm [Singer] where  @SingerID = [SingerID]
UPDATE [Singer] SET [Views] = @FoundView +1 WHERE @SingerID = [SingerID]
SELECT [SingerID]
      ,[SingerName]
      ,[SingerNickName]
      ,[Introduce]
      ,[Views]
      ,[IsDelete]
      ,[Avatar]
  FROM [dbo].[Singer]
  WHERE SingerID = @SingerID
END
GO
/****** Object:  StoredProcedure [dbo].[SingerGetsIsDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	Get Singers
-- =============================================
CREATE PROCEDURE [dbo].[SingerGetsIsDelete]
	
AS
BEGIN

SELECT [SingerID]
      ,[SingerName]
      ,[SingerNickName]
      ,[Introduce]
      ,[Views]
      ,[IsDelete]
      ,[Avatar]
  FROM [dbo].[Singer]
  WHERE IsDelete = 1
  ORDER BY [Views] DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SingerGetsIsNotDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	Get Singers for user
-- =============================================
CREATE PROCEDURE [dbo].[SingerGetsIsNotDelete]
	
AS
BEGIN

SELECT [SingerID]
      ,[SingerName]
      ,[SingerNickName]
      ,[Views]
	  ,[Introduce]
      ,[Avatar]
  FROM [dbo].[Singer]
  WHERE IsDelete = 0
  ORDER BY [Views] DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SingerRestore]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description: Delete Singer
-- =============================================
CREATE PROCEDURE [dbo].[SingerRestore]
	@SingerID Int
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

	UPDATE [dbo].[Singer]
		SET [IsDelete] = 0
		WHERE SingerID= @SingerID

	SET @Message = 'Singer has been restore successfully!'
		
		SELECT  @Message AS [Message]
END

GO
/****** Object:  StoredProcedure [dbo].[SongAdd]    Script Date: 8/12/2020 8:20:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongEdit]    Script Date: 8/12/2020 8:20:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongGetByID]    Script Date: 8/12/2020 8:20:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongGetsByAuthor]    Script Date: 8/12/2020 8:20:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongGetsBySinger]    Script Date: 8/12/2020 8:20:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongGetsByTopic]    Script Date: 8/12/2020 8:20:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongGetsByType]    Script Date: 8/12/2020 8:20:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongGetsByUpLoadDay]    Script Date: 8/12/2020 8:20:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongGetsIsDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
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
		SELECT s.SongID,sg.SingerID,s.SongName, s.Poster,sg.SingerNickName,a.AuthorName,s.Views
		FROM Song as s
		JOIN AuthorSong as aus on s.SongID = aus.SongID
		JOIN Author as a on a.AuthorID = aus.AuthorID
		JOIN SingerSong as sgs on sgs.SongID = s.SongID
		JOIN Singer as sg on sgs.SingerID =sg.SingerID
		WHERE  s.IsDelete = 1
		ORDER BY s.SongName 
END
GO
/****** Object:  StoredProcedure [dbo].[SongGetsTrending]    Script Date: 8/12/2020 8:20:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SongRestore]    Script Date: 8/12/2020 8:20:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[TopicAdd]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/29/2020
-- Description: Create Topic 
-- =============================================
Create PROCEDURE [dbo].[TopicAdd]
	@TopicName NVARCHAR(50)
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

	
INSERT INTO [dbo].[Topic]
           ([IsDelete]
           ,[TopicName])
     VALUES
           (0
           ,@TopicName)
			SET @Message = 'Topic has been created successfully!'
		
		SELECT  @Message AS [Message]
END

GO
/****** Object:  StoredProcedure [dbo].[TopicDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description: Delete Topic 
-- =============================================
Create PROCEDURE [dbo].[TopicDelete]
	@TopicID Int
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

	UPDATE [dbo].[Topic]
		SET [IsDelete] = 1
		WHERE TopicID= @TopicID

	SET @Message = 'Topic has been delete successfully!'
		
		SELECT  @Message AS [Message]
END

GO
/****** Object:  StoredProcedure [dbo].[TopicEdit]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description: Edit Topic 
-- =============================================
CREATE PROCEDURE [dbo].[TopicEdit]
	@TopicID Int,
	@TopicName NVARCHAR(50)
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

	UPDATE [dbo].[Topic]
		SET 
		 [TopicName] = @TopicName
		 WHERE TopicID= @TopicID

	SET @Message = 'Topic has been edit successfully!'
		
		SELECT  @Message AS [Message]
END

GO
/****** Object:  StoredProcedure [dbo].[TopicGetByID]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/29/2020
-- Description:	get Topic by TopicId
-- =============================================
CREATE PROCEDURE [dbo].[TopicGetByID]
	@TopicId INT
AS
BEGIN

SELECT [TopicId]
      ,[TopicName]
  FROM [dbo].[Topic]
   WHERE TopicId= @TopicId AND IsDelete = 0

END
GO
/****** Object:  StoredProcedure [dbo].[TopicGets]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	Get Topics
-- =============================================
CREATE PROCEDURE [dbo].[TopicGets]
	
AS
BEGIN

SELECT [TopicID]
      ,[IsDelete]
      ,[TopicName]
  FROM [dbo].[Topic]
  ORDER BY [TopicName] 

END
GO
/****** Object:  StoredProcedure [dbo].[TopicGetsIsDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Type Id
-- =============================================
CREATE PROCEDURE [dbo].[TopicGetsIsDelete] 
AS
BEGIN	
SELECT [TopicID]
      ,[TopicName]
	  
   FROM [dbo].[Topic]
   WHERE IsDelete =1
END

/****** Object:  StoredProcedure [dbo].[GetListTypeIdAdmin]    Script Date: 7/31/2020 8:35:26 AM ******/
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[TopicGetsIsNotDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description:	Get Topics for User
-- =============================================
CREATE PROCEDURE [dbo].[TopicGetsIsNotDelete]
	
AS
BEGIN

SELECT [TopicID]
      ,[IsDelete]
      ,[TopicName]
  FROM [dbo].[Topic]
  WHERE IsDelete= 0
  ORDER BY [TopicName] 

END
GO
/****** Object:  StoredProcedure [dbo].[TopicRestore]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Ghi Nguyen
-- Create date: 7/30/2020
-- Description: Delete Topic 
-- =============================================
CREATE PROCEDURE [dbo].[TopicRestore]
	@TopicID Int
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'

	UPDATE [dbo].[Topic]
		SET [IsDelete] = 0
		WHERE TopicID= @TopicID

	SET @Message = 'Topic has been restore successfully!'
		
		SELECT  @Message AS [Message]
END

GO
/****** Object:  StoredProcedure [dbo].[TypeAdd]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	add Type
-- =============================================
Create PROCEDURE [dbo].[TypeAdd] 
	
	@TypeName NVARCHAR(50)
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
	
INSERT INTO [dbo].[Type]
           ([IsDetele]
           ,[TypeName])
     VALUES
           (0
           ,@TypeName)

SET @Message = 'Add Type has been created successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[TypeDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Delete Type
-- =============================================
CREATE PROCEDURE [dbo].[TypeDelete] 
	@TypeId INT
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
	

UPDATE [dbo].[Type]
   SET [IsDetele] = 1
		
 WHERE TypeId = @TypeId

SET @Message = 'Delete Type has been created successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[TypeEdit]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Edit Type
-- =============================================
CREATE PROCEDURE [dbo].[TypeEdit] 
	@TypeId INT,
	@TypeName NVARCHAR(50)
	
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
	

UPDATE [dbo].[Type]
   SET [TypeName] = @TypeName
		
 WHERE TypeId = @TypeId

SET @Message = 'Edit Type has been created successfully!'

SELECT @Message AS [Message]
	
END
GO
/****** Object:  StoredProcedure [dbo].[TypeGetByID]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Type Id Admin
-- =============================================
CREATE PROCEDURE [dbo].[TypeGetByID] 
	@TypeId INT
AS
BEGIN
SELECT [TypeID]
      ,[TypeName]
      
   FROM [dbo].[Type]
  Where TypeId = @TypeId 

END
GO
/****** Object:  StoredProcedure [dbo].[TypeGetsIsDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Type
-- =============================================
Create PROCEDURE [dbo].[TypeGetsIsDelete] 
	
AS
BEGIN

	
SELECT [TypeID]
      ,[TypeName]
      
   FROM [dbo].[Type]
	WHERE IsDetele = 1

END
GO
/****** Object:  StoredProcedure [dbo].[TypeGetsIsNotDelete]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		tin
-- Create date: 30/07/2020
-- Description:	Get list Type
-- =============================================
CREATE PROCEDURE [dbo].[TypeGetsIsNotDelete] 
	
AS
BEGIN

	
SELECT [TypeID]
      ,[TypeName]
      
   FROM [dbo].[Type]
	WHERE IsDetele = 0

END
GO
/****** Object:  StoredProcedure [dbo].[TypeRestore]    Script Date: 8/12/2020 8:20:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<tin>
-- Create date: <30/07/2020>
-- Description:	Delete Type
-- =============================================
CREATE PROCEDURE [dbo].[TypeRestore] 
	@TypeId INT
AS
BEGIN
	DECLARE @Message NVARCHAR(200) = 'Something went wrong, please try again!'
	

UPDATE [dbo].[Type]
   SET [IsDetele] = 0
		
 WHERE TypeId = @TypeId

SET @Message = 'Delete Type has been restore successfully!'

SELECT @Message AS [Message]
	
END
GO

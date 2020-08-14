USE [MusicProject]
GO
/****** Object:  StoredProcedure [dbo].[SingerAdd]    Script Date: 8/14/2020 11:34:57 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SingerDelete]    Script Date: 8/14/2020 11:34:57 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SingerEdit]    Script Date: 8/14/2020 11:34:57 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SingerGetByID]    Script Date: 8/14/2020 11:34:57 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SingerGetsIsDelete]    Script Date: 8/14/2020 11:34:57 AM ******/
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
	  ,IsDelete
  FROM [dbo].[Singer]

  ORDER BY [Views] DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SingerGetsIsNotDelete]    Script Date: 8/14/2020 11:34:57 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SingerRestore]    Script Date: 8/14/2020 11:34:57 AM ******/
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

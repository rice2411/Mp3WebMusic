USE [MusicProject]
GO
/****** Object:  StoredProcedure [dbo].[BannerAdd]    Script Date: 8/14/2020 11:34:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BannerAdd]
	@Banner nvarchar(max)
AS
BEGIN
DECLARE @Message nvarchar(50)='Add Success'
INSERT INTO [dbo].[Banner]
           ([Banner])
     VALUES
           (@Banner)

SELECT @Message as [Message]

END

GO
/****** Object:  StoredProcedure [dbo].[BannerDelete]    Script Date: 8/14/2020 11:34:36 AM ******/
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

DELETE FROM [dbo].[Banner]
      WHERE @BannerID = BannerID

SELECT @Message as [Message]

END

GO
/****** Object:  StoredProcedure [dbo].[BannerEdit]    Script Date: 8/14/2020 11:34:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BannerEdit]
	@BannerID int,
	@Banner nvarchar(max)
AS
BEGIN
DECLARE @Message nvarchar(50)='Edit Success'

UPDATE [dbo].[Banner]
   SET [Banner] = @Banner
 WHERE BannerID =@BannerID




SELECT @Message as [Message]

END

GO
/****** Object:  StoredProcedure [dbo].[BannerGetID]    Script Date: 8/14/2020 11:34:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BannerGetID]
@BannerID int
	
AS
BEGIN


SELECT [BannerID]
      ,[Banner]
  FROM [dbo].[Banner]
  where BannerID = @BannerID


END

GO
/****** Object:  StoredProcedure [dbo].[BannerGets]    Script Date: 8/14/2020 11:34:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BannerGets]

	
AS
BEGIN


SELECT [BannerID]
      ,[Banner]
  FROM [dbo].[Banner]


END

GO

USE [Mp3Project]
GO
/****** Object:  StoredProcedure [dbo].[TypeGetsIsNotDelete]    Script Date: 8/17/2020 10:54:40 AM ******/
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
        ,Poster
   FROM [dbo].[Type]
	WHERE IsDetele = 0

END
GO

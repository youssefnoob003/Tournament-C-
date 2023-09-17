USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTeams_SelectAll]    Script Date: 9/17/2023 10:46:23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTeams_SelectAll]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * 
	From dbo.Teams
END
GO


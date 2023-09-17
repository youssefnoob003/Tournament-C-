USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spPeople_SelectAll]    Script Date: 9/17/2023 10:45:31 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spPeople_SelectAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.People;
END
GO


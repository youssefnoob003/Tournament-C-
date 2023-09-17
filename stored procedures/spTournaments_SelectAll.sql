USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTournaments_SelectAll]    Script Date: 9/17/2023 10:47:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTournaments_SelectAll]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Select * from dbo.Tournaments
	where Active = 1;
END
GO


USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spPrizes_SelectAll]    Script Date: 9/17/2023 10:45:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spPrizes_SelectAll]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
	FROM dbo.Prizes
END
GO


USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spMatchups_Update]    Script Date: 9/17/2023 10:45:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spMatchups_Update]
	@Id int,
	@WinnerId int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Update dbo.Matchups
	Set WinnerId = @WinnerId
	where Id = @Id;
END
GO


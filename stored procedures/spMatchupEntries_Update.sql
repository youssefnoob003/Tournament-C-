USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Update]    Script Date: 9/17/2023 10:44:45 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spMatchupEntries_Update]
	@Id int,
	@TeamId int,
	@Score float
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Update dbo.MatchupEntries
	Set TeamCompetingId = @TeamId,
	Score = @Score
	where Id = @Id;
END
GO


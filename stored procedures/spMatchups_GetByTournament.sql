USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spMatchups_GetByTournament]    Script Date: 9/17/2023 10:44:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spMatchups_GetByTournament]
	@TournamentId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select m.*
	from dbo.Matchups m 
	where m.TournamentId = @TournamentId;
END
GO


USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[sbTeams_GetByTournament]    Script Date: 9/17/2023 10:44:03 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sbTeams_GetByTournament]
	@TournamentId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   select t.*
	from dbo.Teams t 
	inner join TournamentEntries e on t.Id = e.TeamId
	where e.TournamentId = @TournamentId;
END
GO


USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spMatchups_Insert]    Script Date: 9/17/2023 10:45:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spMatchups_Insert]
	@TournamentId int,
	@TournamentRound int,
	@WinnerId int = null,
	@Id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Insert into dbo.Matchups(TournamentId, MatchupRound, WinnerId)
	values(@TournamentId, @TournamentRound, @WinnerId);
	SELECT @Id = SCOPE_IDENTITY();
END
GO


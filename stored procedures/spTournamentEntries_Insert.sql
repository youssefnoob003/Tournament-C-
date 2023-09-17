USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTournamentEntries_Insert]    Script Date: 9/17/2023 10:46:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTournamentEntries_Insert]
	@TournamentId int,
	@TeamId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Insert Into TournamentEntries (TournamentId, TeamId)
	values (@TournamentId, @TeamId)
    
END
GO


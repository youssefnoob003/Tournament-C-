USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spPrizes_GetByTournament]    Script Date: 9/17/2023 10:45:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spPrizes_GetByTournament]
	@TournamentId int
AS
BEGIN
	SELECT p. *
	from dbo.prizes p
	inner join dbo.TournamentPrizes t on p.id = t.PrizeId
	where t.TournamentId = @TournamentId;
END
GO


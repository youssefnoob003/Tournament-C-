USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTournamentPrizes_Insert]    Script Date: 9/17/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTournamentPrizes_Insert] 
	@TournamentId int,
	@PrizeId int,
	@Id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO dbo.TournamentPrizes (TournamentId, PrizeId)
	values (@TournamentId, @PrizeId);
	Select @Id = SCOPE_IDENTITY();
END
GO


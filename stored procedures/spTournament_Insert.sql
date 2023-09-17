USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTournament_Insert]    Script Date: 9/17/2023 10:46:45 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTournament_Insert]
	@TournamentName nvarchar(200),
	@EntryFee money,
	@Id int = 0 output
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Insert Into dbo.Tournaments (TournamentName, EntryFee, Active)
	values (@TournamentName, @EntryFee, 1);
	Select @Id = SCOPE_IDENTITY();

END
GO


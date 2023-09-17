USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Insert]    Script Date: 9/17/2023 10:44:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spMatchupEntries_Insert]
	@MatchupId int,
	@ParentMatchupId int = null,
	@TeamCompetingId int,
	@Id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   Insert into dbo.MatchupEntries(MatchupId, ParentMatchupId, TeamCompetingId)
   values (@MatchupId, @ParentMatchupId, @TeamCompetingId);

   select @Id = SCOPE_IDENTITY();
END
GO


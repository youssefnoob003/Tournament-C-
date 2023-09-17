USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spMatchupEntries_GetByMatchupId]    Script Date: 9/17/2023 10:44:21 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spMatchupEntries_GetByMatchupId]
	@MatchupId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from MatchupEntries
	where MatchupId = @MatchupId
END
GO


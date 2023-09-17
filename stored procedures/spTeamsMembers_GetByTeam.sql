USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTeamsMembers_GetByTeam]    Script Date: 9/17/2023 10:46:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTeamsMembers_GetByTeam]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   SELECT p.*
   from dbo.TeamMembers m
   inner join dbo.People p on m.PersonId = p.id
   where m.TeamId = @Id;
END
GO


USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTeamMembers_Insert]    Script Date: 9/17/2023 10:46:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTeamMembers_Insert]
	@TeamId int,
	@PersonId int
AS
BEGIN
	
	SET NOCOUNT ON;

   Insert into TeamMembers(TeamId, PersonId)
   values (@TeamId, @PersonId);
END
GO


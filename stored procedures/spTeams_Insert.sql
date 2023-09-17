USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spTeams_Insert]    Script Date: 9/17/2023 10:46:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spTeams_Insert]
	@TeamName nvarchar(100),
	@Id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

    Insert Into dbo.Teams(TeamName)
	Values (@TeamName);
	select @Id = SCOPE_IDENTITY();
END
GO


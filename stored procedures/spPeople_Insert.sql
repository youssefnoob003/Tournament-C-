USE [Tournaments]
GO

/****** Object:  StoredProcedure [dbo].[spPeople_Insert]    Script Date: 9/17/2023 10:45:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spPeople_Insert]
	@FirstName nvarchar(100),
	@LastName nvarchar(100),
	@Email nvarchar(100),
	@Cellphone nvarchar(20),
	@Id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

    insert into dbo.People(FirstName, LastName, EmailAdress, CellphoneNumber)
	values (@FirstName, @LastName, @Email, @Cellphone);

	select @Id = SCOPE_IDENTITY();
END
GO


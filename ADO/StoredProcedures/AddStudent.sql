CREATE PROCEDURE [dbo].[AddStudent]
	@FirstName Nvarchar(50),
	@LastName Nvarchar(50),
	@BirthDate DateTime2(7),
	@YearResult int,
	@SectionId int
AS
Begin
	insert into Student (FirstName, LastName, BirthDate, YearResult, SectionId)
	output inserted.Id
	values (@FirstName, @LastName, @BirthDate, @YearResult, @SectionId);
End

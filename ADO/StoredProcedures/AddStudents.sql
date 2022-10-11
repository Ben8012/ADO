CREATE PROCEDURE [dbo].[AddStudents]
	@Students T_Student readonly
AS
Begin
	insert into Student (LastName, FirstName, BirthDate, YearResult, SectionId)
	output inserted.Id
	select LastName, FirstName, BirthDate, YearResult, SectionId from @Students;
End

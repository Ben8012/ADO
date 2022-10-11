CREATE TYPE [dbo].[T_Student] As Table
(
	FirstName Nvarchar(50) not null,
	LastName Nvarchar(50) not null,
	BirthDate DateTime2(7) not null,
	YearResult int null,
	SectionId int not null
)

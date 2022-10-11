CREATE PROCEDURE [dbo].[AddSection]
	@Id int,
	@SectionName Nvarchar(50)
AS
Begin
	insert into Section (Id, SectionName) values (@Id, @SectionName);
End

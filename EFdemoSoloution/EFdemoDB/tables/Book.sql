CREATE TABLE [dbo].[Book]
(
	[ISBN] INT NOT NULL PRIMARY KEY,
	[Title] nvarchar(50) NOT NULL,
	[YearPublished] INT NOT NULL,
	[AuthorsID] INT NOT NULL,
	[StudentId] INT NOT NULL,
	FOREIGN KEY(AuthorsID) references Author,
	FOREIGN KEY(StudentId) references student,



)

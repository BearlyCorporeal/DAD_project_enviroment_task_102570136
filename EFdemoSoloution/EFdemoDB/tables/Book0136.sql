CREATE TABLE [dbo].[Book0136]
(
	[ISBN] INT NOT NULL PRIMARY KEY,
	[Title] nvarchar(50) NOT NULL,
	[YearPublished] INT NOT NULL,
	[AuthorsID] INT NOT NULL,
	[StudentId] INT NOT NULL,
	FOREIGN KEY(AuthorsID) references Author0136,
	FOREIGN KEY(StudentId) references student0136,



)

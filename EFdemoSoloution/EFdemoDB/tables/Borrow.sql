CREATE TABLE [dbo].[Borrow]
(
	[StudentId] INT NOT NULL PRIMARY KEY,
	[ISBN] INT NOT NULL PRIMARY KEY,
	FOREIGN KEY(ISBN) references Book,
	FOREIGN KEY(StudentId) references student,
)

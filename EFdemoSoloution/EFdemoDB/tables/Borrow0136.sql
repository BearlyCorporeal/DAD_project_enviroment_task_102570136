CREATE TABLE [dbo].[Borrow0136]
(
	[StudentId] INT NOT NULL,
	[ISBN] INT NOT NULL,
	FOREIGN KEY(ISBN) references Book0136,
	FOREIGN KEY(StudentId) references student0136,
	PRIMARY KEY(StudentId,ISBN)
)

CREATE TABLE [dbo].[student]
(
	[StudentId] INT NOT NULL PRIMARY KEY,
	[FirstName] nvarchar(50) NOT NULL,
	[Surname] nvarchar(50) NOT NULL,
	[Email] nvarchar(50) NOT NULL,
	[MobilePhoneNumber] int NOT NULL,
)

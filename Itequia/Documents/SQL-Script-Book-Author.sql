USE DbName
GO

-------------------------------------------------
-- Script to Generate Table relationship Objects  | :))
-------------------------------------------------

-- Create Table Author
CREATE TABLE dbo.Author(
	ID int IDENTITY NOT NULL,
	Name varchar(100) NOT NULL,
 CONSTRAINT PK_Author PRIMARY KEY(ID ASC))
GO


-- Create Table Book
CREATE TABLE dbo.Book (
	ID int IDENTITY NOT NULL,
	Title varchar(100) NOT NULL,
	FirstPublished int NOT NULL,
	AuthorsSummary varchar(100) NULL,
 CONSTRAINT PK_Book PRIMARY KEY(ID ASC))

GO


-- Table to Manage Many to Many RelationShip
CREATE TABLE dbo.Book_Author(
	BookID int NOT NULL,
	AuthorID int NULL
)

ALTER TABLE dbo.Book_Author  WITH CHECK ADD  CONSTRAINT FK_Book_Author_Author FOREIGN KEY(AuthorID)
REFERENCES dbo.Book (ID)
GO

ALTER TABLE dbo.Book_Author CHECK CONSTRAINT FK_Book_Author_Author
GO

ALTER TABLE dbo.Book_Author  WITH CHECK ADD  CONSTRAINT [FK_Book_Author_Book] FOREIGN KEY(BookID)
REFERENCES  dbo.Book (ID)
GO

ALTER TABLE dbo.Book_Author CHECK CONSTRAINT [FK_Book_Author_Book]
GO
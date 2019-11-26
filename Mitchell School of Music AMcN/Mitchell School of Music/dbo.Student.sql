CREATE TABLE [dbo].[Student]
(
	[Student ID] INT NOT NULL PRIMARY KEY, 
    [Student Forename] NCHAR(10) NULL, 
    [Student Surname] NCHAR(10) NULL, 
    [Student Address Line 1] NCHAR(10) NULL, 
    [Student Address Line 2] NCHAR(10) NULL, 
    [Student Post Code] NCHAR(10) NULL, 
    [Student Phone] NCHAR(10) NULL
)

CREATE TABLE [dbo].[Rental]
(
	[Rental ID] INT NOT NULL PRIMARY KEY, 
    [Instrument ID] NCHAR(10) NULL, 
    [Student ID] BINARY(2) NULL, 
    [Rental Status] NCHAR(10) NULL, 
    [Date Rented] NCHAR(10) NULL, 
    [Return Date] NCHAR(10) NULL, 
    [Payment Date] NCHAR(10) NULL
)

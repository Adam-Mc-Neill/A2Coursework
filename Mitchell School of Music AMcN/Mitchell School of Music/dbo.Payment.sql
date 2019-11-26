CREATE TABLE [dbo].[Payment]
(
	[Payment ID] INT NOT NULL PRIMARY KEY, 
    [Student ID] NCHAR(10) NULL, 
    [Rental ID] NCHAR(10) NULL, 
    [Repair ID] NCHAR(10) NULL, 
    [Amount] NCHAR(10) NULL, 
    [Payment Date] NCHAR(10) NULL, 
    [Payment Details] NCHAR(10) NULL
)

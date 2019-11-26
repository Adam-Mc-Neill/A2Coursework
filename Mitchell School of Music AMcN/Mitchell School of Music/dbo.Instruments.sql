CREATE TABLE [dbo].[Instrument]
(
	[Instrument ID] INT NOT NULL PRIMARY KEY, 
    [Instrument Type] NCHAR(10) NULL, 
    [Instrument Name] NCHAR(10) NULL, 
    [Instrument Brand] NCHAR(10) NULL, 
    [Stockist ID] NCHAR(10) NULL, 
    [Instrument Cost] MONEY NULL
)

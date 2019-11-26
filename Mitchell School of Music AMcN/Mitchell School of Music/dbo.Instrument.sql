CREATE TABLE [dbo].[Instrument] (
    [Instrument ID]    INT        NOT NULL,
    [Instrument]  NVARCHAR(50) NULL,
    [Instrument Name]  NVARCHAR(50) NULL,
    [Instrument Brand] NVARCHAR(50) NULL,
    [Stockist ID]      NVARCHAR(50) NULL,
    [Instrument Cost]  MONEY      NULL,
    PRIMARY KEY CLUSTERED ([Instrument ID] ASC)
);


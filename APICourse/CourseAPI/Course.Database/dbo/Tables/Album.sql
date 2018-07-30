CREATE TABLE [dbo].[Album]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(MAX) NULL, 
    [ReleaseYear] INT NULL, 
    [Company] VARCHAR(MAX) NULL, 
    [Producer] VARCHAR(MAX) NULL
)

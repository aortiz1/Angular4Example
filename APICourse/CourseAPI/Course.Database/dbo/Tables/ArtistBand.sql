CREATE TABLE [dbo].[ArtistBand]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(MAX) NULL, 
    [Description] VARCHAR(250) NULL, 
    [Bio] VARCHAR(MAX) NULL, 
    [ArtistTypeId] UNIQUEIDENTIFIER NULL, 
    CONSTRAINT [FK_ArtistBand_ArtistType] FOREIGN KEY ([ArtistTypeId]) REFERENCES dbo.[ArtistType]([Id])
)

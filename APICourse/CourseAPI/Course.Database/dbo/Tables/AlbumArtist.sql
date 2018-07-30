CREATE TABLE [dbo].[AlbumArtist]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [AlbumId] UNIQUEIDENTIFIER NULL, 
    [ArtistBandId] UNIQUEIDENTIFIER NULL, 
    CONSTRAINT [FK_AlbumArtist_Album] FOREIGN KEY ([AlbumId]) REFERENCES dbo.[Album]([Id]), 
    CONSTRAINT [FK_AlbumArtist_ArtistBand] FOREIGN KEY ([ArtistBandId]) REFERENCES dbo.[ArtistBand]([Id])
)

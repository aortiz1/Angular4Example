﻿CREATE TABLE [dbo].[ArtistType]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [TypeArtistId] UNIQUEIDENTIFIER NULL
)
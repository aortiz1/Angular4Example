﻿CREATE TABLE [dbo].[PlayListSong]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Added] DATETIME NULL DEFAULT CURRENT_TIMESTAMP, 
    [SongId] UNIQUEIDENTIFIER NULL, 
    [PlayListId] UNIQUEIDENTIFIER NULL, 
    CONSTRAINT [FK_PlayListSong_Song] FOREIGN KEY ([SongId]) REFERENCES dbo.[Song]([Id]), 
    CONSTRAINT [FK_PlayListSong_PlayList] FOREIGN KEY ([PlayListId]) REFERENCES dbo.[PlayList]([Id])
)

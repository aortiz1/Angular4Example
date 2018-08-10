INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'8e583d02-af6c-4992-8207-245ca647c0c3', NULL, N'Admin', N'Admin')

INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'9421608e-a627-4240-bd4e-636c6c6e5505', 0, N'73e3103b-8246-48e6-8d9e-0c23b033ca87', N'admin@test.com', 0, 1, NULL, N'ADMIN@TEST.COM', N'ADMIN@TEST.COM', N'AQAAAAEAACcQAAAAEIl1GGRx/DRWoNJl9R2hIKZRo8fZKHm/y5TtbXfRmQawZ8FJTomhMdoO158FKbB/5w==', NULL, 0, N'914e1bab-15fe-4dbb-8725-9f25a7ff7745', 0, N'admin@test.com')

INSERT [dbo].[AspNetUserRoles] ([Id], [UserId], [RoleId]) VALUES (N'11ed395b-a719-4358-8eaf-a12625d281c7', N'9421608e-a627-4240-bd4e-636c6c6e5505', N'8e583d02-af6c-4992-8207-245ca647c0c3')



INSERT [dbo].[Album] ([Id], [Name], [ReleaseYear], [Company], [Producer]) VALUES (N'6f94d163-890e-4af2-ae70-b160c0f530cb', N'My first album', 2015, N'Some name records', N'blah')

INSERT [dbo].[ArtistType] ([Id], [Name], [TypeArtistId]) VALUES (N'e2021217-0242-402a-a39f-0d6904201a09', N'Solo', NULL)
INSERT [dbo].[ArtistType] ([Id], [Name], [TypeArtistId]) VALUES (N'5c1324c6-aa74-4636-9d82-48b6b94f3a6e', N'Band', NULL)

INSERT [dbo].[ArtistBand] ([Id], [Name], [Description], [Bio], [ArtistTypeId]) VALUES (N'9740029b-eb47-41fe-8eb3-6a1f75fe4638', N'Jhonny Cornman', N'bleh', N'bleh', NULL)

INSERT [dbo].[AlbumArtist] ([Id], [AlbumId], [ArtistBandId]) VALUES (N'2ca334f3-4c0e-4592-84fd-d0b9fe0c5d8f', N'6f94d163-890e-4af2-ae70-b160c0f530cb', N'9740029b-eb47-41fe-8eb3-6a1f75fe4638')


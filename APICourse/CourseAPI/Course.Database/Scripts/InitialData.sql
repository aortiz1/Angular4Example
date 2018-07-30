INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'8e583d02-af6c-4992-8207-245ca647c0c3', NULL, N'Admin', N'Admin')

INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'9421608e-a627-4240-bd4e-636c6c6e5505', 0, N'73e3103b-8246-48e6-8d9e-0c23b033ca87', N'admin@test.com', 0, 1, NULL, N'ADMIN@TEST.COM', N'ADMIN@TEST.COM', N'AQAAAAEAACcQAAAAEIl1GGRx/DRWoNJl9R2hIKZRo8fZKHm/y5TtbXfRmQawZ8FJTomhMdoO158FKbB/5w==', NULL, 0, N'914e1bab-15fe-4dbb-8725-9f25a7ff7745', 0, N'admin@test.com')

INSERT [dbo].[AspNetUserRoles] ([Id], [UserId], [RoleId]) VALUES (N'11ed395b-a719-4358-8eaf-a12625d281c7', N'9421608e-a627-4240-bd4e-636c6c6e5505', N'8e583d02-af6c-4992-8207-245ca647c0c3')


BEGIN TRANSACTION;
GO

ALTER TABLE [UserProfiles] ADD [SpragueLogin] nvarchar(max) NOT NULL DEFAULT N'';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221006234200_Add SpragueLogin to UserProfile', N'6.0.9');
GO

COMMIT;
GO


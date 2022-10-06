IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Users] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Recipes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [ImagePath] nvarchar(max) NOT NULL,
    [Difficulty] int NOT NULL,
    [Time] int NOT NULL,
    [UserId] int NOT NULL,
    CONSTRAINT [PK_Recipes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Recipes_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Ingredients] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Amount] int NOT NULL,
    [RecipeId] int NOT NULL,
    CONSTRAINT [PK_Ingredients] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Ingredients_Recipes_RecipeId] FOREIGN KEY ([RecipeId]) REFERENCES [Recipes] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Ingredients_RecipeId] ON [Ingredients] ([RecipeId]);
GO

CREATE INDEX [IX_Recipes_UserId] ON [Recipes] ([UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221005031207_01 - Initial-Migration', N'6.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Ingredients] DROP CONSTRAINT [FK_Ingredients_Recipes_RecipeId];
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Ingredients]') AND [c].[name] = N'RecipeId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Ingredients] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Ingredients] ALTER COLUMN [RecipeId] int NULL;
GO

ALTER TABLE [Ingredients] ADD CONSTRAINT [FK_Ingredients_Recipes_RecipeId] FOREIGN KEY ([RecipeId]) REFERENCES [Recipes] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221005035941_02 - Second Migration', N'6.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Ingredients] DROP CONSTRAINT [FK_Ingredients_Recipes_RecipeId];
GO

DROP INDEX [IX_Ingredients_RecipeId] ON [Ingredients];
DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Ingredients]') AND [c].[name] = N'RecipeId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Ingredients] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Ingredients] ALTER COLUMN [RecipeId] int NOT NULL;
ALTER TABLE [Ingredients] ADD DEFAULT 0 FOR [RecipeId];
CREATE INDEX [IX_Ingredients_RecipeId] ON [Ingredients] ([RecipeId]);
GO

ALTER TABLE [Ingredients] ADD CONSTRAINT [FK_Ingredients_Recipes_RecipeId] FOREIGN KEY ([RecipeId]) REFERENCES [Recipes] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221005154016_Add IngredientCategory entity to database', N'6.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [IngredientCategories] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_IngredientCategories] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221005154315_Add IngredientCategory to context', N'6.0.9');
GO

COMMIT;
GO


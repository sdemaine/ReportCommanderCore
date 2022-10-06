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


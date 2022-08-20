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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220728182252_00')
BEGIN
    CREATE TABLE [Produto] (
        [Id] int NOT NULL IDENTITY,
        [Descricao] varchar(250) NOT NULL,
        [DataCadastro] datetime NOT NULL,
        [DataAlteracao] datetime NULL,
        CONSTRAINT [PK_Produto] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220728182252_00')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAlteracao', N'DataCadastro', N'Descricao') AND [object_id] = OBJECT_ID(N'[Produto]'))
        SET IDENTITY_INSERT [Produto] ON;
    EXEC(N'INSERT INTO [Produto] ([Id], [DataAlteracao], [DataCadastro], [Descricao])
    VALUES (1, NULL, ''2022-07-28T15:22:52.364'', ''Produto 01'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAlteracao', N'DataCadastro', N'Descricao') AND [object_id] = OBJECT_ID(N'[Produto]'))
        SET IDENTITY_INSERT [Produto] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220728182252_00')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAlteracao', N'DataCadastro', N'Descricao') AND [object_id] = OBJECT_ID(N'[Produto]'))
        SET IDENTITY_INSERT [Produto] ON;
    EXEC(N'INSERT INTO [Produto] ([Id], [DataAlteracao], [DataCadastro], [Descricao])
    VALUES (2, NULL, ''2022-07-28T15:22:52.364'', ''Produto 02'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAlteracao', N'DataCadastro', N'Descricao') AND [object_id] = OBJECT_ID(N'[Produto]'))
        SET IDENTITY_INSERT [Produto] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220728182252_00')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220728182252_00', N'6.0.4');
END;
GO

COMMIT;
GO


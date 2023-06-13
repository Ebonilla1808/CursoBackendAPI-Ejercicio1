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

CREATE TABLE [Cursos] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NOT NULL,
    [DescripcionCorta] nvarchar(280) NOT NULL,
    [DescripcionLarga] nvarchar(max) NOT NULL,
    [PublicoObjetivo] nvarchar(max) NOT NULL,
    [Objetivos] nvarchar(max) NOT NULL,
    [Requisitos] nvarchar(max) NOT NULL,
    [Nivel] int NOT NULL,
    CONSTRAINT [PK_Cursos] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230613043257_Creating Curso table', N'7.0.5');
GO

COMMIT;
GO


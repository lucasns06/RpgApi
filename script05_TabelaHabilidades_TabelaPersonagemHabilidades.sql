﻿BEGIN TRANSACTION;
GO

CREATE TABLE [TB_HABILIDADES] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Dano] int NOT NULL,
    CONSTRAINT [PK_TB_HABILIDADES] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [TB_PERSONAGENS_HABILIDADES] (
    [PersonagemId] int NOT NULL,
    [HabilidadeId] int NOT NULL,
    CONSTRAINT [PK_TB_PERSONAGENS_HABILIDADES] PRIMARY KEY ([PersonagemId], [HabilidadeId]),
    CONSTRAINT [FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId] FOREIGN KEY ([HabilidadeId]) REFERENCES [TB_HABILIDADES] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId] FOREIGN KEY ([PersonagemId]) REFERENCES [TB_PERSONAGENS] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_HABILIDADES]'))
    SET IDENTITY_INSERT [TB_HABILIDADES] ON;
INSERT INTO [TB_HABILIDADES] ([Id], [Dano], [Nome])
VALUES (1, 39, 'Adormecer'),
(2, 41, 'Congelar'),
(3, 37, 'Hipnotizar');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_HABILIDADES]'))
    SET IDENTITY_INSERT [TB_HABILIDADES] OFF;
GO

UPDATE [TB_USUARIOS] SET [PasswordHash] = 0x2E1CDAF0E481C1306D6C5C28585CF38E3136498511F43B7711E27C0A3F7B67B1E765238C1AB23ACD2C105EE2818C37B2BB82C794C982B76B257C64B5C62D33DC, [PasswordSalt] = 0x9AE11C6A6BC1B69C4DE84D59340C835BA667A4DDA162CFE0EE6BA46EC580190568FCC12B8D7DDA433E05BBCAD6A240C11E6660D0790DD2854BABF226AEA3DD3A48CCD923ECEF4A06194E584C0B75E6D770AF187CDEA0B0FAC759929B35DA1B6BE17FEA8B8C83290632D2AFB9BFED83AD821FB99154110C3BDB0F2A46F863774C
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'HabilidadeId', N'PersonagemId') AND [object_id] = OBJECT_ID(N'[TB_PERSONAGENS_HABILIDADES]'))
    SET IDENTITY_INSERT [TB_PERSONAGENS_HABILIDADES] ON;
INSERT INTO [TB_PERSONAGENS_HABILIDADES] ([HabilidadeId], [PersonagemId])
VALUES (1, 1),
(2, 1),
(2, 2),
(2, 3),
(3, 3),
(3, 4),
(1, 5),
(2, 6),
(3, 7);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'HabilidadeId', N'PersonagemId') AND [object_id] = OBJECT_ID(N'[TB_PERSONAGENS_HABILIDADES]'))
    SET IDENTITY_INSERT [TB_PERSONAGENS_HABILIDADES] OFF;
GO

CREATE INDEX [IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId] ON [TB_PERSONAGENS_HABILIDADES] ([HabilidadeId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241002223552_MigracaoMuitosParaMuitos', N'8.0.8');
GO

COMMIT;
GO


CREATE TABLE [dbo].[TBTeste] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [Titulo] VARCHAR(150) NOT NULL,
    [Quantidade_De_Questoes] INT NOT NULL,
    [Prova_De_Recuperacao] INT NOT NULL,
    [Disciplina_Id] INT NOT NULL,
    [Materia_Id] INT NULL,
    CONSTRAINT [FK_TBTeste_TBDisciplina] FOREIGN KEY ([Disciplina_Id]) REFERENCES [dbo].[TBDisciplina] ([Id]),
    CONSTRAINT [FK_TBTeste_TBMateria] FOREIGN KEY ([Materia_Id]) REFERENCES [dbo].[TBMateria] ([Id]),
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


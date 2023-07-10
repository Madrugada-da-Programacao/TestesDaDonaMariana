CREATE TABLE [dbo].[TBMateria] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [Nome] VARCHAR(40) NOT NULL, 
    [Serie] INT NOT NULL, 
    [Disciplina_Id] INT NOT NULL,  
    CONSTRAINT [FK_TBMateria_TBDisciplina] FOREIGN KEY ([Disciplina_Id]) REFERENCES [dbo].[TBDisciplina] ([Id]),
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


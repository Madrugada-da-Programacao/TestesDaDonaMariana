CREATE TABLE [dbo].[TBQuestao] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [Enunciado] VARCHAR(150) NOT NULL, 
    [Texto_Opcao_A] VARCHAR(50) NOT NULL,
    [Texto_Opcao_B] VARCHAR(50) NOT NULL,
    [Texto_Opcao_C] VARCHAR(50) NOT NULL,
    [Texto_Opcao_D] VARCHAR(50) NOT NULL,
    [Resposta_Certa] VARCHAR(1) NOT NULL,
    [Materia_Id] INT NULL, 
    CONSTRAINT [FK_TBQuestao_TBMateria] FOREIGN KEY ([Materia_Id]) REFERENCES [dbo].[TBMateria] ([Id]),
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


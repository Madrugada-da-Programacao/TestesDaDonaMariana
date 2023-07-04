CREATE TABLE [dbo].[TBQuestao_Teste] (
    [Questao_Id] INT NOT NULL,
    [Teste_Id]   INT NOT NULL,
    CONSTRAINT [FK_TBQuestao_TBTeste] FOREIGN KEY ([Questao_Id]) REFERENCES [dbo].[TBQuestao] ([Id]),
    CONSTRAINT [FK_TBTeste_TBQuestao] FOREIGN KEY ([Teste_Id]) REFERENCES [dbo].[TBTeste] ([Id])
);


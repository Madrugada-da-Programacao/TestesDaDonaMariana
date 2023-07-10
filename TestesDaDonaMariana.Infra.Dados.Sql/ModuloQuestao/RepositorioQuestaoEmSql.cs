using TestesDaDonaMariana.Dominio.ModuloQuestao;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao
{
	public class RepositorioQuestaoEmSql : RepositorioEmSql<Questao, MapeadorQuestao>, IRepositorioQuestao
	{
		protected override string sqlInserir =>
			@"INSERT INTO [TBQUESTAO]
	            (
		            [ENUNCIADO]
				   ,[Texto_Opcao_A]
				   ,[Texto_Opcao_B]
				   ,[Texto_Opcao_C]
				   ,[Texto_Opcao_D]
				   ,[RESPOSTA_CERTA]
				   ,[MATERIA_ID]
	            )
	            VALUES
	            (
		            @ENUNCIADO
		           ,@TEXTO_OPCAO_A
				   ,@TEXTO_OPCAO_B
				   ,@TEXTO_OPCAO_C
				   ,@TEXTO_OPCAO_D
				   ,@RESPOSTA_CERTA
				   ,@MATERIA_ID
	            );
            SELECT SCOPE_IDENTITY();";

		protected override string sqlEditar =>
			@"UPDATE [TBQUESTAO]
                   SET
                       [ENUNCIADO] =      @ENUNCIADO
				      ,[Texto_Opcao_A] =  @TEXTO_OPCAO_A
				      ,[Texto_Opcao_B] =  @TEXTO_OPCAO_B
				      ,[Texto_Opcao_C] =  @TEXTO_OPCAO_C
				      ,[Texto_Opcao_D] =  @TEXTO_OPCAO_D
				      ,[RESPOSTA_CERTA] = @RESPOSTA_CERTA
					  ,[MATERIA_ID] =     @MATERIA_ID
                 WHERE
	                [ID] = @ID";

		protected override string sqlExcluir =>
			@"DELETE FROM [TBQUESTAO]
                 WHERE
	                [ID] = @ID";

		protected override string sqlSelecionarTodos =>
		   @"SELECT 
                Q.[ID]				 QUESTAO_ID
	           ,Q.[ENUNCIADO]		 QUESTAO_ENUNCIADO
	           ,Q.[Texto_Opcao_A]    QUESTAO_TEXTO_OPCAO_A
	           ,Q.[Texto_Opcao_B]    QUESTAO_TEXTO_OPCAO_B
	           ,Q.[Texto_Opcao_C]    QUESTAO_TEXTO_OPCAO_C
	           ,Q.[Texto_Opcao_D]    QUESTAO_TEXTO_OPCAO_D
	           ,Q.[RESPOSTA_CERTA]   QUESTAO_RESPOSTA_CERTA
			   ,M.[ID]               MATERIA_ID
	           ,M.[NOME]             MATERIA_NOME
	           ,M.[SERIE]            MATERIA_SERIE
			   ,D.[ID]               DISCIPLINA_ID
               ,D.[NOME]             DISCIPLINA_NOME
            FROM 
	            [TBQUESTAO] as Q
			INNER JOIN [TBMATERIA] AS M
					    ON Q.MATERIA_ID = M.ID
			INNER JOIN [TBDISCIPLINA] AS D
					    ON M.DISCIPLINA_ID = D.ID";

		protected override string sqlSelecionarPorId =>
		   @"SELECT 
                Q.[ID]				 QUESTAO_ID
	           ,Q.[ENUNCIADO]		 QUESTAO_ENUNCIADO
	           ,Q.[Texto_Opcao_A]    QUESTAO_TEXTO_OPCAO_A
	           ,Q.[Texto_Opcao_B]    QUESTAO_TEXTO_OPCAO_B
	           ,Q.[Texto_Opcao_C]    QUESTAO_TEXTO_OPCAO_C
	           ,Q.[Texto_Opcao_D]    QUESTAO_TEXTO_OPCAO_D
	           ,Q.[RESPOSTA_CERTA]   QUESTAO_RESPOSTA_CERTA
			   ,M.[ID]               MATERIA_ID
	           ,M.[NOME]             MATERIA_NOME
	           ,M.[SERIE]            MATERIA_SERIE
			   ,D.[ID]               DISCIPLINA_ID
               ,D.[NOME]             DISCIPLINA_NOME
            FROM 
	            [TBQUESTAO] as Q
			INNER JOIN [TBMATERIA] AS M
					    ON Q.MATERIA_ID = M.ID
			INNER JOIN [TBDISCIPLINA] AS D
					    ON M.DISCIPLINA_ID = D.ID
            WHERE 
                [ID] = @ID";
	}
}

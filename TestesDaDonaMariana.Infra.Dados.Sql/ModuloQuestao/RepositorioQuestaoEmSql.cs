using TestesDaDonaMariana.Dominio.ModuloQuestao;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao
{
	public class RepositorioQuestaoEmSql : RepositorioEmSql<Questao, MapeadorQuestao>, IRepositorioQuestao
	{
		//TODO adicionar materia
		protected override string sqlInserir =>
			@"INSERT INTO [TBQuestao]
	            (
		            [Enunciado]
				   ,[Texto_Opcao_A]
				   ,[Texto_Opcao_B]
				   ,[Texto_Opcao_C]
				   ,[Texto_Opcao_D]
				   ,[Resposta_Certa]
	            )
	            VALUES
	            (
		            @ENUNCIADO
		           ,@TEXTO_OPCAO_A
				   ,@TEXTO_OPCAO_B
				   ,@TEXTO_OPCAO_C
				   ,@TEXTO_OPCAO_D
				   ,@RESPOSTA_CERTA
	            );
            SELECT SCOPE_IDENTITY();";

		//TODO adicionar materia
		protected override string sqlEditar =>
			@"UPDATE [TBQuestao]
                   SET
                       [Enunciado] = @ENUNCIADO
				      ,[Texto_Opcao_A] = @TEXTO_OPCAO_A
				      ,[Texto_Opcao_B] = @TEXTO_OPCAO_B
				      ,[Texto_Opcao_C] = @TEXTO_OPCAO_C
				      ,[Texto_Opcao_D] = @TEXTO_OPCAO_D
				      ,[Resposta_Certa] = @RESPOSTA_CERTA
                 WHERE
	                [ID] = @ID";

		//TODO adicionar materia
		protected override string sqlExcluir =>
			@"DELETE FROM [TBQuestao]
                 WHERE
	                [ID] = @ID";

		//TODO adicionar materia
		protected override string sqlSelecionarTodos =>
		   @"SELECT 
                [ID]				 QUESTAO_ID
	           ,[Enunciado]			 QUESTAO_ENUNCIADO
	           ,[Texto_Opcao_A]      QUESTAO_TEXTO_OPCAO_A
	           ,[Texto_Opcao_B]      QUESTAO_TEXTO_OPCAO_B
	           ,[Texto_Opcao_C]      QUESTAO_TEXTO_OPCAO_C
	           ,[Texto_Opcao_D]      QUESTAO_TEXTO_OPCAO_D
	           ,[Resposta_Certa]     QUESTAO_RESPOSTA_CERTA
            FROM 
	            [TBQuestao]";

		//TODO adicionar materia
		protected override string sqlSelecionarPorId =>
		   @"SELECT 
                [ID]				 QUESTAO_ID
	           ,[Enunciado]			 QUESTAO_ENUNCIADO
	           ,[Texto_Opcao_A]      QUESTAO_TEXTO_OPCAO_A
	           ,[Texto_Opcao_B]      QUESTAO_TEXTO_OPCAO_B
	           ,[Texto_Opcao_C]      QUESTAO_TEXTO_OPCAO_C
	           ,[Texto_Opcao_D]      QUESTAO_TEXTO_OPCAO_D
	           ,[Resposta_Certa]     QUESTAO_RESPOSTA_CERTA
            FROM 
	            [TBQuestao] 
            WHERE 
                [ID] = @ID";
	}
}

using Microsoft.Data.SqlClient;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloTeste
{
	public class RepositorioTesteEmSql : RepositorioEmSql<Teste, MapeadorTeste>, IRepositorioTeste
	{
		#region query
		protected override string sqlInserir =>
			@"INSERT INTO [TBTESTE]
	            (
		            [TITULO]
				   ,[QUANTIDADE_DE_QUESTOES]
				   ,[PROVA_DE_RECUPERACAO]
				   ,[DISCIPLINA_ID]
				   ,[MATERIA_ID]
	            )
	            VALUES
	            (
		            @TITULO
		           ,@QUANTIDADE_DE_QUESTOES
				   ,@PROVA_DE_RECUPERACAO
				   ,@DISCIPLINA_ID
				   ,@MATERIA_ID
	            );
            SELECT SCOPE_IDENTITY();";

		protected override string sqlEditar =>
			@"UPDATE [TBTESTE]
                   SET
                       [TITULO] =      @TITULO
				      ,[QUANTIDADE_DE_QUESTOES] =  @QUANTIDADE_DE_QUESTOES
				      ,[PROVA_DE_RECUPERACAO] =  @PROVA_DE_RECUPERACAO
				      ,[DISCIPLINA_ID] =  @DISCIPLINA_ID
				      ,[MATERIA_ID] =  @MATERIA_ID
                 WHERE
	                [ID] = @ID";

		protected override string sqlExcluir =>
			@"DELETE FROM [TBTESTE]
                 WHERE
	                [ID] = @ID";

		protected override string sqlSelecionarTodos =>
		   @"SELECT 
				T.[ID]                        AS TESTE_ID,
				T.[TITULO]                    AS TESTE_TITULO,
				T.[QUANTIDADE_DE_QUESTOES]    AS TESTE_QUANTIDADE_DE_QUESTOES,
				T.[PROVA_DE_RECUPERACAO]      AS TESTE_PROVA_DE_RECUPERACAO,
				T.[DISCIPLINA_ID]             AS TESTE_DISCIPLINA_ID,
				T.[MATERIA_ID]                AS TESTE_MATERIA_ID,
				D.[ID]                        AS DISCIPLINA_ID,
				D.[NOME]                      AS DISCIPLINA_NOME,
				M.[ID]                        AS MATERIA_ID,
				M.[NOME]                      AS MATERIA_NOME,
				M.[SERIE]                     AS MATERIA_SERIE,
				M.[DISCIPLINA_ID]             AS MATERIA_DISCIPLINA_ID
			FROM 
				[TBTESTE] AS T
			INNER JOIN [TBDISCIPLINA] AS D
				ON T.DISCIPLINA_ID = D.ID
			LEFT JOIN [TBMATERIA] AS M
				ON T.MATERIA_ID = M.ID";

		protected override string sqlSelecionarPorId =>
		   @"SELECT 
                T.[ID]				          TESTE_ID
	           ,T.[TITULO]		              TESTE_TITULO
	           ,T.[QUANTIDADE_DE_QUESTOES]    TESTE_QUANTIDADE_DE_QUESTOES
	           ,T.[PROVA_DE_RECUPERACAO]      TESTE_PROVA_DE_RECUPERACAO
	           ,T.[DISCIPLINA_ID]             TESTE_DISCIPLINA_ID
			   ,T.[MATERIA_ID]                TESTE_MATERIA_ID
	           ,D.[ID]                        DISCIPLINA_ID
               ,D.[NOME]                      DISCIPLINA_NOME
	           ,M.[ID]                        MATERIA_ID
	           ,M.[NOME]                      MATERIA_NOME
	           ,M.[SERIE]                     MATERIA_SERIE
			   ,M.[DISCIPLINA_ID]             DISCIPLINA_ID
            FROM 
				[TBTESTE] AS T
			INNER JOIN [TBDISCIPLINA] AS D
				ON T.DISCIPLINA_ID = D.ID
			LEFT JOIN [TBMATERIA] AS M
				ON T.MATERIA_ID = M.ID
            WHERE 
                T.[ID] = @ID";

		private const string sqlAdicionarQuestao =
			@"INSERT INTO [TBQUESTAO_TESTE]
                (
                    [TESTE_ID]
                   ,[QUESTAO_ID])
            VALUES
                (
                    @TESTE_ID
                   ,@QUESTAO_ID
                )";

		private const string sqlRemoverQuestao =
			@"DELETE FROM [TBQUESTAO_TESTE] 
                WHERE TESTE_ID = @TESTE_ID AND QUESTAO_ID = @QUESTAO_ID";


		private const string sqlCarregarQuestoes =
			@"SELECT 
					Q.[ID]				 QUESTAO_ID
				   ,Q.[ENUNCIADO]		 QUESTAO_ENUNCIADO
				   ,Q.[Texto_Opcao_A]    QUESTAO_TEXTO_OPCAO_A
				   ,Q.[Texto_Opcao_B]    QUESTAO_TEXTO_OPCAO_B
				   ,Q.[Texto_Opcao_C]    QUESTAO_TEXTO_OPCAO_C
				   ,Q.[Texto_Opcao_D]    QUESTAO_TEXTO_OPCAO_D
				   ,Q.[RESPOSTA_CERTA]   QUESTAO_RESPOSTA_CERTA
				   ,TBT.TESTE_ID        TESTE_ID   
				   ,M.ID                MATERIA_ID
				   ,M.NOME              MATERIA_NOME
				   ,M.DISCIPLINA_ID     DISCIPLINA_ID
				   ,M.SERIE             MATERIA_SERIE
				   ,D.ID             DISCIPLINA_ID
				   ,D.NOME           DISCIPLINA_NOME
                                                       
				FROM 
					[TBQUESTAO] Q
					INNER JOIN TBQUESTAO_TESTE TBT
						ON Q.ID = TBT.QUESTAO_ID
					INNER JOIN TBMATERIA M
						ON Q.MATERIA_ID = M.ID
					INNER JOIN TBDISCIPLINA D
						ON M.DISCIPLINA_ID = D.ID
				WHERE
					TBT.TESTE_ID = @TESTE_ID";

		#endregion

		public void Inserir(Teste teste, List<Questao> questoes)
		{	
			//obter a conexão com o banco e abrir ela
			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			//cria um comando e relaciona com a conexão aberta
			SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
			comandoInserir.CommandText = sqlInserir;

			//adiciona os parâmetros no comando
			MapeadorTeste mapeadorTeste = new MapeadorTeste();
			mapeadorTeste.ConfigurarParametros(comandoInserir, teste);

			//executa o comando
			object id = comandoInserir.ExecuteScalar();

			teste.Id = Convert.ToInt32(id);

			//encerra a conexão
			conexaoComBanco.Close();

			foreach (Questao questao in questoes)
			{
				AdicionarQuestaoAoTeste(teste, questao);
			}
		}

		private void AdicionarQuestaoAoTeste(Teste teste, Questao questao)
		{
			//obter a conexão com o banco e abrir ela
			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			//cria um comando e relaciona com a conexão aberta
			SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
			comandoInserir.CommandText = sqlAdicionarQuestao;

			//adiciona os parâmetros no comando
			comandoInserir.Parameters.AddWithValue("TESTE_ID", teste.Id);
			comandoInserir.Parameters.AddWithValue("QUESTAO_ID", questao.Id);

			//executa o comando
			comandoInserir.ExecuteNonQuery();

			//fecha conexão
			conexaoComBanco.Close();
		}


		public void Excluir(Teste teste)
		{
			foreach (Questao questao in teste.Questoes)
			{
				RemoverQuestao(teste, questao);
			}

			//obter a conexão com o banco e abrir ela
			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			//cria um comando e relaciona com a conexão aberta
			SqlCommand comandoExcluir = conexaoComBanco.CreateCommand();
			comandoExcluir.CommandText = sqlExcluir;

			//adiciona os parâmetros no comando
			comandoExcluir.Parameters.AddWithValue("ID", teste.Id);

			//executa o comando
			comandoExcluir.ExecuteNonQuery();

			//encerra a conexão
			conexaoComBanco.Close();
		}

		private void RemoverQuestao(Teste teste, Questao questao)
		{
			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
			comandoInserir.CommandText = sqlRemoverQuestao;

			comandoInserir.Parameters.AddWithValue("TESTE_ID", teste.Id);
			comandoInserir.Parameters.AddWithValue("QUESTAO_ID", questao.Id);

			comandoInserir.ExecuteNonQuery();

			conexaoComBanco.Close();
		}

		public void CarregarQuestoes(Teste teste)
		{
			SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
			conexaoComBanco.Open();

			SqlCommand comandoSelecionarItens = conexaoComBanco.CreateCommand();
			comandoSelecionarItens.CommandText = sqlCarregarQuestoes;

			comandoSelecionarItens.Parameters.AddWithValue("TESTE_ID", teste.Id);
			//comandoSelecionarItens.Parameters.AddWithValue("MATERIA_ID", teste.Materia.Id);
			comandoSelecionarItens.Parameters.AddWithValue("DISCIPLINA_ID", teste.Disciplina.Id);
			
			SqlDataReader leitorQuestao = comandoSelecionarItens.ExecuteReader();

			while (leitorQuestao.Read())
			{
				MapeadorQuestao mapeador = new MapeadorQuestao();

				Questao questao = mapeador.ConverterRegistro(leitorQuestao);

				teste.AdicionarQuestao(questao);
			}

			conexaoComBanco.Close();
		}

		public Teste SelecionarPeloId(int id)
		{
			Teste teste = base.SelecionarPeloId(id);

			if (teste != null)
				CarregarQuestoes(teste);

			return teste;
		}
	}
}

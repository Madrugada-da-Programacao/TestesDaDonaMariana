using Microsoft.Data.SqlClient;
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloTeste
{
	public class MapeadorTeste : MapeadorBase<Teste>
	{
		public override void ConfigurarParametros(SqlCommand comando, Teste registro)
		{
			comando.Parameters.AddWithValue("ID", registro.Id);
			comando.Parameters.AddWithValue("TITULO", registro.Titulo);
			comando.Parameters.AddWithValue("QUANTIDADE_DE_QUESTOES", registro.QuantidadeDeQuestoes);
			comando.Parameters.AddWithValue("PROVA_DE_RECUPERACAO", registro.ProvaDeRecuperacao);

			comando.Parameters.AddWithValue("DISCIPLINA_ID", registro.Disciplina.Id);

			if (registro.Materia == null)
				comando.Parameters.AddWithValue("MATERIA_ID", DBNull.Value);
			else
				comando.Parameters.AddWithValue("MATERIA_ID", registro.Materia.Id);
		}

		public override Teste ConverterRegistro(SqlDataReader leitorRegistros)
		{
			int id = Convert.ToInt32(leitorRegistros["TESTE_ID"]);

			string titulo = Convert.ToString(leitorRegistros["TESTE_TITULO"])!;

			int quantidadeDeQuestoes = Convert.ToInt32(leitorRegistros["TESTE_QUANTIDADE_DE_QUESTOES"])!;
			bool provaDeRecuperacao = Convert.ToBoolean(leitorRegistros["TESTE_PROVA_DE_RECUPERACAO"])!;
			
			Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);

			Materia materia = null;
			if (leitorRegistros["MATERIA_ID"] != DBNull.Value)
			{
				materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);
			}

			Teste teste = new Teste(id, titulo, quantidadeDeQuestoes, provaDeRecuperacao, disciplina, materia);

			return teste;
		}
	}
}

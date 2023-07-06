using Microsoft.Data.SqlClient;
using TestesDaDonaMariana.Dominio.ModuloQuestao;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao
{
	public class MapeadorQuestao : MapeadorBase<Questao>
	{
		//TODO adicionar materia
		public override void ConfigurarParametros(SqlCommand comando, Questao registro)
		{
			comando.Parameters.AddWithValue("ID", registro.Id);

			comando.Parameters.AddWithValue("ENUNCIADO", registro.Enunciado);

			comando.Parameters.AddWithValue("TEXTO_OPCAO_A", registro.TextoOpcaoA);
			comando.Parameters.AddWithValue("TEXTO_OPCAO_B", registro.TextoOpcaoB);
			comando.Parameters.AddWithValue("TEXTO_OPCAO_C", registro.TextoOpcaoC);
			comando.Parameters.AddWithValue("TEXTO_OPCAO_D", registro.TextoOpcaoD);

			comando.Parameters.AddWithValue("RESPOSTA_CERTA", registro.RespostaCerta);

			//comando.Parameters.AddWithValue("MATERIA", registro.Materia);
		}

		//TODO adicionar materia
		public override Questao ConverterRegistro(SqlDataReader leitorRegistros)
		{
			int id = Convert.ToInt32(leitorRegistros["QUESTAO_ID"]);

			string enunciado = Convert.ToString(leitorRegistros["QUESTAO_ENUNCIADO"])!;

			string textoOpcaoA = Convert.ToString(leitorRegistros["QUESTAO_TEXTO_OPCAO_A"])!;
			string textoOpcaoB = Convert.ToString(leitorRegistros["QUESTAO_TEXTO_OPCAO_B"])!;
			string textoOpcaoC = Convert.ToString(leitorRegistros["QUESTAO_TEXTO_OPCAO_C"])!;
			string textoOpcaoD = Convert.ToString(leitorRegistros["QUESTAO_TEXTO_OPCAO_D"])!;

			char respostaCerta = Convert.ToChar(leitorRegistros["QUESTAO_RESPOSTA_CERTA"])!;

			//Materia materia = Repositorio.SelecionarPorId(Convert.ToInt32(leitorRegistros["QUESTAO_MATERIA"]));

			Questao questao = new Questao(id, enunciado, textoOpcaoA, textoOpcaoB, textoOpcaoC, textoOpcaoD, respostaCerta);//, materia);

			return questao;
		}
	}
}

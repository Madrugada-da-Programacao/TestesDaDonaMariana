using Microsoft.Data.SqlClient;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao
{
	public class MapeadorQuestao : MapeadorBase<Questao>
	{
		public override void ConfigurarParametros(SqlCommand comando, Questao registro)
		{
			comando.Parameters.AddWithValue("ID", registro.Id);

			comando.Parameters.AddWithValue("ENUNCIADO", registro.Enunciado);

			comando.Parameters.AddWithValue("TEXTO_OPCAO_A", registro.TextoOpcaoA);
			comando.Parameters.AddWithValue("TEXTO_OPCAO_B", registro.TextoOpcaoB);
			comando.Parameters.AddWithValue("TEXTO_OPCAO_C", registro.TextoOpcaoC);
			comando.Parameters.AddWithValue("TEXTO_OPCAO_D", registro.TextoOpcaoD);

			comando.Parameters.AddWithValue("RESPOSTA_CERTA", registro.RespostaCerta);

			comando.Parameters.AddWithValue("MATERIA_ID", registro.Materia.Id);
		}

		public override Questao ConverterRegistro(SqlDataReader leitorRegistros)
		{
			int id = Convert.ToInt32(leitorRegistros["QUESTAO_ID"]);

			string enunciado = Convert.ToString(leitorRegistros["QUESTAO_ENUNCIADO"])!;

			string textoOpcaoA = Convert.ToString(leitorRegistros["QUESTAO_TEXTO_OPCAO_A"])!;
			string textoOpcaoB = Convert.ToString(leitorRegistros["QUESTAO_TEXTO_OPCAO_B"])!;
			string textoOpcaoC = Convert.ToString(leitorRegistros["QUESTAO_TEXTO_OPCAO_C"])!;
			string textoOpcaoD = Convert.ToString(leitorRegistros["QUESTAO_TEXTO_OPCAO_D"])!;

			char respostaCerta = Convert.ToChar(leitorRegistros["QUESTAO_RESPOSTA_CERTA"])!;

			Materia materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);

			Questao questao = new Questao(id, enunciado, textoOpcaoA, textoOpcaoB, textoOpcaoC, textoOpcaoD, respostaCerta, materia);

			return questao;
		}
	}
}

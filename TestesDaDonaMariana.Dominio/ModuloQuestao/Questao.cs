using System.Drawing;

namespace TestesDaDonaMariana.Dominio.ModuloQuestao
{
	public class Questao : Entidade<Questao>
	{
		public string Enunciado { get; set; }
		public string TextoOpcaoA { get; set; }
		public string TextoOpcaoB { get; set; }
		public string TextoOpcaoC { get; set; }
		public string TextoOpcaoD { get; set; }
		public char RespostaCerta { get; set; }
		//TODO adicionar materia
		//public Materia Materia { get; set; }

		//TODO adicionar materia
		public Questao(string enunciado, string textoOpcaoA, string textoOpcaoB, string textoOpcaoC, string textoOpcaoD, char respostaCerta)//, Materia materia)
		{
			Enunciado = enunciado;
			TextoOpcaoA = textoOpcaoA;
			TextoOpcaoB = textoOpcaoB;
			TextoOpcaoC = textoOpcaoC;
			TextoOpcaoD = textoOpcaoD;
			RespostaCerta = respostaCerta;
			//Materia = materia;
		}

		//TODO adicionar materia
		public Questao(int id, string enunciado, string textoOpcaoA, string textoOpcaoB, string textoOpcaoC, string textoOpcaoD, char respostaCerta)//, Materia materia)
			: this(enunciado, textoOpcaoA, textoOpcaoB, textoOpcaoC, textoOpcaoD, respostaCerta)// materia)
		{
			Id = id;
		}

		public override List<string> Validar()
		{
			List<string> erros = new List<string>();
			if (string.IsNullOrWhiteSpace(Enunciado))
				erros.Add("Digite um Enunciado valido");
			if (string.IsNullOrWhiteSpace(TextoOpcaoA))
				erros.Add("Digite um Texto para a Opção A valido");
			if (string.IsNullOrWhiteSpace(TextoOpcaoB))
				erros.Add("Digite um Texto para a Opção B valido");
			if (string.IsNullOrWhiteSpace(TextoOpcaoC))
				erros.Add("Digite um Texto para a Opção C valido");
			if (string.IsNullOrWhiteSpace(TextoOpcaoD))
				erros.Add("Digite um Texto para a Opção D valido");
			//TODO adicionar materia
			//if (Materia = null)
			//	erros.Add("Selecione uma Materia");

			return erros;
		}

		public override bool Equals(object? obj)
		{
			return obj is Questao questao &&
				Id == questao.Id &&
				TextoOpcaoA == questao.TextoOpcaoA &&
				TextoOpcaoB == questao.TextoOpcaoB &&
				TextoOpcaoC == questao.TextoOpcaoC &&
				TextoOpcaoD == questao.TextoOpcaoD &&
				RespostaCerta == questao.RespostaCerta;
				//TODO adicionar materia
				//Materia == questao.Materia;
		}
	}
}

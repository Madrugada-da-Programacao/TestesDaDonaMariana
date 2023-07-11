using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;

namespace TestesDaDonaMariana.Dominio.ModuloTeste
{
	public class Teste : Entidade<Teste>
	{
		public string Titulo { get; set; }
		public int QuantidadeDeQuestoes { get; set; }
		public bool ProvaDeRecuperacao { get; set; }
		public Disciplina Disciplina { get; set; }
		public Materia? Materia { get; set; }
		public List<Questao> Questoes { get; set; }

		public Teste(string titulo, int quantidadeDeQuestoes, bool provaDeRecuperacao, Disciplina disciplina, Materia materia)
		{
			Titulo = titulo;
			QuantidadeDeQuestoes = quantidadeDeQuestoes;
			ProvaDeRecuperacao = provaDeRecuperacao;
			Disciplina = disciplina;
			Materia = materia;
			Questoes = new List<Questao>();
		}

		public Teste(int id, string titulo, int quantidadeDeQuestoes, bool provaDeRecuperacao, Disciplina disciplina, Materia materia)
			: this(titulo, quantidadeDeQuestoes, provaDeRecuperacao, disciplina, materia)
		{
			Id = id;
		}

		public override List<string> Validar()
		{
			List<string> erros = new List<string>();
			if (string.IsNullOrWhiteSpace(Titulo))
				erros.Add("Digite um Titulo valido");
			if (Disciplina == null)
				erros.Add("Selecione uma Disciplina");

			return erros;
		}

		public override bool Equals(object? obj)
		{
			return obj is Teste teste &&
				Titulo == teste.Titulo &&
				QuantidadeDeQuestoes == teste.QuantidadeDeQuestoes &&
				ProvaDeRecuperacao == teste.ProvaDeRecuperacao &&
				Disciplina == teste.Disciplina &&
				Materia == teste.Materia &&
				Questoes == teste.Questoes;
		}

		public void AdicionarQuestao(Questao questo)
		{
			Questoes.Add(questo);
		}
	}
}

using TestesDaDonaMariana.Dominio.ModuloDisciplina;

namespace TestesDaDonaMariana.Dominio.ModuloMateria
{
	public class Materia : Entidade<Materia>
    {
        public string Nome { get; set; }

        public int Serie { get; set; }

        public Disciplina Disciplina { get; set; }

        public Materia(string nome, int serie, Disciplina disciplina)
        {
            Nome = nome;
            Serie = serie;
            Disciplina = disciplina;
        }

        public Materia(int id, string nome, int serie, Disciplina disciplina)
               : this(nome, serie, disciplina)
        {
            Id = id;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("Digite um Nome da Materia");
            if (string.IsNullOrWhiteSpace(Serie.ToString()))
                erros.Add("Digite um Numero Para Serie");
            if (Serie < 1 || Serie > 9)
                erros.Add("Digite uma Serie valida (1~9)");
            if (Disciplina == null)
                erros.Add("Escolha uma Disciplina");

            return erros;
        }

        public override bool Equals(object? obj)
        {
            return obj is Materia materia &&
                Id == materia.Id &&
                Nome == materia.Nome &&
                Serie == materia.Serie &&
			    Disciplina == materia.Disciplina;
        }

		public override string? ToString()
		{
			return $"{Nome} da {Serie} Série";
		}
	}
}

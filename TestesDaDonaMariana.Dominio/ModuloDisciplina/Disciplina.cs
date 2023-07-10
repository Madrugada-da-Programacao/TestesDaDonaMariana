namespace TestesDaDonaMariana.Dominio.ModuloDisciplina
{
	public class Disciplina : Entidade<Disciplina>
    {
        public string Nome { get; set; }
        public Disciplina(string nome)
        {
            Nome = nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (String.IsNullOrEmpty(Nome))
                erros.Add("O campo \"nome\" é obrigatório");

            return erros;
        }

        public List<string> Validar(List<string> nomes)
        {
            List<string> erros = Validar();

            foreach (string n in nomes)
            {
                if (Nome == n)
                    erros.Add("Esse nome já existe");
            }

            return erros;
        }

		public override string? ToString()
		{
			return Nome;
		}
	}
}

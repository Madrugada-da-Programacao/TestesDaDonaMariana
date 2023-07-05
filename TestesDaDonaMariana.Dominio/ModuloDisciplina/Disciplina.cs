using TestesDaDonaMariana.Dominio.Compartilhado;

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
    }
}

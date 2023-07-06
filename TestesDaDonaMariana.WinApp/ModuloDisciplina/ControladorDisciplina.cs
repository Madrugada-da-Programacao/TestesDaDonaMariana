using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloDisciplina
{
    public class ControladorDisciplina : Controlador
    {
        IRepositorioDisciplina repositorioDisciplina;

        public override string TipoDoCadastro => "Disciplina";

        private TabelaDisciplina TabelaDisciplina { get; set; }

        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override void Inserir()
        {
            List<string> nomes = new List<string>();
            foreach (Disciplina d in repositorioDisciplina.SelecionarTodos())
            {
                nomes.Add(d.Nome);
            }

            DialogDisciplina tela = new DialogDisciplina(nomes);

            DialogResult resultado = tela.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                repositorioDisciplina.Inserir(tela.Disciplina);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            TabelaDisciplina ??= new TabelaDisciplina(repositorioDisciplina.SelecionarTodos());

            CarregarEntidades();

            return TabelaDisciplina;
        }

        private void CarregarEntidades()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            TabelaDisciplina.AtualizarRegistros(disciplinas);
        }
    }
}

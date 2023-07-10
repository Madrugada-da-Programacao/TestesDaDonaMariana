using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.WinApp.ModuloDisciplina
{
	public class ControladorDisciplina : Controlador
    {
        private IRepositorioDisciplina RepositorioDisciplina { get; set; }
		private IRepositorioMateria RepositorioMateria { get; set; }

		public override string TipoDoCadastro => "Disciplina";

        private TabelaDisciplina TabelaDisciplina { get; set; }

        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina, IRepositorioMateria repositorioMateria)
        {
            RepositorioDisciplina = repositorioDisciplina;
            RepositorioMateria = repositorioMateria;
        }

        public override void Inserir()
        {
            List<string> nomes = ObterNomes();

            DialogDisciplina tela = new DialogDisciplina(nomes);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                RepositorioDisciplina.Inserir(tela.Disciplina);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            Disciplina? entidade = TabelaDisciplina.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione uma {TipoDoCadastro} primeiro!",
                                $"Edição de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            List<string> nomes = ObterNomes();
            nomes.Remove(entidade.Nome);

            DialogDisciplina dialog = new DialogDisciplina(nomes);
            dialog.Disciplina = entidade;


            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                RepositorioDisciplina.Editar(dialog.Disciplina);

                CarregarEntidades();
            }
        }

        public override void Excluir()
        {   
            Disciplina? entidade = TabelaDisciplina.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Exclusão de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }


            bool existeDependencia =
			RepositorioMateria.VerificarMateriaComDisciplina(entidade);

            if (existeDependencia)
            {
                MessageBox.Show($"Não é possível excluir uma {TipoDoCadastro} com matérias em aberto.",
                    $"Exclusão de {TipoDoCadastro}s",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            /*
            bool podeExcluir =
            repositorioMateria.VerificarTestesAbertosDisciplina(entidade); 

            if (!podeExcluir) 
            {
                MessageBox.Show($"Não é possível excluir uma {TipoDoCadastro} com matérias em aberto.",
                    $"Exclusão de {TipoDoCadastro}s",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            TODO*/

            DialogResult opcao = MessageBox.Show($"Deseja excluir a {TipoDoCadastro} {entidade.Nome}?",
                                                          $"Exclusão de {TipoDoCadastro}s",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Question);

            if (opcao == DialogResult.OK)
            {
                RepositorioDisciplina.Excluir(entidade);

                CarregarEntidades();
            }
        }

        public override UserControl ObterListagem()
        {
            TabelaDisciplina ??= new TabelaDisciplina(RepositorioDisciplina.SelecionarTodos());

            CarregarEntidades();

            return TabelaDisciplina;
        }

        private void CarregarEntidades()
        {
            List<Disciplina> disciplinas = RepositorioDisciplina.SelecionarTodos();

            TabelaDisciplina.AtualizarRegistros(disciplinas);
        }

        private List<string> ObterNomes()
        {
            List<string> nomes = new List<string>();
            foreach (Disciplina d in RepositorioDisciplina.SelecionarTodos())
            {
                nomes.Add(d.Nome);
            }

            return nomes;
        }
    }
}

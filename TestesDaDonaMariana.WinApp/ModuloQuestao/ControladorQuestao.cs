using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;

namespace TestesDaDonaMariana.WinApp.ModuloQuestao
{
	public class ControladorQuestao : Controlador
	{
		private IRepositorioMateria RepositorioMateria{ get; set; }
		private IRepositorioQuestao RepositorioQuestao { get; set; }
		private IRepositorioTeste RepositorioTeste{ get; set; }
		private TabelaQuestao TabelaQuestao { get; set; }

		public override string TipoDoCadastro => "Questão";

		public ControladorQuestao(IRepositorioMateria repositorioMateria, IRepositorioQuestao repositorioQuestao, IRepositorioTeste repositorioTeste)
		{
			RepositorioMateria = repositorioMateria;
			RepositorioQuestao = repositorioQuestao;
			RepositorioTeste = repositorioTeste;
		}

		public override void Inserir()
		{
			DialogQuestao dialog = new DialogQuestao(RepositorioMateria.SelecionarTodos());
			DialogResult opcaoEscolhida = dialog.ShowDialog();

			if (opcaoEscolhida == DialogResult.OK)
			{
				Questao entidade = dialog.Questao;

				RepositorioQuestao.Inserir(entidade);

				CarregarEntidades();
			}
		}

		public override void Editar()
		{
			Questao? entidade = TabelaQuestao.ObterEntidadeSelecionada();

			if (entidade == null)
			{
				MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
								$"Edição de {TipoDoCadastro}s",
								MessageBoxButtons.OK,
								MessageBoxIcon.Exclamation);

				return;
			}

			DialogQuestao dialog = new DialogQuestao(RepositorioMateria.SelecionarTodos());
			dialog.Questao = entidade;

			DialogResult opcaoEscolhida = dialog.ShowDialog();

			if (opcaoEscolhida == DialogResult.OK)
			{
				entidade = dialog.Questao;

				RepositorioQuestao.Editar(entidade);

				CarregarEntidades();
			}
		}

		
		public override void Excluir()
		{
			Questao? entidade = TabelaQuestao.ObterEntidadeSelecionada();

			if (entidade == null)
			{
				MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
								$"Exclusão de {TipoDoCadastro}s",
								MessageBoxButtons.OK,
								MessageBoxIcon.Exclamation);

				return;
			}

			bool existeDependenciaTeste =
			RepositorioTeste.VerificarQuestaoComDisciplina(entidade);

			if (existeDependenciaTeste)
			{
				MessageBox.Show($"Não é possível excluir uma {TipoDoCadastro} com matérias em aberto.",
					$"Exclusão de {TipoDoCadastro}s",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);

				return;
			}


			DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o {TipoDoCadastro} {entidade.Enunciado}?",
														  $"Exclusão de {TipoDoCadastro}s",
														  MessageBoxButtons.OKCancel,
														  MessageBoxIcon.Question);

			if (opcaoEscolhida == DialogResult.OK)
			{
				RepositorioQuestao.Excluir(entidade);

				CarregarEntidades();
			}
		}

		private void CarregarEntidades()
		{
			List<Questao> entidades = RepositorioQuestao.SelecionarTodos();

			TabelaQuestao.AtualizarRegistros(entidades);
		}

		public override UserControl ObterListagem()
		{
			TabelaQuestao ??= new TabelaQuestao(RepositorioQuestao.SelecionarTodos());

			CarregarEntidades();

			return TabelaQuestao;
		}
	}
}

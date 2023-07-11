using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;

namespace TestesDaDonaMariana.WinApp.ModuloQuestao
{
	public class ControladorQuestao : Controlador
	{
		private IRepositorioMateria RepositorioMateria{ get; set; }
		private IRepositorioQuestao RepositorioQuestao { get; set; }
		private TabelaQuestao TabelaQuestao { get; set; }

		public override string TipoDoCadastro => "Questão";

		public ControladorQuestao(IRepositorioMateria repositorioMateria, IRepositorioQuestao repositorioQuestao)
		{
			RepositorioMateria = repositorioMateria;
			RepositorioQuestao = repositorioQuestao;
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

			//TODO adicionar testes
			// if questao utilizada em algum texte não permita excluir a questão
			//if (entidade.Testes.Count > 0)
			//{
			//	MessageBox.Show($"{TipoDoCadastro} esta sendo utilizada em outro lugar!",
			//					$"Exclusão de {TipoDoCadastro}s",
			//					MessageBoxButtons.OK,
			//					MessageBoxIcon.Exclamation);
			//	return;
			//}


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

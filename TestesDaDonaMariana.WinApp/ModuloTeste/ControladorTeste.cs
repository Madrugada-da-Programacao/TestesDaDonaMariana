using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;

namespace TestesDaDonaMariana.WinApp.ModuloTeste
{
	public class ControladorTeste : Controlador
	{
		private IRepositorioDisciplina RepositorioDisciplina { get; set; }
		private IRepositorioMateria RepositorioMateria { get; set; }
		private IRepositorioQuestao RepositorioQuestao { get; set; }
		private IRepositorioTeste RepositorioTeste { get; set; }
		private TabelaTeste TabelaTeste { get; set; }

		public override string TipoDoCadastro => "Teste";

		public ControladorTeste(IRepositorioDisciplina repositorioDisciplina, IRepositorioMateria repositorioMateria, IRepositorioQuestao repositorioQuestao, IRepositorioTeste repositorioTeste)
		{
			RepositorioDisciplina = repositorioDisciplina;
			RepositorioMateria = repositorioMateria;
			RepositorioQuestao = repositorioQuestao;
			RepositorioTeste = repositorioTeste;
		}

		public override void Inserir()
		{
			DialogTeste dialog = new DialogTeste(RepositorioDisciplina.SelecionarTodos(), RepositorioMateria.SelecionarTodos(),
												RepositorioQuestao.SelecionarTodos(), RepositorioTeste.SelecionarTodos());
			DialogResult opcaoEscolhida = dialog.ShowDialog();

			if (opcaoEscolhida == DialogResult.OK)
			{
				Teste entidade = dialog.Teste;
				entidade.Questoes = dialog.QuestoesSorteadas;
				RepositorioTeste.Inserir(entidade, dialog.QuestoesSorteadas);

				CarregarEntidades();
			}
		}

		public override void Editar()
		{
			throw new NotImplementedException();
		}

		public override void Excluir()
		{
			Teste? entidade = ObterTesteSelecionado();


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


			DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o {TipoDoCadastro} {entidade.Titulo}?",
														  $"Exclusão de {TipoDoCadastro}s",
														  MessageBoxButtons.OKCancel,
														  MessageBoxIcon.Question);

			if (opcaoEscolhida == DialogResult.OK)
			{
				RepositorioTeste.Excluir(entidade);

				CarregarEntidades();
			}
		}


		private void CarregarEntidades()
		{
			List<Teste> entidades = RepositorioTeste.SelecionarTodos();

			TabelaTeste.AtualizarRegistros(entidades);
		}

		public override UserControl ObterListagem()
		{
			TabelaTeste ??= new TabelaTeste(RepositorioTeste.SelecionarTodos());

			CarregarEntidades();

			return TabelaTeste;
		}

		private Teste? ObterTesteSelecionado()
		{
			Teste teste = TabelaTeste.ObterEntidadeSelecionada()!;

			return RepositorioTeste.SelecionarPeloId(teste.Id);
		}
	}
}

﻿using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.WinApp.ModuloMateria
{
	public class ControladorMateria : Controlador
	{
		private IRepositorioMateria RepositorioMateria { get; set; }
		private TabelaMateria TabelaMateria { get; set; }


		public override string TipoDoCadastro => "Matéria";

		public ControladorMateria(IRepositorioMateria repositorioMateria)
		{
			RepositorioMateria = repositorioMateria;
		}

		public override void Inserir()
		{
			DialogMateria dialog = new DialogMateria();
			DialogResult opcaoEscolhida = dialog.ShowDialog();

			if (opcaoEscolhida == DialogResult.OK)
			{
				EMateria entidade = dialog.Materia;

				RepositorioMateria.Inserir(entidade);

				CarregarEntidades();
			}
		}

		public override void Editar()
		{
            EMateria? entidade = TabelaMateria.ObterEntidadeSelecionada();

			if (entidade == null)
			{
				MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
								$"Edição de {TipoDoCadastro}s",
								MessageBoxButtons.OK,
								MessageBoxIcon.Exclamation);

				return;
			}

			DialogMateria dialog = new DialogMateria();
			dialog.Materia = entidade;

			DialogResult opcaoEscolhida = dialog.ShowDialog();

			if (opcaoEscolhida == DialogResult.OK)
			{
				entidade = dialog.Materia;

				RepositorioMateria.Editar(entidade);

				CarregarEntidades();
			}
		}

		
		public override void Excluir()
		{
			EMateria? entidade = TabelaMateria.ObterEntidadeSelecionada();

			if (entidade == null)
			{
				MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
								$"Exclusão de {TipoDoCadastro}s",
								MessageBoxButtons.OK,
								MessageBoxIcon.Exclamation);

				return;
			}


			DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o {TipoDoCadastro} {entidade.Nome}?",
														  $"Exclusão de {TipoDoCadastro}s",
														  MessageBoxButtons.OKCancel,
														  MessageBoxIcon.Question);

			if (opcaoEscolhida == DialogResult.OK)
			{
				RepositorioMateria.Excluir(entidade);

				CarregarEntidades();
			}
		}

		private void CarregarEntidades()
		{
			List<EMateria> entidades = RepositorioMateria.SelecionarTodos();

			TabelaMateria.AtualizarRegistros(entidades);
		}

		public override UserControl ObterListagem()
		{
			TabelaMateria ??= new TabelaMateria(RepositorioMateria.SelecionarTodos());

			CarregarEntidades();

			return TabelaMateria;
		}
	}
}

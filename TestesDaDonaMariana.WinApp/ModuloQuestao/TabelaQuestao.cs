using System.ComponentModel;
using System.Data;
using TestesDaDonaMariana.Dominio.ModuloQuestao;

namespace TestesDaDonaMariana.WinApp.ModuloQuestao
{
	public partial class TabelaQuestao : UserControl
	{
		public TabelaQuestao(List<Questao> listaDeEntidades)
		{
			InitializeComponent();

			AtualizarRegistros(listaDeEntidades);

			grid.ConfigurarGridZebrado();

			grid.ConfigurarGridSomenteLeitura();
		}

		public void AtualizarRegistros(List<Questao> listaDeEntidades)
		{
			BindingList<Questao> bindingList = new BindingList<Questao>(listaDeEntidades);
			BindingSource source = new BindingSource(bindingList, null);
			grid.DataSource = source;
		}

		public Questao? ObterEntidadeSelecionada()
		{
			List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
			if (rows.Count > 0)
			{
				return rows[0].DataBoundItem as Questao;
			}
			return null;
		}
	}
}

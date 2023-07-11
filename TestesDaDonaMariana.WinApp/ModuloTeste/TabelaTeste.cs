using System.ComponentModel;
using System.Data;
using TestesDaDonaMariana.Dominio.ModuloTeste;

namespace TestesDaDonaMariana.WinApp.ModuloTeste
{
	public partial class TabelaTeste : UserControl
	{
		public TabelaTeste(List<Teste> listaDeEntidades)
		{
			InitializeComponent();

			AtualizarRegistros(listaDeEntidades);

			grid.ConfigurarGridZebrado();

			grid.ConfigurarGridSomenteLeitura();
		}

		public void AtualizarRegistros(List<Teste> listaDeEntidades)
		{
			BindingList<Teste> bindingList = new BindingList<Teste>(listaDeEntidades);
			BindingSource source = new BindingSource(bindingList, null);
			grid.DataSource = source;
		}

		public Teste? ObterEntidadeSelecionada()
		{
			List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
			if (rows.Count > 0)
			{
				return rows[0].DataBoundItem as Teste;
			}
			return null;
		}
	}
}

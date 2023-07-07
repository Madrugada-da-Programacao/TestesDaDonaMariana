using System.ComponentModel;
using System.Data;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.WinApp.ModuloMateria
{
	public partial class TabelaMateria : UserControl
	{
		public TabelaMateria(List<EMateria> listaDeEntidades)
		{
			InitializeComponent();

			AtualizarRegistros(listaDeEntidades);

			grid.ConfigurarGridZebrado();

			grid.ConfigurarGridSomenteLeitura();
		}

		public void AtualizarRegistros(List<EMateria> listaDeEntidades)
		{
			BindingList<EMateria> bindingList = new BindingList<EMateria>(listaDeEntidades);
			BindingSource source = new BindingSource(bindingList, null);
			grid.DataSource = source;
		}

		public EMateria? ObterEntidadeSelecionada()
		{
			List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
			if (rows.Count > 0)
			{
				return rows[0].DataBoundItem as EMateria;
			}
			return null;
		}
	}
}

using System.ComponentModel;
using System.Data;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.WinApp.ModuloMateria
{
	public partial class TabelaMateria : UserControl
	{
		public TabelaMateria(List<Materia> listaDeEntidades)
		{
			InitializeComponent();

			AtualizarRegistros(listaDeEntidades);

			grid.ConfigurarGridZebrado();

			grid.ConfigurarGridSomenteLeitura();
		}

		public void AtualizarRegistros(List<Materia> listaDeEntidades)
		{
			BindingList<Materia> bindingList = new BindingList<Materia>(listaDeEntidades);
			BindingSource source = new BindingSource(bindingList, null);
			grid.DataSource = source;
		}

		public Materia? ObterEntidadeSelecionada()
		{
			List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
			if (rows.Count > 0)
			{
				return rows[0].DataBoundItem as Materia;
			}
			return null;
		}
	}
}

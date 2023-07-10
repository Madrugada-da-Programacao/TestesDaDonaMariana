using System.ComponentModel;
using TestesDaDonaMariana.Dominio.ModuloDisciplina;

namespace TestesDaDonaMariana.WinApp.ModuloDisciplina
{
    public partial class TabelaDisciplina : UserControl
    {
        public TabelaDisciplina(List<Disciplina> disciplinas)
        {
            InitializeComponent();

            AtualizarRegistros(disciplinas);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            BindingList<Disciplina> bindingList = new BindingList<Disciplina>(disciplinas);
            BindingSource source = new BindingSource(bindingList, null);
            grid.DataSource = source;
        }

        public Disciplina? ObterEntidadeSelecionada()
        {
            List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
            if (rows.Count > 0)
            {
                return rows[0].DataBoundItem as Disciplina;
            }
            return null;
        }
    }
}

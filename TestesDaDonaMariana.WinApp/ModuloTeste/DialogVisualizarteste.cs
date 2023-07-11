using TestesDaDonaMariana.Dominio.ModuloTeste;

namespace TestesDaDonaMariana.WinApp.ModuloTeste
{
	public partial class DialogVisualizarteste : Form
	{
		private Teste teste;
		public DialogVisualizarteste()
		{
			InitializeComponent();

			this.ConfigurarDialog();
		}

		public Teste Teste
		{
			set
			{
				teste = value;
				labelTitulo.Text = teste.Titulo;
				labelDisciplina.Text = teste.Disciplina.Nome;
				if (teste.ProvaDeRecuperacao)
				{
					labelMateria.Text = "Recuperação";
				}
				else
				{
					labelMateria.Text = $"{teste.Materia!.Nome} da {teste.Materia.Serie} Série";
				}
				teste.Questoes.ForEach(q => listBoxQuestoes.Items.Add(q));
			}
		}
	}
}

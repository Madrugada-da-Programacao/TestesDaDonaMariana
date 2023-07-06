using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;
using TestesDaDonaMariana.WinApp.ModuloQuestao;

namespace TestesDaDonaMariana.WinApp
{
	public partial class TelaPrincipalForm : Form
	{
		public static TelaPrincipalForm Instancia { get; set; }

		private Controlador Controlador { get; set; }

		//private IRepositorioDisciplina RepositorioDisciplina { get; set; }
		//private IRepositorioMateria RepositorioMateria { get; set; }
		private IRepositorioQuestao RepositorioQuestao { get; set; } = new RepositorioQuestaoEmSql();
		//private IRepositorioTeste RepositorioTeste { get; set; }



		public TelaPrincipalForm()
		{
			InitializeComponent();
			Instancia = this;
		}

		public void AtualizarToolStrip(string text)
		{
			labelRodape.Text = text;
		}

		private void itensTemaMenuItem_Click(object sender, EventArgs e)
		{
			//Controlador = new ControladorItemTema(RepositorioItemTema);

			ConfigurarTelaPrincipal(Controlador);
		}

		private void clientesMenuItem_Click(object sender, EventArgs e)
		{
			//Controlador = new ControladorConcertar(RepositorioConcertar);

			ConfigurarTelaPrincipal(Controlador);
		}

		private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Controlador = new ControladorConcertar(RepositorioConcertar);

			ConfigurarTelaPrincipal(Controlador);
		}

		private void questãoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Controlador = new ControladorQuestao(RepositorioQuestao);

			ConfigurarTelaPrincipal(Controlador);
		}

		private void testeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Controlador = new ControladorConcertar(RepositorioConcertar);

			ConfigurarTelaPrincipal(Controlador);
		}

		private void ConfigurarTelaPrincipal(Controlador controladorBase)
		{
			labelTipoCadastro.Text = controladorBase.ObterTipoCadastro;

			ConfigurarToolTips(Controlador);

			ConfigurarListagem(Controlador);
		}

		private void ConfigurarToolTips(Controlador controlador)
		{
			btnInserir.ToolTipText = controlador.ToolTipInserir;
			btnEditar.ToolTipText = controlador.ToolTipEditar;
			btnExcluir.ToolTipText = controlador.ToolTipExcluir;

			btnInserir.Enabled = controlador.ToolTipEnableInserir;
			btnEditar.Enabled = controlador.ToolTipEnableEditar;
			btnExcluir.Enabled = controlador.ToolTipEnableExcluir;
		}

		private void ConfigurarListagem(Controlador controladorBase)
		{
			UserControl listagem = controladorBase.ObterListagem();

			listagem.Dock = DockStyle.Fill;

			panelRegistros.Controls.Clear();

			panelRegistros.Controls.Add(listagem);
		}


		private void btnInserir_Click(object sender, EventArgs e)
		{
			Controlador.Inserir();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			Controlador.Editar();
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			Controlador.Excluir();
		}
	}
}
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.WinApp.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.WinApp.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;
using TestesDaDonaMariana.WinApp.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloTeste;
using TestesDaDonaMariana.WinApp.ModuloTeste;

namespace TestesDaDonaMariana.WinApp
{
	public partial class TelaPrincipalForm : Form
	{
		public static TelaPrincipalForm Instancia { get; set; }

		private Controlador Controlador { get; set; }

		private IRepositorioDisciplina RepositorioDisciplina = new RepositorioDisciplinaEmSql();
		private IRepositorioMateria RepositorioMateria { get; set; } = new RepositorioMateriaEmSql();
		private IRepositorioQuestao RepositorioQuestao { get; set; } = new RepositorioQuestaoEmSql();
		private IRepositorioTeste RepositorioTeste { get; set; } = new RepositorioTesteEmSql();



		public TelaPrincipalForm()
		{
			InitializeComponent();
			Instancia = this;
		}

		public void AtualizarToolStrip(string text)
		{
			labelRodape.Text = text;
		}

		private void disciplinaMenuItem_Click(object sender, EventArgs e)
		{
			Controlador = new ControladorDisciplina(RepositorioDisciplina, RepositorioMateria);

			ConfigurarTelaPrincipal(Controlador);
		}

		private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Controlador = new ControladorMateria(RepositorioDisciplina, RepositorioMateria);

			ConfigurarTelaPrincipal(Controlador);
		}

		private void questaoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Controlador = new ControladorQuestao(RepositorioMateria, RepositorioQuestao);

			ConfigurarTelaPrincipal(Controlador);
		}

		private void testeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Controlador = new ControladorTeste(RepositorioDisciplina, RepositorioMateria, RepositorioQuestao, RepositorioTeste);

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
			btnCopiarTeste.ToolTipText = controlador.ToolTipCopiarTeste;
			btnVisualizarTeste.ToolTipText = controlador.ToolTipVisualizarTeste;

			btnInserir.Enabled = controlador.ToolTipEnableInserir;
			btnEditar.Enabled = controlador.ToolTipEnableEditar;
			btnExcluir.Enabled = controlador.ToolTipEnableExcluir;
			btnCopiarTeste.Enabled = controlador.ToolTipEnableCopiarTeste;
			btnVisualizarTeste.Enabled = controlador.ToolTipEnableVisualizarTeste;
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

		private void btnCopiarTeste_Click(object sender, EventArgs e)
		{
			Controlador.CopiarTeste();
		}

		private void btnVisualizarTeste_Click(object sender, EventArgs e)
		{
			Controlador.VisualizarTeste();
		}
	}
}
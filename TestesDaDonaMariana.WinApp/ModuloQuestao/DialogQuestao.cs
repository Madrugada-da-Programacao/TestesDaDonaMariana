using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;

namespace TestesDaDonaMariana.WinApp.ModuloQuestao
{
	public partial class DialogQuestao : Form
	{
		private Questao questao;

		public DialogQuestao(List<Materia> materias)
		{
			InitializeComponent();

			this.ConfigurarDialog();

			cmbMateria.DisplayMember = "Nome" + "Serie";
			cmbMateria.ValueMember = "Id";
			cmbMateria.DataSource = materias;
		}

		public Questao Questao
		{
			set
			{
				questao = value;
				labelId.Text = questao.Id.ToString();
				txtEnunciado.Text = questao.Enunciado;
				txtOpcaoA.Text = questao.TextoOpcaoA;
				txtOpcaoB.Text = questao.TextoOpcaoB;
				txtOpcaoC.Text = questao.TextoOpcaoC;
				txtOpcaoD.Text = questao.TextoOpcaoD;

				cmbRespostaCerta.SelectedIndex = cmbRespostaCerta.FindStringExact(questao.RespostaCerta.ToString());
				cmbMateria.SelectedItem = questao.Materia;
			}
			get
			{
				return questao;
			}
		}

		private void btnGravar_Click(object sender, EventArgs e)
		{
			string enunciado = txtEnunciado.Text;

			string textoOpcaoA = txtOpcaoA.Text;
			string textoOpcaoB = txtOpcaoB.Text;
			string textoOpcaoC = txtOpcaoC.Text;
			string textoOpcaoD = txtOpcaoD.Text;

			char respostaCerta = Convert.ToChar(cmbRespostaCerta.SelectedItem);

			Materia materia = (Materia)cmbMateria.SelectedItem;

			questao = new Questao(enunciado, textoOpcaoA, textoOpcaoB, textoOpcaoC, textoOpcaoD, respostaCerta, materia);

			List<string> resultado = questao.Validar();
			if (resultado.Count > 0)
			{
				TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
				DialogResult = DialogResult.None;
			}
			else
			{
				if (labelId.Text != "0")
				{
					questao.Id = Convert.ToInt32(labelId.Text);
				}

				TelaPrincipalForm.Instancia.AtualizarToolStrip("");
			}
		}
	}
}

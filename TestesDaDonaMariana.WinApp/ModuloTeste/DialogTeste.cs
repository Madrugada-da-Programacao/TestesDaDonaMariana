using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;

namespace TestesDaDonaMariana.WinApp.ModuloTeste
{
	public partial class DialogTeste : Form
	{
		public Teste teste { get; set; }
		public List<Questao> QuestoesSorteadas { get; set; } = new List<Questao>();
		private List<Materia> Materias { get; set; }
		private List<Questao> Questoes { get; set; }
		private List<Teste> Testes { get; set; }
		public DialogTeste(List<Disciplina> disciplinas, List<Materia> materias, List<Questao> questoes, List<Teste> testes)
		{
			InitializeComponent();

			Materias = materias;
			Testes = testes;
			Questoes = questoes;

			this.ConfigurarDialog();

			cmbDisciplina.DisplayMember = "Nome";
			cmbDisciplina.ValueMember = "Id";
			cmbDisciplina.DataSource = disciplinas;

			cmbMateria.DisplayMember = "Nome";
			cmbMateria.ValueMember = "Id";
		}

		public Teste Teste
		{
			set
			{
				teste = value;
				txtTitulo.Text = teste.Titulo;
				cmbDisciplina.SelectedItem = teste.Disciplina;
				if (teste.ProvaDeRecuperacao)
				{
					cbProvaDeRecuperacao.Checked = true;
				}
				else
				{
					cmbMateria.SelectedItem = teste.Materia;
				}
				nUDQtdDeQuestoes.Text = Convert.ToString(teste.QuantidadeDeQuestoes);
			}
			get
			{
				return teste;
			}
		}
		private void btnGravar_Click(object sender, EventArgs e)
		{
			int id = int.Parse(labelId.Text);
			string titulo = txtTitulo.Text;
			Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;
			Materia? materia = null;
			if (!cbProvaDeRecuperacao.Checked)
			{
				materia = (Materia)cmbMateria.SelectedItem;
			}
			int quantidadeDeQuestoes = int.Parse(nUDQtdDeQuestoes.Text);
			bool provaRecuperacao = cbProvaDeRecuperacao.Checked;

			teste = new Teste(id, titulo, quantidadeDeQuestoes, provaRecuperacao, disciplina, materia);

			ValidarErros(teste);
		}

		private void btnSortear_Click(object sender, EventArgs e)
		{
			listBoxQuestoes.Items.Clear();
			QuestoesSorteadas.Clear();

			Materia materia = (Materia)cmbMateria.SelectedItem;
			Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;

			int quantidade = (int)nUDQtdDeQuestoes.Value;

			if (quantidade <= 0)
			{
				TelaPrincipalForm.Instancia.AtualizarToolStrip("Digite uma quantidade válida");
				return;
			}

			List<Questao> questoesParaSortear;

			if (cbProvaDeRecuperacao.Checked == false)
			{
				questoesParaSortear = Questoes.FindAll(x => x.Materia.Id == materia.Id);
			}
			else
			{
				questoesParaSortear = Questoes.FindAll(q => q.Materia.Disciplina.Id == disciplina.Id);
			}

			if (questoesParaSortear.Count < quantidade)
			{
				TelaPrincipalForm.Instancia.AtualizarToolStrip("Não há questões suficientes para a quantidade solicitada!");
				return;
			}

			Random random = new Random();
			while (QuestoesSorteadas.Count < quantidade)
			{
				int index = random.Next(questoesParaSortear.Count);
				QuestoesSorteadas.Add(questoesParaSortear[index]);
				questoesParaSortear.RemoveAt(index);
			}

			QuestoesSorteadas.ForEach(q => listBoxQuestoes.Items.Add(q));
		}

		private void cmbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbDisciplina.SelectedItem != null)
			{
				Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplina.SelectedItem;
				List<Materia> materiasDaDisciplina = Materias.FindAll(materias => materias.Disciplina.Id == disciplinaSelecionada.Id);
				cmbMateria.DataSource = materiasDaDisciplina;

				//TODO setar maximo de questoes dependendo da disciplina/materia
				//nUDQtdDeQuestoes.Maximum =
			}
		}

		private void ValidarErros(Teste teste)
		{
			if (teste == null) return;

			List<string> erros = teste.Validar();

			if (erros.Count > 0)
			{
				TelaPrincipalForm.Instancia.AtualizarToolStrip(erros[0]);

				DialogResult = DialogResult.None;
			}

			if (Testes.Any(teste => teste.Titulo == Teste.Titulo))
			{
				TelaPrincipalForm.Instancia.AtualizarToolStrip("O título já esta em uso");

				DialogResult = DialogResult.None;
			}

			if (listBoxQuestoes.Items.Count == 0)
			{
				TelaPrincipalForm.Instancia.AtualizarToolStrip("É necessário sortear questões");

				DialogResult = DialogResult.None;
			}
		}

		private void cbProvaDeRecuperacao_CheckedChanged(object sender, EventArgs e)
		{
			if (cbProvaDeRecuperacao.Checked)
			{
				cmbMateria.DataSource = null;
			}
			else
			{
				if (cmbDisciplina.SelectedItem != null)
				{
					Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplina.SelectedItem;
					List<Materia> materiasDaDisciplina = Materias.FindAll(materias => materias.Disciplina.Id == disciplinaSelecionada.Id);
					cmbMateria.DataSource = materiasDaDisciplina;

					//TODO setar maximo de questoes dependendo da disciplina/materia
					//nUDQtdDeQuestoes.Maximum =
				}
			}
		}
	}
}

using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.WinApp.ModuloMateria
{
    public partial class DialogMateria : Form
    {
        private Materia materia;

        public DialogMateria(List<Disciplina> disciplinas)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            cmbDisciplina.DisplayMember = "Nome";
            cmbDisciplina.ValueMember = "Id";
            cmbDisciplina.DataSource = disciplinas;
        }

        public Materia Materia
        {
            set
            {
                materia = value;
                labelId.Text = materia.Id.ToString();
                txNome.Text = materia.Nome;
                cmbDisciplina.SelectedItem = materia.Disciplina;

            }
            get
            {
                return materia;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txNome.Text;

            int serie = (int) nudSerie.Value;

            Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;

            materia = new Materia(nome, serie, disciplina);

            List<string> resultado = materia.Validar();
            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (labelId.Text != "0")
                {
                    materia.Id = Convert.ToInt32(labelId.Text);
                }

                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }
    }
}

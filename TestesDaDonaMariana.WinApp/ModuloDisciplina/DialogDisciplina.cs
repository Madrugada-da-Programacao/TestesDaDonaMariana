using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloDisciplina
{
    public partial class DialogDisciplina : Form
    {
        private Disciplina disciplina;

        public Disciplina Disciplina { get { return disciplina; } set { } }
        public DialogDisciplina()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            disciplina = new Disciplina(nome);

            List<string> erros = disciplina.Validar();

            if(erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(erros[0]);
                DialogResult = DialogResult.None;
            }
            else 
            {

            }
        }

    }
}

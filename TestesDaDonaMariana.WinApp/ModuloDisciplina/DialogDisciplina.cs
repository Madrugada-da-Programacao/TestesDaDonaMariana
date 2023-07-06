using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloDisciplina
{
    public partial class DialogDisciplina : Form
    {
        private List<string> Nomes { get; set; }

        private Disciplina disciplina;

        public Disciplina Disciplina { get { return disciplina; } set { } }
        public DialogDisciplina(List<string> nomes)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.Nomes = nomes;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            disciplina = new Disciplina(nome);

            List<string> erros = disciplina.Validar(Nomes);

            if(erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(erros[0]);
                DialogResult = DialogResult.None;
            }
            else 
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }

    }
}

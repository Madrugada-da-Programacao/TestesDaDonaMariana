using System.Drawing.Drawing2D;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.WinApp.ModuloMateria
{
    public partial class DialogMateria : Form
    {
        private EMateria materia;

        //TODO adicionar materia
        public DialogMateria()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        //TODO adicionar materia
        public EMateria Materia
        {
            set
            {
                materia = value;
                labelId.Text = materia.Id.ToString();
                txNome.Text = materia.Nome;
            }
            get
            {
                return materia;
            }
        }

        //TODO adicionar materia
        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txNome.Text;

            int serie = Convert.ToInt32(txSerie.Text);

            //Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;

            materia = new EMateria(nome, serie);//, disciplina);

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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

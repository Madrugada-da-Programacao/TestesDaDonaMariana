using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;

namespace TestesDaDonaMariana.WinApp.ModuloTeste
{
	public partial class DialogGerarPDF : Form
	{
		public Teste Teste { get; set; }
		public DialogGerarPDF()
		{
			InitializeComponent();

			this.ConfigurarDialog();
		}

		private string DefinirNomeArquivo()
		{
			if (rBTeste.Checked)
				return $"Teste - {Teste.Titulo}.pdf";

			else return $"Gabarito - {Teste.Titulo}.pdf";
		}

		private void btnDiretorio_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			if (fbd.ShowDialog() == DialogResult.OK)
			{
				txtDiretorio.Text = fbd.SelectedPath;
			}

			DialogResult = DialogResult.None;
		}

		private void btnGravar_Click(object sender, EventArgs e)
		{
			if (Validar())
			{
				EscreverPdf();
				MessageBox.Show($"PDF gerado com sucesso! Confira no caminho: \n{txtDiretorio.Text}");
			}
		}

		private bool Validar()
		{
			if (string.IsNullOrEmpty(txtDiretorio.Text))
			{
				TelaPrincipalForm.Instancia.AtualizarToolStrip("Escolha um diretório para guardar seu PDF");
				DialogResult = DialogResult.None;
				return false;
			}

			return true;
		}

		public void EscreverPdf()
		{
			PdfDocument document = new PdfDocument();
			PdfPage page = document.AddPage();
			XGraphics gfx = XGraphics.FromPdfPage(page);
			XPoint position = new XPoint(40, 20);
			List<Questao> questoes = Teste.Questoes;

			int numeroQuestao = 1;
			string nomeDaMateria = "";
			if (Teste.ProvaDeRecuperacao)
			{
				nomeDaMateria = "Recuperação";
			}
			else
			{
				nomeDaMateria = Teste.Materia!.Nome;
			}

			string titulo = $"Teste da Disciplina: {Teste.Disciplina}\n" +
							$"Materia: {nomeDaMateria}\n" +
							$"Titulo: {Teste.Titulo}";
			XTextFormatter af = new XTextFormatter(gfx);
			XRect rct = new XRect(position, new XSize(page.Width, page.Height));
			af.DrawString(titulo, new XFont("Arial", 22), XBrushes.Black, rct, XStringFormats.TopLeft);
			position.Y += 100;
			rct = new XRect(position, new XSize(page.Width, page.Height));

			string textoParaSalvar;
			XTextFormatter tf = new XTextFormatter(gfx);
			XRect rect = new XRect(position, new XSize(page.Width, page.Height));
			foreach (Questao questao in questoes)
			{
				textoParaSalvar = $"{numeroQuestao}) {questao.Enunciado}";
				tf.DrawString(textoParaSalvar, new XFont("Arial", 12), XBrushes.Black, rect, XStringFormats.TopLeft);
				rect.Y += 30;

				textoParaSalvar = $"A) {questao.TextoOpcaoA}";
				tf.DrawString(textoParaSalvar, new XFont("Arial", 12), XBrushes.Black, rect, XStringFormats.TopLeft);
				rect.Y += 30;

				textoParaSalvar = $"B) {questao.TextoOpcaoB}";
				tf.DrawString(textoParaSalvar, new XFont("Arial", 12), XBrushes.Black, rect, XStringFormats.TopLeft);
				rect.Y += 30;

				textoParaSalvar = $"C) {questao.TextoOpcaoC}";
				tf.DrawString(textoParaSalvar, new XFont("Arial", 12), XBrushes.Black, rect, XStringFormats.TopLeft);
				rect.Y += 30;

				textoParaSalvar = $"D) {questao.TextoOpcaoD}";
				tf.DrawString(textoParaSalvar, new XFont("Arial", 12), XBrushes.Black, rect, XStringFormats.TopLeft);
				rect.Y += 30;
				if (rBGabarito.Checked)
				{
					textoParaSalvar = $"Resposta Certa: {questao.RespostaCerta}";
					tf.DrawString(textoParaSalvar, new XFont("Arial", 12), XBrushes.Black, rect, XStringFormats.TopLeft);
					rect.Y += 30;
				}

				numeroQuestao++;
			}
			string caminhoArquivo = txtDiretorio.Text + "\\" + DefinirNomeArquivo();
			document.Save(caminhoArquivo);
		}
	}
}

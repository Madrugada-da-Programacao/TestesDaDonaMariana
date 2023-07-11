namespace TestesDaDonaMariana.WinApp.ModuloTeste
{
	partial class DialogGerarPDF
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label2 = new Label();
			rBTeste = new RadioButton();
			rBGabarito = new RadioButton();
			label1 = new Label();
			btnDiretorio = new Button();
			txtDiretorio = new TextBox();
			btnGravar = new Button();
			btnCancelar = new Button();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(12, 43);
			label2.Name = "label2";
			label2.Size = new Size(156, 17);
			label2.TabIndex = 0;
			label2.Text = "Escolha uma das opções:";
			// 
			// rBTeste
			// 
			rBTeste.AutoSize = true;
			rBTeste.Location = new Point(245, 41);
			rBTeste.Name = "rBTeste";
			rBTeste.Size = new Size(51, 19);
			rBTeste.TabIndex = 1;
			rBTeste.TabStop = true;
			rBTeste.Text = "Teste";
			rBTeste.UseVisualStyleBackColor = true;
			// 
			// rBGabarito
			// 
			rBGabarito.AutoSize = true;
			rBGabarito.Location = new Point(245, 66);
			rBGabarito.Name = "rBGabarito";
			rBGabarito.Size = new Size(70, 19);
			rBGabarito.TabIndex = 2;
			rBGabarito.TabStop = true;
			rBGabarito.Text = "Gabarito";
			rBGabarito.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(36, 118);
			label1.Name = "label1";
			label1.Size = new Size(132, 17);
			label1.TabIndex = 20;
			label1.Text = "Escolha um diretorio:";
			// 
			// btnDiretorio
			// 
			btnDiretorio.Location = new Point(240, 107);
			btnDiretorio.Name = "btnDiretorio";
			btnDiretorio.Size = new Size(75, 41);
			btnDiretorio.TabIndex = 21;
			btnDiretorio.Text = "Diretorio";
			btnDiretorio.UseVisualStyleBackColor = true;
			btnDiretorio.Click += btnDiretorio_Click;
			// 
			// txtDiretorio
			// 
			txtDiretorio.Location = new Point(21, 177);
			txtDiretorio.Name = "txtDiretorio";
			txtDiretorio.Size = new Size(294, 23);
			txtDiretorio.TabIndex = 22;
			// 
			// btnGravar
			// 
			btnGravar.DialogResult = DialogResult.OK;
			btnGravar.Location = new Point(159, 238);
			btnGravar.Name = "btnGravar";
			btnGravar.Size = new Size(75, 41);
			btnGravar.TabIndex = 23;
			btnGravar.Text = "Gravar";
			btnGravar.UseVisualStyleBackColor = true;
			btnGravar.Click += btnGravar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.DialogResult = DialogResult.Cancel;
			btnCancelar.Location = new Point(240, 238);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(75, 41);
			btnCancelar.TabIndex = 24;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// DialogGerarPDF
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(338, 305);
			Controls.Add(btnCancelar);
			Controls.Add(btnGravar);
			Controls.Add(txtDiretorio);
			Controls.Add(btnDiretorio);
			Controls.Add(label1);
			Controls.Add(rBGabarito);
			Controls.Add(rBTeste);
			Controls.Add(label2);
			Name = "DialogGerarPDF";
			Text = "DialogGerarPDF";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private RadioButton rBTeste;
		private RadioButton rBGabarito;
		private Label label1;
		private Button btnDiretorio;
		private TextBox txtDiretorio;
		private Button btnGravar;
		private Button btnCancelar;
	}
}
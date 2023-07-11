namespace TestesDaDonaMariana.WinApp.ModuloTeste
{
	partial class DialogTeste
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
			label1 = new Label();
			labelId = new Label();
			Titulo = new Label();
			txtTitulo = new TextBox();
			label3 = new Label();
			cmbDisciplina = new ComboBox();
			label4 = new Label();
			cmbMateria = new ComboBox();
			label5 = new Label();
			nUDQtdDeQuestoes = new NumericUpDown();
			cbProvaDeRecuperacao = new CheckBox();
			groupBox1 = new GroupBox();
			listBoxQuestoes = new ListBox();
			btnGravar = new Button();
			btnCancelar = new Button();
			btnSortear = new Button();
			((System.ComponentModel.ISupportInitialize)nUDQtdDeQuestoes).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(51, 28);
			label1.Name = "label1";
			label1.Size = new Size(20, 15);
			label1.TabIndex = 1;
			label1.Text = "Id:";
			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Location = new Point(77, 28);
			labelId.Name = "labelId";
			labelId.Size = new Size(13, 15);
			labelId.TabIndex = 2;
			labelId.Text = "0";
			// 
			// Titulo
			// 
			Titulo.AutoSize = true;
			Titulo.Location = new Point(31, 72);
			Titulo.Name = "Titulo";
			Titulo.Size = new Size(40, 15);
			Titulo.TabIndex = 3;
			Titulo.Text = "Titulo:";
			// 
			// txtTitulo
			// 
			txtTitulo.Location = new Point(77, 69);
			txtTitulo.Name = "txtTitulo";
			txtTitulo.Size = new Size(100, 23);
			txtTitulo.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 125);
			label3.Name = "label3";
			label3.Size = new Size(61, 15);
			label3.TabIndex = 5;
			label3.Text = "Disciplina:";
			// 
			// cmbDisciplina
			// 
			cmbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbDisciplina.FormattingEnabled = true;
			cmbDisciplina.Location = new Point(79, 117);
			cmbDisciplina.Name = "cmbDisciplina";
			cmbDisciplina.Size = new Size(121, 23);
			cmbDisciplina.TabIndex = 6;
			cmbDisciplina.SelectedIndexChanged += cmbDisciplina_SelectedIndexChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(24, 164);
			label4.Name = "label4";
			label4.Size = new Size(50, 15);
			label4.TabIndex = 7;
			label4.Text = "Materia:";
			// 
			// cmbMateria
			// 
			cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbMateria.FormattingEnabled = true;
			cmbMateria.Location = new Point(77, 161);
			cmbMateria.Name = "cmbMateria";
			cmbMateria.Size = new Size(121, 23);
			cmbMateria.TabIndex = 8;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(291, 103);
			label5.Name = "label5";
			label5.Size = new Size(101, 15);
			label5.TabIndex = 9;
			label5.Text = "Qtd. de Questões:";
			// 
			// nUDQtdDeQuestoes
			// 
			nUDQtdDeQuestoes.Location = new Point(398, 95);
			nUDQtdDeQuestoes.Name = "nUDQtdDeQuestoes";
			nUDQtdDeQuestoes.Size = new Size(120, 23);
			nUDQtdDeQuestoes.TabIndex = 10;
			// 
			// cbProvaDeRecuperacao
			// 
			cbProvaDeRecuperacao.AutoSize = true;
			cbProvaDeRecuperacao.Location = new Point(375, 143);
			cbProvaDeRecuperacao.Name = "cbProvaDeRecuperacao";
			cbProvaDeRecuperacao.Size = new Size(143, 19);
			cbProvaDeRecuperacao.TabIndex = 11;
			cbProvaDeRecuperacao.Text = "Prova de Recuperação";
			cbProvaDeRecuperacao.UseVisualStyleBackColor = true;
			cbProvaDeRecuperacao.CheckedChanged += cbProvaDeRecuperacao_CheckedChanged;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(listBoxQuestoes);
			groupBox1.Location = new Point(24, 257);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(497, 240);
			groupBox1.TabIndex = 12;
			groupBox1.TabStop = false;
			groupBox1.Text = "groupBox1";
			// 
			// listBoxQuestoes
			// 
			listBoxQuestoes.Dock = DockStyle.Fill;
			listBoxQuestoes.FormattingEnabled = true;
			listBoxQuestoes.ItemHeight = 15;
			listBoxQuestoes.Location = new Point(3, 19);
			listBoxQuestoes.Name = "listBoxQuestoes";
			listBoxQuestoes.Size = new Size(491, 218);
			listBoxQuestoes.TabIndex = 0;
			// 
			// btnGravar
			// 
			btnGravar.DialogResult = DialogResult.OK;
			btnGravar.Location = new Point(362, 515);
			btnGravar.Name = "btnGravar";
			btnGravar.Size = new Size(75, 41);
			btnGravar.TabIndex = 17;
			btnGravar.Text = "Gravar";
			btnGravar.UseVisualStyleBackColor = true;
			btnGravar.Click += btnGravar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.DialogResult = DialogResult.Cancel;
			btnCancelar.Location = new Point(443, 515);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(75, 41);
			btnCancelar.TabIndex = 18;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnSortear
			// 
			btnSortear.Location = new Point(24, 213);
			btnSortear.Name = "btnSortear";
			btnSortear.Size = new Size(494, 38);
			btnSortear.TabIndex = 19;
			btnSortear.Text = "Sortear Questões";
			btnSortear.UseVisualStyleBackColor = true;
			btnSortear.Click += btnSortear_Click;
			// 
			// DialogTeste
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(533, 568);
			Controls.Add(btnSortear);
			Controls.Add(btnCancelar);
			Controls.Add(btnGravar);
			Controls.Add(groupBox1);
			Controls.Add(cbProvaDeRecuperacao);
			Controls.Add(nUDQtdDeQuestoes);
			Controls.Add(label5);
			Controls.Add(cmbMateria);
			Controls.Add(label4);
			Controls.Add(cmbDisciplina);
			Controls.Add(label3);
			Controls.Add(txtTitulo);
			Controls.Add(Titulo);
			Controls.Add(labelId);
			Controls.Add(label1);
			Name = "DialogTeste";
			Text = "DialogTeste";
			((System.ComponentModel.ISupportInitialize)nUDQtdDeQuestoes).EndInit();
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label labelId;
		private Label Titulo;
		private TextBox txtTitulo;
		private Label label3;
		private ComboBox cmbDisciplina;
		private Label label4;
		private ComboBox cmbMateria;
		private Label label5;
		private NumericUpDown nUDQtdDeQuestoes;
		private CheckBox cbProvaDeRecuperacao;
		private GroupBox groupBox1;
		private Button btnGravar;
		private Button btnCancelar;
		private Button btnSortear;
		private ListBox listBoxQuestoes;
	}
}
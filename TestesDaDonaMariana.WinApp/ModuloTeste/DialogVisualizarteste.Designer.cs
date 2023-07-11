namespace TestesDaDonaMariana.WinApp.ModuloTeste
{
	partial class DialogVisualizarteste
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
			Titulo = new Label();
			labelTitulo = new Label();
			label3 = new Label();
			labelDisciplina = new Label();
			label4 = new Label();
			labelMateria = new Label();
			groupBox1 = new GroupBox();
			listBoxQuestoes = new ListBox();
			btnCancelar = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// Titulo
			// 
			Titulo.AutoSize = true;
			Titulo.Location = new Point(32, 24);
			Titulo.Name = "Titulo";
			Titulo.Size = new Size(40, 15);
			Titulo.TabIndex = 4;
			Titulo.Text = "Titulo:";
			// 
			// labelTitulo
			// 
			labelTitulo.AutoSize = true;
			labelTitulo.Location = new Point(78, 24);
			labelTitulo.Name = "labelTitulo";
			labelTitulo.Size = new Size(62, 15);
			labelTitulo.TabIndex = 5;
			labelTitulo.Text = "labelTitulo";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(11, 64);
			label3.Name = "label3";
			label3.Size = new Size(61, 15);
			label3.TabIndex = 6;
			label3.Text = "Disciplina:";
			// 
			// labelDisciplina
			// 
			labelDisciplina.AutoSize = true;
			labelDisciplina.Location = new Point(78, 64);
			labelDisciplina.Name = "labelDisciplina";
			labelDisciplina.Size = new Size(83, 15);
			labelDisciplina.TabIndex = 7;
			labelDisciplina.Text = "labelDisciplina";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(22, 110);
			label4.Name = "label4";
			label4.Size = new Size(50, 15);
			label4.TabIndex = 8;
			label4.Text = "Materia:";
			// 
			// labelMateria
			// 
			labelMateria.AutoSize = true;
			labelMateria.Location = new Point(78, 110);
			labelMateria.Name = "labelMateria";
			labelMateria.Size = new Size(72, 15);
			labelMateria.TabIndex = 9;
			labelMateria.Text = "labelMateria";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(listBoxQuestoes);
			groupBox1.Location = new Point(12, 141);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(497, 240);
			groupBox1.TabIndex = 13;
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
			// btnCancelar
			// 
			btnCancelar.DialogResult = DialogResult.Cancel;
			btnCancelar.Location = new Point(434, 397);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(75, 41);
			btnCancelar.TabIndex = 19;
			btnCancelar.Text = "Fechar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// DialogVisualizarteste
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(524, 453);
			Controls.Add(btnCancelar);
			Controls.Add(groupBox1);
			Controls.Add(labelMateria);
			Controls.Add(label4);
			Controls.Add(labelDisciplina);
			Controls.Add(label3);
			Controls.Add(labelTitulo);
			Controls.Add(Titulo);
			Name = "DialogVisualizarteste";
			Text = "DialogVisualizarteste";
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label Titulo;
		private Label labelTitulo;
		private Label label3;
		private Label labelDisciplina;
		private Label label4;
		private Label labelMateria;
		private GroupBox groupBox1;
		private ListBox listBoxQuestoes;
		private Button btnCancelar;
	}
}
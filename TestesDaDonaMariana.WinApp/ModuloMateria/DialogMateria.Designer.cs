namespace TestesDaDonaMariana.WinApp.ModuloMateria
{
	partial class DialogMateria
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
			lbNome = new Label();
			txNome = new TextBox();
			lbSerie = new Label();
			txSerie = new TextBox();
			lbDisc = new Label();
			cmbDisciplina = new ComboBox();
			btnGravar = new Button();
			btnCancelar = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(80, 25);
			label1.Name = "label1";
			label1.Size = new Size(20, 15);
			label1.TabIndex = 0;
			label1.Text = "Id:";
			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Location = new Point(106, 25);
			labelId.Name = "labelId";
			labelId.Size = new Size(13, 15);
			labelId.TabIndex = 1;
			labelId.Text = "0";
			// 
			// lbNome
			// 
			lbNome.AutoSize = true;
			lbNome.Location = new Point(34, 80);
			lbNome.Name = "lbNome";
			lbNome.Size = new Size(43, 15);
			lbNome.TabIndex = 2;
			lbNome.Text = "Nome:";
			// 
			// txNome
			// 
			txNome.Location = new Point(86, 77);
			txNome.Name = "txNome";
			txNome.Size = new Size(156, 23);
			txNome.TabIndex = 3;
			// 
			// lbSerie
			// 
			lbSerie.AutoSize = true;
			lbSerie.Location = new Point(34, 130);
			lbSerie.Name = "lbSerie";
			lbSerie.Size = new Size(35, 15);
			lbSerie.TabIndex = 6;
			lbSerie.Text = "Série:";
			// 
			// txSerie
			// 
			txSerie.Location = new Point(86, 128);
			txSerie.Name = "txSerie";
			txSerie.Size = new Size(57, 23);
			txSerie.TabIndex = 7;
			// 
			// lbDisc
			// 
			lbDisc.AutoSize = true;
			lbDisc.Location = new Point(34, 173);
			lbDisc.Name = "lbDisc";
			lbDisc.Size = new Size(61, 15);
			lbDisc.TabIndex = 14;
			lbDisc.Text = "Disciplina:";
			// 
			// cmbDisciplina
			// 
			cmbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbDisciplina.FormattingEnabled = true;
			cmbDisciplina.Location = new Point(106, 173);
			cmbDisciplina.Name = "cmbDisciplina";
			cmbDisciplina.Size = new Size(136, 23);
			cmbDisciplina.TabIndex = 15;
			// 
			// btnGravar
			// 
			btnGravar.DialogResult = DialogResult.OK;
			btnGravar.Location = new Point(34, 268);
			btnGravar.Name = "btnGravar";
			btnGravar.Size = new Size(75, 41);
			btnGravar.TabIndex = 16;
			btnGravar.Text = "Gravar";
			btnGravar.UseVisualStyleBackColor = true;
			btnGravar.Click += btnGravar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.DialogResult = DialogResult.Cancel;
			btnCancelar.Location = new Point(182, 268);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(75, 41);
			btnCancelar.TabIndex = 17;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// DialogMateria
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(284, 321);
			Controls.Add(btnCancelar);
			Controls.Add(btnGravar);
			Controls.Add(cmbDisciplina);
			Controls.Add(lbDisc);
			Controls.Add(txSerie);
			Controls.Add(lbSerie);
			Controls.Add(txNome);
			Controls.Add(lbNome);
			Controls.Add(labelId);
			Controls.Add(label1);
			Name = "DialogMateria";
			ShowIcon = false;
			Text = "DialogMatéria";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label labelId;
		private Label lbNome;
		private TextBox txNome;
		private Label lbSerie;
		private TextBox txSerie;
		private Label lbDisc;
		private ComboBox cmbDisciplina;
		private Button btnGravar;
		private Button btnCancelar;
	}
}
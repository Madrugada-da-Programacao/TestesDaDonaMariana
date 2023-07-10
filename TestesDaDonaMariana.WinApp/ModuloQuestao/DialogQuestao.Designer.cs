namespace TestesDaDonaMariana.WinApp.ModuloQuestao
{
	partial class DialogQuestao
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
			label3 = new Label();
			txtEnunciado = new TextBox();
			label4 = new Label();
			txtOpcaoA = new TextBox();
			label5 = new Label();
			txtOpcaoB = new TextBox();
			label6 = new Label();
			txtOpcaoC = new TextBox();
			label7 = new Label();
			txtOpcaoD = new TextBox();
			label2 = new Label();
			cmbRespostaCerta = new ComboBox();
			label8 = new Label();
			cmbMateria = new ComboBox();
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
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(34, 85);
			label3.Name = "label3";
			label3.Size = new Size(66, 15);
			label3.TabIndex = 2;
			label3.Text = "Enunciado:";
			// 
			// txtEnunciado
			// 
			txtEnunciado.Location = new Point(106, 77);
			txtEnunciado.Name = "txtEnunciado";
			txtEnunciado.Size = new Size(459, 23);
			txtEnunciado.TabIndex = 3;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(80, 146);
			label4.Name = "label4";
			label4.Size = new Size(19, 15);
			label4.TabIndex = 4;
			label4.Text = "A)";
			// 
			// txtOpcaoA
			// 
			txtOpcaoA.Location = new Point(105, 143);
			txtOpcaoA.Name = "txtOpcaoA";
			txtOpcaoA.Size = new Size(198, 23);
			txtOpcaoA.TabIndex = 5;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(343, 146);
			label5.Name = "label5";
			label5.Size = new Size(18, 15);
			label5.TabIndex = 6;
			label5.Text = "B)";
			// 
			// txtOpcaoB
			// 
			txtOpcaoB.Location = new Point(368, 143);
			txtOpcaoB.Name = "txtOpcaoB";
			txtOpcaoB.Size = new Size(197, 23);
			txtOpcaoB.TabIndex = 7;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(80, 217);
			label6.Name = "label6";
			label6.Size = new Size(19, 15);
			label6.TabIndex = 8;
			label6.Text = "C)";
			// 
			// txtOpcaoC
			// 
			txtOpcaoC.Location = new Point(105, 214);
			txtOpcaoC.Name = "txtOpcaoC";
			txtOpcaoC.Size = new Size(198, 23);
			txtOpcaoC.TabIndex = 9;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(343, 217);
			label7.Name = "label7";
			label7.Size = new Size(19, 15);
			label7.TabIndex = 10;
			label7.Text = "D)";
			// 
			// txtOpcaoD
			// 
			txtOpcaoD.Location = new Point(368, 214);
			txtOpcaoD.Name = "txtOpcaoD";
			txtOpcaoD.Size = new Size(197, 23);
			txtOpcaoD.TabIndex = 11;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 284);
			label2.Name = "label2";
			label2.Size = new Size(88, 15);
			label2.TabIndex = 12;
			label2.Text = "Resposta Certa:";
			// 
			// cmbRespostaCerta
			// 
			cmbRespostaCerta.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbRespostaCerta.FormattingEnabled = true;
			cmbRespostaCerta.Items.AddRange(new object[] { "A", "B", "C", "D" });
			cmbRespostaCerta.Location = new Point(106, 281);
			cmbRespostaCerta.Name = "cmbRespostaCerta";
			cmbRespostaCerta.Size = new Size(65, 23);
			cmbRespostaCerta.TabIndex = 13;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(186, 284);
			label8.Name = "label8";
			label8.Size = new Size(50, 15);
			label8.TabIndex = 14;
			label8.Text = "Matéria:";
			// 
			// cmbMateria
			// 
			cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbMateria.FormattingEnabled = true;
			cmbMateria.Location = new Point(242, 281);
			cmbMateria.Name = "cmbMateria";
			cmbMateria.Size = new Size(136, 23);
			cmbMateria.TabIndex = 15;
			// 
			// btnGravar
			// 
			btnGravar.DialogResult = DialogResult.OK;
			btnGravar.Location = new Point(396, 268);
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
			btnCancelar.Location = new Point(490, 268);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(75, 41);
			btnCancelar.TabIndex = 17;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// DialogQuestao
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(577, 321);
			Controls.Add(btnCancelar);
			Controls.Add(btnGravar);
			Controls.Add(cmbMateria);
			Controls.Add(label8);
			Controls.Add(cmbRespostaCerta);
			Controls.Add(label2);
			Controls.Add(txtOpcaoD);
			Controls.Add(label7);
			Controls.Add(txtOpcaoC);
			Controls.Add(label6);
			Controls.Add(txtOpcaoB);
			Controls.Add(label5);
			Controls.Add(txtOpcaoA);
			Controls.Add(label4);
			Controls.Add(txtEnunciado);
			Controls.Add(label3);
			Controls.Add(labelId);
			Controls.Add(label1);
			Name = "DialogQuestao";
			Text = "DialogQuestao";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label labelId;
		private Label label3;
		private TextBox txtEnunciado;
		private Label label4;
		private TextBox txtOpcaoA;
		private Label label5;
		private TextBox txtOpcaoB;
		private Label label6;
		private TextBox txtOpcaoC;
		private Label label7;
		private TextBox txtOpcaoD;
		private Label label2;
		private ComboBox cmbRespostaCerta;
		private Label label8;
		private ComboBox cmbMateria;
		private Button btnGravar;
		private Button btnCancelar;
	}
}
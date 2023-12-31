﻿namespace TestesDaDonaMariana.WinApp
{
	partial class TelaPrincipalForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			cadastrosMenuItem = new ToolStripMenuItem();
			disciplinasMenuItem = new ToolStripMenuItem();
			materiaToolStripMenuItem = new ToolStripMenuItem();
			questãoToolStripMenuItem = new ToolStripMenuItem();
			testeToolStripMenuItem = new ToolStripMenuItem();
			statusStrip1 = new StatusStrip();
			labelRodape = new ToolStripStatusLabel();
			barraFerramentas = new ToolStrip();
			btnInserir = new ToolStripButton();
			btnEditar = new ToolStripButton();
			btnExcluir = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			btnCopiarTeste = new ToolStripButton();
			btnVisualizarTeste = new ToolStripButton();
			btnSalvarPDF = new ToolStripButton();
			labelTipoCadastro = new ToolStripLabel();
			panelRegistros = new Panel();
			alugueisToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			statusStrip1.SuspendLayout();
			barraFerramentas.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// cadastrosMenuItem
			// 
			cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinasMenuItem, materiaToolStripMenuItem, questãoToolStripMenuItem, testeToolStripMenuItem });
			cadastrosMenuItem.Name = "cadastrosMenuItem";
			cadastrosMenuItem.Size = new Size(71, 20);
			cadastrosMenuItem.Text = "Cadastros";
			// 
			// disciplinasMenuItem
			// 
			disciplinasMenuItem.Name = "disciplinasMenuItem";
			disciplinasMenuItem.Size = new Size(125, 22);
			disciplinasMenuItem.Text = "Disciplina";
			disciplinasMenuItem.Click += disciplinaMenuItem_Click;
			// 
			// materiaToolStripMenuItem
			// 
			materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
			materiaToolStripMenuItem.Size = new Size(125, 22);
			materiaToolStripMenuItem.Text = "Materia";
			materiaToolStripMenuItem.Click += materiaToolStripMenuItem_Click;
			// 
			// questãoToolStripMenuItem
			// 
			questãoToolStripMenuItem.Name = "questãoToolStripMenuItem";
			questãoToolStripMenuItem.Size = new Size(125, 22);
			questãoToolStripMenuItem.Text = "Questão";
			questãoToolStripMenuItem.Click += questaoToolStripMenuItem_Click;
			// 
			// testeToolStripMenuItem
			// 
			testeToolStripMenuItem.Name = "testeToolStripMenuItem";
			testeToolStripMenuItem.Size = new Size(125, 22);
			testeToolStripMenuItem.Text = "Teste";
			testeToolStripMenuItem.Click += testeToolStripMenuItem_Click;
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new Size(20, 20);
			statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
			statusStrip1.Location = new Point(0, 428);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(800, 22);
			statusStrip1.TabIndex = 1;
			statusStrip1.Text = "statusStrip1";
			// 
			// labelRodape
			// 
			labelRodape.Name = "labelRodape";
			labelRodape.Size = new Size(52, 17);
			labelRodape.Text = "[rodape]";
			// 
			// barraFerramentas
			// 
			barraFerramentas.ImageScalingSize = new Size(20, 20);
			barraFerramentas.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator2, btnCopiarTeste, btnVisualizarTeste, btnSalvarPDF, labelTipoCadastro });
			barraFerramentas.Location = new Point(0, 24);
			barraFerramentas.Name = "barraFerramentas";
			barraFerramentas.Size = new Size(800, 45);
			barraFerramentas.TabIndex = 2;
			barraFerramentas.Text = "toolStrip1";
			// 
			// btnInserir
			// 
			btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnInserir.Enabled = false;
			btnInserir.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
			btnInserir.ImageScaling = ToolStripItemImageScaling.None;
			btnInserir.ImageTransparentColor = Color.Magenta;
			btnInserir.Name = "btnInserir";
			btnInserir.Padding = new Padding(7);
			btnInserir.Size = new Size(42, 42);
			btnInserir.Click += btnInserir_Click;
			// 
			// btnEditar
			// 
			btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnEditar.Enabled = false;
			btnEditar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
			btnEditar.ImageScaling = ToolStripItemImageScaling.None;
			btnEditar.ImageTransparentColor = Color.Magenta;
			btnEditar.Name = "btnEditar";
			btnEditar.Padding = new Padding(7);
			btnEditar.Size = new Size(42, 42);
			btnEditar.Click += btnEditar_Click;
			// 
			// btnExcluir
			// 
			btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnExcluir.Enabled = false;
			btnExcluir.Image = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
			btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
			btnExcluir.ImageTransparentColor = Color.Magenta;
			btnExcluir.Name = "btnExcluir";
			btnExcluir.Padding = new Padding(7);
			btnExcluir.Size = new Size(42, 42);
			btnExcluir.Click += btnExcluir_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 45);
			// 
			// btnCopiarTeste
			// 
			btnCopiarTeste.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnCopiarTeste.Enabled = false;
			btnCopiarTeste.Image = Properties.Resources.content_copy_FILL0_wght400_GRAD0_opsz24;
			btnCopiarTeste.ImageScaling = ToolStripItemImageScaling.None;
			btnCopiarTeste.ImageTransparentColor = Color.Magenta;
			btnCopiarTeste.Name = "btnCopiarTeste";
			btnCopiarTeste.Padding = new Padding(7);
			btnCopiarTeste.Size = new Size(42, 42);
			btnCopiarTeste.Click += btnCopiarTeste_Click;
			// 
			// btnVisualizarTeste
			// 
			btnVisualizarTeste.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnVisualizarTeste.Enabled = false;
			btnVisualizarTeste.Image = Properties.Resources.wysiwyg_FILL0_wght400_GRAD0_opsz24;
			btnVisualizarTeste.ImageScaling = ToolStripItemImageScaling.None;
			btnVisualizarTeste.ImageTransparentColor = Color.Magenta;
			btnVisualizarTeste.Name = "btnVisualizarTeste";
			btnVisualizarTeste.Padding = new Padding(7);
			btnVisualizarTeste.Size = new Size(42, 42);
			btnVisualizarTeste.Click += btnVisualizarTeste_Click;
			// 
			// btnSalvarPDF
			// 
			btnSalvarPDF.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnSalvarPDF.Enabled = false;
			btnSalvarPDF.Image = Properties.Resources.save_FILL0_wght400_GRAD0_opsz24;
			btnSalvarPDF.ImageScaling = ToolStripItemImageScaling.None;
			btnSalvarPDF.ImageTransparentColor = Color.Magenta;
			btnSalvarPDF.Name = "btnSalvarPDF";
			btnSalvarPDF.Padding = new Padding(7);
			btnSalvarPDF.Size = new Size(42, 42);
			btnSalvarPDF.Click += btnSalvarPDF_Click;
			// 
			// labelTipoCadastro
			// 
			labelTipoCadastro.Name = "labelTipoCadastro";
			labelTipoCadastro.Size = new Size(75, 42);
			labelTipoCadastro.Text = "tipoCadastro";
			// 
			// panelRegistros
			// 
			panelRegistros.BorderStyle = BorderStyle.FixedSingle;
			panelRegistros.Dock = DockStyle.Fill;
			panelRegistros.Location = new Point(0, 69);
			panelRegistros.Name = "panelRegistros";
			panelRegistros.Size = new Size(800, 359);
			panelRegistros.TabIndex = 3;
			// 
			// alugueisToolStripMenuItem
			// 
			alugueisToolStripMenuItem.Name = "alugueisToolStripMenuItem";
			alugueisToolStripMenuItem.Size = new Size(180, 22);
			alugueisToolStripMenuItem.Text = "Materia";
			// 
			// TelaPrincipalForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panelRegistros);
			Controls.Add(barraFerramentas);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "TelaPrincipalForm";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Testes da Dona Mariana 1.0";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			barraFerramentas.ResumeLayout(false);
			barraFerramentas.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem cadastrosMenuItem;
		private ToolStripMenuItem disciplinasMenuItem;
		private ToolStripMenuItem tarefasMenuItem;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel labelRodape;
		private ToolStrip barraFerramentas;
		private ToolStripButton btnInserir;
		private ToolStripButton btnEditar;
		private ToolStripButton btnExcluir;
		private Panel panelRegistros;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripLabel labelTipoCadastro;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripButton btnConfigurarDescontos;
		private ToolStripButton btnConcluirAluguel;
		private ToolStripMenuItem alugueisToolStripMenuItem;
		private ToolStripMenuItem materiaToolStripMenuItem;
		private ToolStripMenuItem questãoToolStripMenuItem;
		private ToolStripMenuItem testeToolStripMenuItem;
		private ToolStripButton btnCopiarTeste;
		private ToolStripButton btnVisualizarTeste;
		private ToolStripButton btnSalvarPDF;
	}
}
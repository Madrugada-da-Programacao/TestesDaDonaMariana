namespace TestesDaDonaMariana.WinApp
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
			clientesMenuItem = new ToolStripMenuItem();
			statusStrip1 = new StatusStrip();
			labelRodape = new ToolStripStatusLabel();
			barraFerramentas = new ToolStrip();
			btnInserir = new ToolStripButton();
			btnEditar = new ToolStripButton();
			btnExcluir = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			btnFiltrar = new ToolStripButton();
			toolStripSeparator3 = new ToolStripSeparator();
			btnAdicionarItens = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			btnVisualizarAlugueisCliente = new ToolStripButton();
			btnConcluirAluguel = new ToolStripButton();
			btnConfigurarDescontos = new ToolStripButton();
			toolStripSeparator5 = new ToolStripSeparator();
			labelTipoCadastro = new ToolStripLabel();
			panelRegistros = new Panel();
			alugueisToolStripMenuItem = new ToolStripMenuItem();
			materiaToolStripMenuItem = new ToolStripMenuItem();
			questãoToolStripMenuItem = new ToolStripMenuItem();
			testeToolStripMenuItem = new ToolStripMenuItem();
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
			cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesMenuItem, materiaToolStripMenuItem, questãoToolStripMenuItem, testeToolStripMenuItem });
			cadastrosMenuItem.Name = "cadastrosMenuItem";
			cadastrosMenuItem.Size = new Size(71, 20);
			cadastrosMenuItem.Text = "Cadastros";
			// 
			// clientesMenuItem
			// 
			clientesMenuItem.Name = "clientesMenuItem";
			clientesMenuItem.Size = new Size(180, 22);
			clientesMenuItem.Text = "Disciplina";
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
			barraFerramentas.Enabled = false;
			barraFerramentas.ImageScalingSize = new Size(20, 20);
			barraFerramentas.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator2, btnFiltrar, toolStripSeparator3, btnAdicionarItens, toolStripSeparator1, btnVisualizarAlugueisCliente, btnConcluirAluguel, btnConfigurarDescontos, toolStripSeparator5, labelTipoCadastro });
			barraFerramentas.Location = new Point(0, 24);
			barraFerramentas.Name = "barraFerramentas";
			barraFerramentas.Size = new Size(800, 25);
			barraFerramentas.TabIndex = 2;
			barraFerramentas.Text = "toolStrip1";
			// 
			// btnInserir
			// 
			btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnInserir.ImageScaling = ToolStripItemImageScaling.None;
			btnInserir.ImageTransparentColor = Color.Magenta;
			btnInserir.Name = "btnInserir";
			btnInserir.Padding = new Padding(7);
			btnInserir.Size = new Size(23, 22);
			// 
			// btnEditar
			// 
			btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnEditar.ImageScaling = ToolStripItemImageScaling.None;
			btnEditar.ImageTransparentColor = Color.Magenta;
			btnEditar.Name = "btnEditar";
			btnEditar.Padding = new Padding(7);
			btnEditar.Size = new Size(23, 22);
			// 
			// btnExcluir
			// 
			btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
			btnExcluir.ImageTransparentColor = Color.Magenta;
			btnExcluir.Name = "btnExcluir";
			btnExcluir.Padding = new Padding(7);
			btnExcluir.Size = new Size(23, 22);
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 25);
			// 
			// btnFiltrar
			// 
			btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
			btnFiltrar.ImageTransparentColor = Color.Magenta;
			btnFiltrar.Name = "btnFiltrar";
			btnFiltrar.Padding = new Padding(7);
			btnFiltrar.Size = new Size(23, 22);
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(6, 25);
			// 
			// btnAdicionarItens
			// 
			btnAdicionarItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnAdicionarItens.ImageScaling = ToolStripItemImageScaling.None;
			btnAdicionarItens.ImageTransparentColor = Color.Magenta;
			btnAdicionarItens.Name = "btnAdicionarItens";
			btnAdicionarItens.Padding = new Padding(7);
			btnAdicionarItens.Size = new Size(23, 22);
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 25);
			// 
			// btnVisualizarAlugueisCliente
			// 
			btnVisualizarAlugueisCliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnVisualizarAlugueisCliente.ImageScaling = ToolStripItemImageScaling.None;
			btnVisualizarAlugueisCliente.ImageTransparentColor = Color.Magenta;
			btnVisualizarAlugueisCliente.Name = "btnVisualizarAlugueisCliente";
			btnVisualizarAlugueisCliente.Padding = new Padding(7);
			btnVisualizarAlugueisCliente.Size = new Size(23, 22);
			// 
			// btnConcluirAluguel
			// 
			btnConcluirAluguel.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnConcluirAluguel.ImageScaling = ToolStripItemImageScaling.None;
			btnConcluirAluguel.ImageTransparentColor = Color.Magenta;
			btnConcluirAluguel.Name = "btnConcluirAluguel";
			btnConcluirAluguel.Padding = new Padding(7);
			btnConcluirAluguel.Size = new Size(23, 22);
			// 
			// btnConfigurarDescontos
			// 
			btnConfigurarDescontos.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnConfigurarDescontos.ImageScaling = ToolStripItemImageScaling.None;
			btnConfigurarDescontos.ImageTransparentColor = Color.Magenta;
			btnConfigurarDescontos.Name = "btnConfigurarDescontos";
			btnConfigurarDescontos.Padding = new Padding(7);
			btnConfigurarDescontos.Size = new Size(23, 22);
			// 
			// toolStripSeparator5
			// 
			toolStripSeparator5.Name = "toolStripSeparator5";
			toolStripSeparator5.Size = new Size(6, 25);
			// 
			// labelTipoCadastro
			// 
			labelTipoCadastro.Name = "labelTipoCadastro";
			labelTipoCadastro.Size = new Size(75, 22);
			labelTipoCadastro.Text = "tipoCadastro";
			// 
			// panelRegistros
			// 
			panelRegistros.BorderStyle = BorderStyle.FixedSingle;
			panelRegistros.Dock = DockStyle.Fill;
			panelRegistros.Location = new Point(0, 49);
			panelRegistros.Name = "panelRegistros";
			panelRegistros.Size = new Size(800, 379);
			panelRegistros.TabIndex = 3;
			// 
			// alugueisToolStripMenuItem
			// 
			alugueisToolStripMenuItem.Name = "alugueisToolStripMenuItem";
			alugueisToolStripMenuItem.Size = new Size(180, 22);
			alugueisToolStripMenuItem.Text = "Materia";
			// 
			// materiaToolStripMenuItem
			// 
			materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
			materiaToolStripMenuItem.Size = new Size(180, 22);
			materiaToolStripMenuItem.Text = "Materia";
			// 
			// questãoToolStripMenuItem
			// 
			questãoToolStripMenuItem.Name = "questãoToolStripMenuItem";
			questãoToolStripMenuItem.Size = new Size(180, 22);
			questãoToolStripMenuItem.Text = "Questão";
			// 
			// testeToolStripMenuItem
			// 
			testeToolStripMenuItem.Name = "testeToolStripMenuItem";
			testeToolStripMenuItem.Size = new Size(180, 22);
			testeToolStripMenuItem.Text = "Teste";
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
			Text = "Festas Infantis 1.0";
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
		private ToolStripMenuItem clientesMenuItem;
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
		private ToolStripButton btnFiltrar;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripButton btnAdicionarItens;
		private ToolStripButton btnConfigurarDescontos;
		private ToolStripSeparator toolStripSeparator5;
		private ToolStripButton btnVisualizarAlugueisCliente;
		private ToolStripButton btnConcluirAluguel;
		private ToolStripMenuItem alugueisToolStripMenuItem;
		private ToolStripMenuItem materiaToolStripMenuItem;
		private ToolStripMenuItem questãoToolStripMenuItem;
		private ToolStripMenuItem testeToolStripMenuItem;
	}
}
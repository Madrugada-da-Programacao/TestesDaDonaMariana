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
            lbDisc = new Label();
            cmbDisciplina = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            nudSerie = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudSerie).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 33);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(121, 33);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 20);
            labelId.TabIndex = 1;
            labelId.Text = "0";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(39, 106);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(53, 20);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome:";
            // 
            // txNome
            // 
            txNome.Location = new Point(98, 103);
            txNome.Margin = new Padding(3, 4, 3, 4);
            txNome.Name = "txNome";
            txNome.Size = new Size(178, 27);
            txNome.TabIndex = 3;
            // 
            // lbSerie
            // 
            lbSerie.AutoSize = true;
            lbSerie.Location = new Point(39, 217);
            lbSerie.Name = "lbSerie";
            lbSerie.Size = new Size(45, 20);
            lbSerie.TabIndex = 6;
            lbSerie.Text = "Série:";
            // 
            // lbDisc
            // 
            lbDisc.AutoSize = true;
            lbDisc.Location = new Point(39, 153);
            lbDisc.Name = "lbDisc";
            lbDisc.Size = new Size(77, 20);
            lbDisc.TabIndex = 14;
            lbDisc.Text = "Disciplina:";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(121, 153);
            cmbDisciplina.Margin = new Padding(3, 4, 3, 4);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(155, 28);
            cmbDisciplina.TabIndex = 15;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(39, 357);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(86, 55);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(208, 357);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 55);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // nudSerie
            // 
            nudSerie.Location = new Point(110, 216);
            nudSerie.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nudSerie.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSerie.Name = "nudSerie";
            nudSerie.Size = new Size(150, 27);
            nudSerie.TabIndex = 18;
            nudSerie.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DialogMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 480);
            Controls.Add(nudSerie);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(cmbDisciplina);
            Controls.Add(lbDisc);
            Controls.Add(lbSerie);
            Controls.Add(txNome);
            Controls.Add(lbNome);
            Controls.Add(labelId);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DialogMateria";
            ShowIcon = false;
            Text = "DialogMatéria";
            ((System.ComponentModel.ISupportInitialize)nudSerie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelId;
        private Label lbNome;
        private TextBox txNome;
        private Label lbSerie;
        private Label lbDisc;
        private ComboBox cmbDisciplina;
        private Button btnGravar;
        private Button btnCancelar;
        private NumericUpDown nudSerie;
    }
}
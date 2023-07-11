namespace TestesDaDonaMariana.WinApp.Compartilhado
{
	public abstract class Controlador
    {
		public abstract string TipoDoCadastro { get; }
		public string ToolTipInserir => $"Inserir novo {TipoDoCadastro}";
		public string ToolTipEditar => $"Editar {TipoDoCadastro} existente";
		public string ToolTipExcluir => $"Excluir {TipoDoCadastro} existente";
		public string ObterTipoCadastro => $"Cadastro de {TipoDoCadastro}";
		public virtual string ToolTipCopiarTeste => "";

		public virtual bool ToolTipEnableInserir => true;
		public virtual bool ToolTipEnableEditar => true;
		public virtual bool ToolTipEnableExcluir => true;
		public virtual bool ToolTipEnableCopiarTeste => false;

		public abstract void Inserir();
		public abstract void Editar();
		public abstract void Excluir();
		public abstract UserControl ObterListagem();

		public virtual void CopiarTeste()
		{
			
		}
	}
}

namespace TestesDaDonaMariana.Dominio.Compartilhado
{
    public interface IRepositorio<TEntidade>
        where TEntidade : Entidade<TEntidade>
    {
        public void Inserir(TEntidade entidade);
        public void Editar(TEntidade entidade);
        public void Excluir(TEntidade entidade);
        public TEntidade? SelecionarPeloId(int id);
        public List<TEntidade> SelecionarTodos();
    }
}

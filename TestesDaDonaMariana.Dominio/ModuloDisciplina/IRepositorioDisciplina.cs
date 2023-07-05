using TestesDaDonaMariana.Dominio.Compartilhado;

namespace TestesDaDonaMariana.Dominio.ModuloDisciplina
{
    public interface IRepositorioDisciplina
    {
        void Inserir(Disciplina novoDisciplina);
        void Editar(int id, Disciplina disciplina);
        void Excluir(Disciplina disciplinaSelecionada);
        List<Disciplina> SelecionarTodos();
        Disciplina SelecionarPorId(int id);
    }
}

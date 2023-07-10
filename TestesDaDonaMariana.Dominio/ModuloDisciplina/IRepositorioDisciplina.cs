using TestesDaDonaMariana.Dominio.Compartilhado;

namespace TestesDaDonaMariana.Dominio.ModuloDisciplina
{
    public interface IRepositorioDisciplina
    {
        void Inserir(Disciplina novoDisciplina);
        void Editar(Disciplina disciplina);
        void Excluir(Disciplina disciplinaSelecionada);
        List<Disciplina> SelecionarTodos();
        Disciplina SelecionarPeloId(int id);
    }
}

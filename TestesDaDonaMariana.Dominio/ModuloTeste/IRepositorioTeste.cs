using TestesDaDonaMariana.Dominio.ModuloQuestao;

namespace TestesDaDonaMariana.Dominio.ModuloTeste
{
	public interface IRepositorioTeste : IRepositorio<Teste>
	{
		public void Inserir(Teste teste, List<Questao> questoes);
	}
}

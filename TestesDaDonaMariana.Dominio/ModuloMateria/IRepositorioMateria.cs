using TestesDaDonaMariana.Dominio.ModuloDisciplina;

namespace TestesDaDonaMariana.Dominio.ModuloMateria
{
	public interface IRepositorioMateria : IRepositorio<Materia>
	{
		public bool VerificarMateriaComDisciplina(Disciplina entidade);
	}
}

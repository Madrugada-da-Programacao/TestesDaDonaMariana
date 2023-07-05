using FestasInfantis.Infra.Dados.Sql.Compartilhado;
using Microsoft.Data.SqlClient;
using TestesDaDonaMariana.Dominio.ModuloDisciplina;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina
{
    public class RepositorioDisciplinaEmSql : RepositorioEmSql<Disciplina, MapeadorDisciplina>, IRepositorioDisciplina
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TBDISCIPLINA] 
	            (
		            [NOME], 
	            )
	            VALUES 
	            (
		            @NOME, 
	            );                 

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [TBDISCIPLINA] 
	            SET 
		            [NOME] = @NOME,
	            WHERE 
		            [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBDISCIPLINA]
	            WHERE 
		            [ID] = @ID";

        protected override string sqlSelecionarTodos => @"SELECT 

	            [ID]        DISCIPLINA_ID 
	           ,[NOME]      DISCIPLINA_NOME

            FROM 
	            [TBDISCIPLINA]";

        protected override string sqlSelecionarPorId => @"SELECT 

	            [ID]        DISCIPLINA_ID 
	           ,[NOME]      DISCIPLINA_NOME

            FROM 
	            [TBDISCIPLINA] 
            WHERE 
                [ID] = @ID";

        public Disciplina? SelecionarPeloId(int id)
        {
            Disciplina disciplina = base.SelecionarPorId(id);

            return disciplina;
        }

        public List<Disciplina> SelecionarTodos()
        {
            List<Disciplina> disciplinas = base.SelecionarTodos();

            return disciplinas;
        }
    }
}

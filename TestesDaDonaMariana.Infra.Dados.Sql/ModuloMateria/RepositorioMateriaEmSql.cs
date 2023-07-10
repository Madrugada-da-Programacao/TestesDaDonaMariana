using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria
{
	public class RepositorioMateriaEmSql : RepositorioEmSql<Materia, MapeadorMateria>, IRepositorioMateria
    {
        protected override string sqlInserir =>
			@"INSERT INTO [TBMATERIA]
	            (
		            [NOME]
				   ,[SERIE]
                   ,[DISCIPLINA_ID]
	            )
	            VALUES
	            (
		            @NOME
		           ,@SERIE
                   ,@DISCIPLINA_ID
	            );
            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
			@"UPDATE [TBMATERIA]
                   SET
                       [NOME] = @NOME
				      ,[SERIE] = @SERIE
                      ,[DISCIPLINA_ID] = @DISCIPLINA_ID
                 WHERE
	                [ID] = @ID";

        protected override string sqlExcluir =>
			@"DELETE FROM [TBMATERIA]
                 WHERE
	                [ID] = @ID";

        protected override string sqlSelecionarTodos =>
		   @"SELECT 
                M.[ID]          MATERIA_ID
	           ,M.[NOME]        MATERIA_NOME
	           ,M.[SERIE]       MATERIA_SERIE
               ,D.[ID]          DISCIPLINA_ID
               ,D.[NOME]        DISCIPLINA_NOME
            FROM 
	            [TBMATERIA] as M
                INNER JOIN [TBDISCIPLINA] AS D
					    ON M.DISCIPLINA_ID = D.ID";

        protected override string sqlSelecionarPorId =>
		   @"SELECT 
                M.[ID]          MATERIA_ID
	           ,M.[NOME]        MATERIA_NOME
	           ,M.[SERIE]       MATERIA_SERIE
               ,D.[ID]          DISCIPLINA_ID
               ,D.[NOME]        DISCIPLINA_NOME
            FROM 
	            [TBMATERIA] as M
                INNER JOIN [TBDISCIPLINA] AS D
					    ON M.DISCIPLINA_ID = D.ID
			WHERE 
                [ID] = @ID";

		public bool VerificarMateriaComDisciplina(Disciplina entidade)
		{
			return SelecionarTodos()
				.Any(materia => materia.Disciplina.Nome == entidade.Nome);
		}
	}
}

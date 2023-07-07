using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria
{
    public class RepositorioMateriaEmSql : RepositorioEmSql<EMateria, MapeadorMateria>, IRepositorioMateria
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TBMateria]
	            (
		            [Nome]
				   ,[Serie]
	            )
	            VALUES
	            (
		            @NOME
		           ,@SERIE
	            );
            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [TBMateria]
                   SET
                       [Nome] = @NOME
				      ,[Serie] = @SERIE
                 WHERE
	                [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBMateria]
                 WHERE
	                [ID] = @ID";

        protected override string sqlSelecionarTodos =>
           @"SELECT 
                [ID]        MATERIA_ID
	           ,[Nome]      MATERIA_NOME
	           ,[Serie]     MATERIA_SERIE
            FROM 
	            [TBMateria]";

        protected override string sqlSelecionarPorId =>
           @"SELECT 
                [ID]        MATERIA_ID
	           ,[Nome]      MATERIA_NOME
	           ,[Serie]     MATERIA_SERIE
            FROM 
	            [TBMateria] 
            WHERE 
                [ID] = @ID";
    }
}

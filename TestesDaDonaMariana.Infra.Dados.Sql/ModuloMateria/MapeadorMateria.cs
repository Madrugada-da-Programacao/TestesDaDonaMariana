using Microsoft.Data.SqlClient;
using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Dominio.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria
{
	public class MapeadorMateria : MapeadorBase<Materia>
    {
        public override void ConfigurarParametros(SqlCommand comando, Materia registro)
        {
            comando.Parameters.AddWithValue("ID", registro.Id);

            comando.Parameters.AddWithValue("NOME", registro.Nome);
            comando.Parameters.AddWithValue("SERIE", registro.Serie);

            comando.Parameters.AddWithValue("DISCIPLINA_ID", registro.Disciplina.Id);
        }

        public override Materia ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["MATERIA_ID"]);

            string nome = Convert.ToString(leitorRegistros["MATERIA_NOME"])!;

            int serie = Convert.ToInt32(leitorRegistros["MATERIA_SERIE"])!;

            Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);

			Materia materia = new Materia(id, nome, serie, disciplina);

            return materia;
        }
    }
}

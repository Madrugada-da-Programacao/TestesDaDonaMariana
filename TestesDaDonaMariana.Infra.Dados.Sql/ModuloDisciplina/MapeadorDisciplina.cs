using TestesDaDonaMariana.Dominio.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.Compartilhado;
using Microsoft.Data.SqlClient;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina
{
    public class MapeadorDisciplina : MapeadorBase<Disciplina>
    {
        public override void ConfigurarParametros(SqlCommand comando, Disciplina registro)
        {
            comando.Parameters.AddWithValue("ID", registro.Id);

            comando.Parameters.AddWithValue("NOME", registro.Nome);

        }

        public override Disciplina ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["DISCIPLINA_ID"]);

            string nome = Convert.ToString(leitorRegistros["DISCIPLINA_NOME"]);

            Disciplina disciplina = new Disciplina(nome);

            disciplina.Id = id;

            return disciplina;
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDaDonaMariana.Dominio.ModuloMateria;

namespace TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria
{
    public class MapeadorMateria : MapeadorBase<EMateria>
    {
        //TODO adicionar materia
        public override void ConfigurarParametros(SqlCommand comando, EMateria registro)
        {
            comando.Parameters.AddWithValue("ID", registro.Id);

            comando.Parameters.AddWithValue("NOME", registro.Nome);
            comando.Parameters.AddWithValue("SERIE", registro.Serie);

            //comando.Parameters.AddWithValue("Disciplina", registro.disciplina);
        }

        //TODO adicionar materia
        public override EMateria ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["MATERIA_ID"]);

            string nome = Convert.ToString(leitorRegistros["MATERIA_NOME"])!;

            int serie = Convert.ToInt32(leitorRegistros["MATERIA_SERIE"])!;

            //Disciplina disciplina = Convert.ToString(leitorRegistros["MATERIA_DISCIPLINA"])!;

            EMateria materia = new EMateria(id, nome, serie);//, disciplina);

            return materia;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDaDonaMariana.Dominio.ModuloMateria
{
    public class EMateria : Entidade<EMateria>
    {
        public string Nome { get; set; }

        public int Serie { get; set; }

        //public Disciplina disciplina { get; set; }

        public EMateria(string nome, int serie)//, Disciplina disciplina)
        {
            Nome = nome;
            Serie = serie;
            //this.disciplina = disciplina;
        }

        //TODO adicionar disciplina
        public EMateria(int id, string nome, int serie)//, Disciplina disciplina)
               : this(nome, serie)//, disciplina)
        {
            Id = id;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("Digite um Nome da Materia");
            if (string.IsNullOrWhiteSpace(Serie.ToString()))
                erros.Add("Digite um Numero Para Serie");
            if (Serie < 1 || Serie > 9)
                erros.Add("Digite uma Serie valida (1~9)");
            //if (disciplina == null)
            //    erros.Add("Escolha uma Disciplina");

            return erros;
        }

        public override bool Equals(object? obj)
        {
            return obj is EMateria materia &&
                Id == materia.Id &&
                Nome == materia.Nome &&
                Serie == materia.Serie;
               //&& disciplina == materia.disciplina;
        }

    }
}

namespace TestesDaDonaMariana.Dominio.Compartilhado
{
    public abstract class Entidade<TEntidade>
        where TEntidade : Entidade<TEntidade>
    {
        public int Id { get; set; }

        public void Editar(TEntidade entidadeAtualizado)
        {
            // Pega o tipo e para cada propriedade, que não seja o id, atualiza o valor
            typeof(TEntidade).GetProperties().ToList().ForEach(p =>
            {
                if (!p.Name.Equals("Id"))
                    p.SetValue(this, p.GetValue(entidadeAtualizado));
            });
        }

        public virtual void RemoverReferenciasDeMemoria()
        {
        }

        public abstract List<string> Validar();
    }
}

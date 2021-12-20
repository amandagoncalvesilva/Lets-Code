using System;
using System.Collections.Generic;
using System.Linq;

namespace aula01Ambev.Model
{
    public class Filiais
    {
        public Guid id { get; set; }

        public string nome { get; set; }
        public List<Filiais> filiais { get; set; }

        public virtual void CadastrarFilial(string _nome)
        {
            filiais.Add(new Filiais()
            {
              id = Guid.NewGuid(),
              nome = _nome
            });
        }

    public virtual void AtualizarFilial(Guid _id, string novoNome)
    {
        var filial = BuscarFilialPorId(_id);
        filial.nome = novoNome;
    }
    public virtual Filiais BuscarFilialPorId(Guid _id)
    {
        return filiais.FirstOrDefault(x => x.id == _id);
    }
    public virtual Filiais BuscarFilialPorNome(string _nome)
    {
        return filiais.FirstOrDefault(x => x.nome == _nome);
    }
}
}
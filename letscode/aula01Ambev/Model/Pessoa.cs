using System;

namespace aula01Ambev.Model
{

    public class Pessoa
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public string nomeSocial { get; set; }
        public string documento { get; set; }
        public Endereco endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        public virtual void VerificaDocumento(String _documento)
        {

        }
    }
}
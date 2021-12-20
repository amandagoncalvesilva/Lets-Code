using System;

namespace aula01Ambev.Model
{
    public class ClientePf : Cliente
    {
        public override void VerificaDocumento(string _documento)
        {
            if (_documento.Length == 11)
            {
                documento = _documento;
            }
        }
    }
}
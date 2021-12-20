using System;

namespace aula01Ambev.Model
{
    public class ClientePj : Cliente
    {
        public override void VerificaDocumento(string _documento)
        {
            if (_documento.Length == 14)
            {
                documento = _documento;
            }
        }
    }
}
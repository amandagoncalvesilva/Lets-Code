using System;

namespace aula01Ambev.Model{
    public class Cliente : Pessoa
    {
        public void Cadastrar(string _nome, string _nomeSocial, string _telefone, string _email)
        {
            id = Guid.NewGuid();
            nome = _nome;
            nomeSocial = _nomeSocial;
            telefone = _telefone;
            email = _email;
        }
    }
} monta um grupo no teams
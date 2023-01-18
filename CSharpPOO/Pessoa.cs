using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO
{
    class Pessoa
    {
        private string nome;
        private int idade;

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string _nome)
        {
            this.nome = _nome;
        }
        public int getIdade()
        {
            return this.idade;
        }

        public void setIdade(int _idade)
        {
            this.idade = _idade;
        }

        public string ResponderPresenca()
        {
            return "Estou aqui";
        }
    }
}

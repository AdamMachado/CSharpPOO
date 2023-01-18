using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO
{
    class Escola
    {
        private string _nome;
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        public List<Departamento> departamentos = new List<Departamento>();
        
        public void addDepartamento(Departamento departamento)
        {
            this.departamentos.Add(departamento);
        }

        public void ListarDepartamento()
        {
            foreach (Departamento departamento in this.departamentos)
            {
                Console.WriteLine("Departamento: {0}", departamento.Nome);
            }
            Console.WriteLine("\n--------------------------------------------\n");
        
    }
    }
}

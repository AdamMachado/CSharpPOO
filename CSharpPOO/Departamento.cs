using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO
{
    class Departamento
    {
        private string _nome;
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        public List<Professor> professores= new List<Professor>();
        public Escola _escola= new Escola();
        public Escola setEscola
        {
            get => _escola;
            set => _escola = value;
        }




        public void addProfessor(Professor professor)
        {
            this.professores.Add(professor);
        }
        public void ListarProfessores()
        {
            foreach(Professor professor in this.professores)
            {
                Console.WriteLine("Professor: {0}", professor.getNome());
            }
            Console.WriteLine("\n--------------------------------------------\n");
        }
        
    }
    
}

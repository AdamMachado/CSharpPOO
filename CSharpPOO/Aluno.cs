using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CSharpPOO
{
     class Aluno : Pessoa
    {

        private int matricula;
        private bool presente;
        public List<Professor> professores = new List<Professor>(); 




        public int Matricula
        {
            get => matricula;
            set => matricula = value > 100 ? throw new Exception("Matricula não pode ser maior do que o número 100"):value; 
        }
        public bool Presente
        {
            get => presente;
            set => presente = value;
        }

        public void imprimir()
        {
            WriteLine("Nome: {0}",this.getNome());
            WriteLine("Idade: {0}", this.getIdade());
            WriteLine("Matrícula: {0}", this.matricula);
            WriteLine("Presente: {0}", this.ResponderPresenca());
            WriteLine("\n--------------------------------------------\n");
        }

        public string ResponderPresenca()
        {
            if (this.Presente)
            {
                return "Presente";
            }
            else
            {
                return "...";
            }
            
        }

        public void addProfessor(Professor professor)
        {
            this.professores.Add(professor);
        }
    }
}

using System;
using static System.Console;

namespace CSharpPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Departamento humanas = new Departamento();
            humanas.Nome = "Departamento de Humanas";
            Departamento exatas = new Departamento();
            humanas.Nome = "Departamento de Exatas";

            Aluno joaozinho = new Aluno();
            joaozinho.setNome("João da Silva");
            joaozinho.setIdade(12);
            joaozinho.Matricula = 13;
            joaozinho.Presente=false;
            joaozinho.imprimir();

            Aluno ritinha = new Aluno();
            ritinha.setNome("Rita de Souza");
            ritinha.setIdade(11);
            ritinha.Matricula = 89;
            ritinha.Presente=true;
            ritinha.imprimir();



            Professor jose = new Professor();
            jose.setNome("José de Oliveira");
            jose.setIdade(35);
            jose.ValorHora = 30;
            jose.Tipo = 1;
            jose.Bonus = 0;
            Console.WriteLine("Salario: {0:c}", jose.CalcularSalarioFinal(120));
            jose.imprimir();
            jose.AddAluno(joaozinho);
            jose.AddAluno(ritinha);
            jose.ImprimirAlunos();
            jose.setDepartamento = exatas;



            Professor maria = new Professor();
            maria.setNome("Maria Teixeira");
            maria.setIdade(48);
            maria.ValorHora = 30;
            maria.Tipo = 2;
            maria.Bonus = 15;
            Console.WriteLine("Salario: {0:c}", maria.CalcularSalarioFinal(160));
            maria.imprimir();
            maria.AddAluno(ritinha);
            maria.ImprimirAlunos();
            maria.setDepartamento = humanas;

            joaozinho.addProfessor(jose);

            humanas.addProfessor(maria);
            exatas.addProfessor(jose);

            ReadKey();
        }
    }
}

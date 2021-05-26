using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Lista2.Ex3
{
    class Ex3
    {
        public void Exercicio3()
        {
            Aluno a = new Aluno();
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota final = " + a.NotaFinal());
            if(a.NotaFinal() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60 - a.NotaFinal()) + " PONTOS");
            }
        }
    }
}

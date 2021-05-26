using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Lista1.Ex2
{
    public class Ex2
    {
        public void Exercicio2()
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();
            double media;

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.Salario = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.Salario = double.Parse(Console.ReadLine());

            media = (func1.Salario + func2.Salario) / 2;

            Console.WriteLine("Salário médio: R$ {0}", media.ToString("F2"));

        }
    }
}

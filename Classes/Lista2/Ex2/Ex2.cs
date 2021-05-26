using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Lista2.Ex2
{
    class Ex2
    {
        public void Exercicio2()
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Funcionario: " + f);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}

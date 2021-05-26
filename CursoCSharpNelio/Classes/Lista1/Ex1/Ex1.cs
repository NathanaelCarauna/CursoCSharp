using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Lista1.Ex1
{
    public class Ex1
    {
        public void Exercicio1()
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: {0}", pessoa1.Nome);
            }
            else if (pessoa1.Idade < pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            }
            else
            {
                Console.WriteLine($"{pessoa1.Nome} e {pessoa2.Nome} tem a mesma idade");
            }
        }
    }
}

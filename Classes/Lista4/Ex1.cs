using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Lista4
{
    class Ex1
    {
        public static void Exercicio1()
        {
            Conta conta;
            string numero, titular;
            double valor;
            
            Console.Write("Entre com o número da conta: ");
            numero = Console.ReadLine();
            
            Console.Write("Entre o Titular da conta: ");
            titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial?(s/n)");
            if (Console.ReadLine().Equals("s"))
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
                conta = new Conta(titular, numero, valor);
            }
            else
            {
                conta = new Conta(titular, numero);
            }

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para depósito: R$ ");
            valor = double.Parse(Console.ReadLine());
            conta.Depositar(valor);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para saque: R$");
            valor = double.Parse(Console.ReadLine());
            conta.Sacar(valor);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}

using System;

namespace LogicaDeProgramacao
{
    internal class EstruturaCondicionalExPropostos
    {
        public EstruturaCondicionalExPropostos()
        {
        }

        internal void Ex1()
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0) Console.WriteLine("NEGATIVO");
            else Console.WriteLine("NÃO NEGATIVO");
        }

        internal void Ex2()
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }

        internal void Ex3()
        {
            string[] s = Console.ReadLine().Split(' ');
            int a, b;
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);

            if (a >= b && a % b == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else if (a < b && b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Não sao Multiplos");
            }
        }
        internal void Ex4()
        {
            string[] s = Console.ReadLine().Split(' ');
            int inicio, fim, duracao = 0;
            inicio = int.Parse(s[0]);
            fim = int.Parse(s[1]);


            if (inicio == fim)
            {
                duracao = 24;
            }
            else if (inicio < fim)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = fim + 24 - inicio;
            }
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);

        }
        internal void Ex5()
        {
            string[] s = Console.ReadLine().Split(' ');
            int codigo = int.Parse(s[0]);
            int qtd = int.Parse(s[1]);
            double valor = 0, total = 0;

            if (codigo == 1)
            {
                valor = 4;
            }
            else if (codigo == 2)
            {
                valor = 4.5;
            }
            else if (codigo == 3)
            {
                valor = 5;
            }
            else if (codigo == 4)
            {
                valor = 2;
            }
            else if (codigo == 5)
            {
                valor = 1.5;
            }
            total = valor * qtd;
            Console.WriteLine($"Total: R$ {total:F2}");

        }
    }
}
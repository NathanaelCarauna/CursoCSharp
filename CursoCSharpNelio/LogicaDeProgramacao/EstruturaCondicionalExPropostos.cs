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
    }
}
using System;

namespace LogicaDeProgramacao
{
    internal class EstruturaWhile
    {
        public EstruturaWhile()
        {
        }

        internal void Ex1()
        {
            string senha = "2002";
            string entrada = Console.ReadLine();
            while (senha != entrada)
            {
                Console.WriteLine("Senha inválida");
                entrada = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");
        }

        internal void Ex2()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0)
                {
                    if (y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    if (y < 0)
                    {
                        Console.WriteLine("quarto");
                    }
                }
                else
                {
                    if (y > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    if (y < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                }
                entrada = Console.ReadLine().Split(' ');
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);
            }
        }
    }
}
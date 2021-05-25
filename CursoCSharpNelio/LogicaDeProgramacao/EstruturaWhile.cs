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
            while(senha != entrada)
            {
                Console.WriteLine("Senha inválida");
                entrada = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
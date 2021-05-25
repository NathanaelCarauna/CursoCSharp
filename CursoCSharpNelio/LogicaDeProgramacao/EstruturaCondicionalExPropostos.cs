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
    }
}
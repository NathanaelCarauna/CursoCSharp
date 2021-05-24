using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaDeProgramacao
{
    public class EstruturaSequencialExPropostos
    {
        public void Ex1()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine("SOMA = {0}", soma.ToString());
        }

        internal void Ex2()
        {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A={area.ToString("F4")}");
        }
    }
}

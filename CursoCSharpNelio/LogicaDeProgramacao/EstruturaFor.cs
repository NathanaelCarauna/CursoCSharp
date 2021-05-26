using System;

namespace LogicaDeProgramacao
{
    internal class EstruturaFor
    {
        internal void Ex1()
        {
            int x = int.Parse(Console.ReadLine());
            for(int i = 1; i <= x; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
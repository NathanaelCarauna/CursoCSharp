﻿using System;

namespace LogicaDeProgramacao
{
    internal class EstruturaFor
    {
        internal void Ex1()
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        internal void Ex2()
        {
            int x = int.Parse(Console.ReadLine());
            int valor, dentro = 0, fora = 0;
            for (int i = 0; i < x; i++)
            {
                valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20) dentro++;
                else fora++;
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine($"{fora} out");
        }

        internal void Ex3()
        {
            int x = int.Parse(Console.ReadLine());
            string[] s;
            double v1, v2, v3, media;
            for (int i = 0; i < x; i++)
            {
                s = Console.ReadLine().Split(' ');
                v1 = double.Parse(s[0]);
                v2 = double.Parse(s[1]);
                v3 = double.Parse(s[2]);
                media = (v1 * 2 + v2 * 3 + v3 * 5) / 10;
                Console.WriteLine(media.ToString("F1"));
            }
        }
    }
}
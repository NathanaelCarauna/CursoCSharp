using System;

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

        internal void Ex4()
        {
            int x = int.Parse(Console.ReadLine());
            string[] s;
            int v1, v2;
            for(int i = 0; i < x; i++)
            {
                s = Console.ReadLine().Split(' ');
                v1 = int.Parse(s[0]);
                v2 = int.Parse(s[1]);
                if (v2 == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }
                else
                {
                    double resultado = (double)v1 / v2;
                    Console.WriteLine(resultado.ToString("F1"));
                }
            }
        }

        internal void Ex5()
        {
            int fat = int.Parse(Console.ReadLine());
            int resultado = 1;
            for(int i = fat; i > 0; i--)
            {
                resultado *= i;
            }
            Console.WriteLine(resultado);
        }


        internal void Ex6()
        {
            int x = int.Parse(Console.ReadLine());
            for(int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        internal void Ex7()
        {
            int x = int.Parse(Console.ReadLine());
            for(int i= 1; i <= 5; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }
        }
    }
}
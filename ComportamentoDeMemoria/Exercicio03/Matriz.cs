using System;
using System.Collections.Generic;
using System.Text;

namespace ComportamentoDeMemoria.Exercicio03
{
    class Matriz
    {
        public static void Exercicio01()
        {
            string[] s = Console.ReadLine().Split(' ');
            int m, n;
            m = int.Parse(s[0]);
            n = int.Parse(s[1]);

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                var values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            int value = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == value)
                    {
                        Console.WriteLine($"Position {i},{j}");
                        if(j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i,j-1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Top: " + matriz[i-1, j]);
                        }
                        if(j< m)
                        {
                            Console.WriteLine("Right: " + matriz[i, j+1]);
                        }
                        if (i < n )
                        {
                            Console.WriteLine("Down: " + matriz[i+1, j]);
                        }
                    }
                }
            }
        }
    }
}

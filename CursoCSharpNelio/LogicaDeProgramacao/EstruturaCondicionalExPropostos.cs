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
        internal void Ex6()
        {
            double valor = double.Parse(Console.ReadLine());
            string intervalo = "";

            if (valor < 0 || valor > 100)
            {
                intervalo = "Fora de intervalo";
            }
            else if (valor >= 0 && valor <= 25)
            {
                intervalo = "[0,25]";
            }
            else if (valor <= 50)
            {
                intervalo = "(25,50]";
            }
            else if (valor <= 75)
            {
                intervalo = "(50,75]";
            }
            else if (valor <= 100)
            {
                intervalo = "(75,100]";
            }

            if (intervalo.Equals("Fora de intervalo"))
            {
                Console.WriteLine(intervalo);
            }
            else
            {
                Console.WriteLine($"Intervalo {intervalo}");
            }
        }

        internal void Ex7()
        {
            string[] s = Console.ReadLine().Split(' ');
            double x, y;
            x = double.Parse(s[0]);
            y = double.Parse(s[1]);
            string posicao = "";

            if (x == y && x == 0)
            {
                posicao = "Origem";
            }
            else if (x == 0 && y != 0)
            {
                posicao = "Eixo Y";
            }
            else if (y == 0 && x != 0)
            {
                posicao = "Eixo X";
            }
            else if (x > 0)
            {
                if (y > 0)
                {
                    posicao = "Q1";
                }
                if (y < 0)
                {
                    posicao = "Q4";
                }
            }else if (x < 0)
            {
                if (y > 0)
                {
                    posicao = "Q2";
                }
                if (y < 0)
                {
                    posicao = "Q3";
                }
            }
            Console.WriteLine(posicao);
        }
    }
}
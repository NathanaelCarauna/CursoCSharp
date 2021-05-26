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

        internal void Ex3()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int diferenca = (a * b - c * d);
            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
        internal void Ex4()
        {
            int numero = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorPorHora = double.Parse(Console.ReadLine());
            double salario = valorPorHora * horasTrabalhadas;
            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
        internal void Ex5()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(entrada[0]);
            int qtd1 = int.Parse(entrada[1]);
            double valor1 = double.Parse(entrada[2]);
            entrada = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(entrada[0]);
            int qtd2 = int.Parse(entrada[1]);
            double valor2 = double.Parse(entrada[2]);

            double total = qtd1 * valor1 + qtd2 * valor2;
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        }
        internal void Ex6()
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double a = double.Parse(entrada[0]);
            double b = double.Parse(entrada[1]);
            double c = double.Parse(entrada[2]);

            double trianguloR = (a * c) / 2;
            double circulo = Math.PI * Math.Pow(c, 2);
            double trapezio = ((a + b) * c) / 2;
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + trianguloR.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPÉZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
            
        }
    }
}

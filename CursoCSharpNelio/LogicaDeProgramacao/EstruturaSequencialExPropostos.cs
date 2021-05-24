﻿using System;
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
    }
}

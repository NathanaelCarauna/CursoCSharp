using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Lista3
{
    class Ex1
    {
        public static void Exercicio1()
        {
            double cotacao, qtd;
            Console.Write("Qual a cotação do dolar? ");
            cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares você vai comprar? ");
            qtd = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Valor a ser pago em reais = R$ " + ConversorDeMoeda.Converter(cotacao, qtd).ToString("F2"));


        }
    }
}

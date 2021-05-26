using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Lista2.Ex1
{
    public class Ex1
    {
        public void Exercicio1()
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area: {r.Area()}");
            Console.WriteLine($"Perimetro: {r.Perimetro()}");
            Console.WriteLine($"Diagonal: {r.Diagonal()}");

        }
    }
}

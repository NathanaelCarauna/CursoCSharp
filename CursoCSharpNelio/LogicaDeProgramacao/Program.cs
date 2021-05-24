using System;
using System.Globalization;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1}", produto1, preco1);
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            Console.WriteLine($"{idade} anos de idade, código {codigo} e genero: {genero}");
            Console.WriteLine("Medida com 8 casas decimais {0:F8}", medida);
            Console.WriteLine($"Arredondando (3 casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: {0:F3}", medida.ToString( CultureInfo.InvariantCulture));
        }
    }
}

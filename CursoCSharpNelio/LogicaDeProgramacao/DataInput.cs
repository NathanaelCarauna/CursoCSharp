using System;

namespace LogicaDeProgramacao
{
    internal class DataInput
    {
        internal void Exercicio()
        {
            Console.WriteLine("Entre com seu nome completo");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string[] entrada = Console.ReadLine().Split(' ');
            string ultimoNome = entrada[0];
            int idade = int.Parse(entrada[1]);
            double altura = double.Parse(entrada[2]);
            Console.WriteLine();
            Console.WriteLine("Nome completo {0}", nomeCompleto);
            Console.WriteLine($"Número de quartos: {qtdQuartos}");
            Console.WriteLine($"Preço do produto: R$ {preco.ToString("F2")}");
            Console.WriteLine("Ultimo nome: " + ultimoNome );
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura.ToString("F2")}");
        }
    }
}
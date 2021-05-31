using Inheritance.Exercicio04.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Exercicio04
{
    class Ex04
    {
        public static void Exercicio04()
        {
            List<Taxpayer> taxpayers = new List<Taxpayer>();

            Console.Write("Enter the number of payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Health expenses: ");
                    double healthExpenses = double.Parse(Console.ReadLine());
                    taxpayers.Add(new PhysicalPerson(name, anualIncome, healthExpenses));
                }
                if(ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int number = int.Parse(Console.ReadLine());
                    taxpayers.Add(new Company(name, anualIncome, number));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            foreach(var payer in taxpayers)
            {
                Console.WriteLine( payer); 
            }
        }
    }
}

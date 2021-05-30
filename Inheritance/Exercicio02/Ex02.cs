using Inheritance.Exercicio02.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Exercicio02
{
    class Ex02
    {
        public static void Exercicio02()
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1;i<=n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                switch (type)
                {
                    case 'c':
                        products.Add(new Product(name, price));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(name, price, customsFee));
                        break;
                }

            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach(var obj in products)
            {
                Console.WriteLine(obj.PriceTag());
            }
        }
    }
}

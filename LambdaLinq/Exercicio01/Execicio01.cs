using LambdaLinq.Exercicio01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Globalization;

namespace LambdaLinq.Exercicio01
{
    class Execicio01
    {
        public static void Ex01()
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    products.Add(new Product(line[0], double.Parse(line[1], CultureInfo.InvariantCulture)));
                }
            }
            foreach(var p in products)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            double average = products.Average(p => p.Price);
            Console.WriteLine("Avarage price: $ " + average.ToString("F2", CultureInfo.InvariantCulture));
            var namesLessThanAvarage = products.Where(p => p.Price < average).Select(p => p.Name).OrderByDescending(p => p) ;
            foreach(var p in namesLessThanAvarage)
            {
                Console.WriteLine(p);
            }
        }
    }
}

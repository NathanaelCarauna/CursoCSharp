using IOFiles.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace IOFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                List<Product> products = new List<Product>();

                string appDirectory = Environment.CurrentDirectory + @"../../../../";
                string csvFile = appDirectory + @"/csvFolder/itemsSold.csv";
                string targetFile = appDirectory + "csvFolder/out/summary.csv";

                using (StreamReader sr = File.OpenText(csvFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double value = double.Parse(line[1], CultureInfo.InvariantCulture);
                        int qtd = int.Parse(line[2]);
                        products.Add(new Product(name, value, qtd));
                    }
                }

                using (StreamWriter sw = File.AppendText(targetFile))
                {
                    foreach (var product in products)
                    {
                        sw.WriteLine(product.Name+","+product.TotalValue().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

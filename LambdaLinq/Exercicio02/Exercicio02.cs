using LambdaLinq.Exercicio02.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;

namespace LambdaLinq.Exercicio02
{
    class Exercicio02
    {
        public static void Ex02()
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter full file path: ");
            var path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    string email = line[1];
                    double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }
            Console.Write("Email of people whose salary is more than: $ ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var emailOfWhoseSalaryMoreThan = list.Where(p => p.Salary > value).OrderBy(p => p.Email).Select(p => p.Email);
            foreach( var e in emailOfWhoseSalaryMoreThan)
            {
                Console.WriteLine(e);
            }
            double sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': $" + sum);

        }
    }
}

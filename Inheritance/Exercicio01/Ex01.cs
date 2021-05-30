using Inheritance.Exercicio01.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Exercicio01
{
    class Ex01
    {
        public static void Exercicio01()
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char isOutsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Employee employee;
                if (isOutsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employee = new OutSourceEmployee(name,hours, valuePerHour, additionalCharge);
                }else
                {
                    employee = new Employee(name, hours, valuePerHour);                    
                }
                employees.Add(employee);

            }

            Console.WriteLine("\nPAYMENTS: ");
            foreach(var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}

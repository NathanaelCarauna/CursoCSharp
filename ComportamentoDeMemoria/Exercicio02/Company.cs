using System;
using System.Collections.Generic;
using System.Text;

namespace ComportamentoDeMemoria.Exercicio02
{
    class Company
    {
        public static void Manegement()
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            int id;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEmployee #" + (i + 1) + ":");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee ID  that will have his salary increased: ");
            id = int.Parse(Console.ReadLine());
            var employee = employees.Find(x => x.Id == id);
            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                var percentage = double.Parse(Console.ReadLine());
                employee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This ID doesn't exist!\n");
            }

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}

using ComposicaoEEnums.Exercicio01.Entities;
using ComposicaoEEnums.Exercicio01.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ComposicaoEEnums.Exercicio01
{
    class Ex01
    {
        public static void Exercicio01()
        {
            Console.Write("Enter department name: ");
            Department department = new Department(Console.ReadLine());
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker? ");
            int qtdContracts = int.Parse(Console.ReadLine());

            Worker worker = new Worker(name, level, baseSalary, department);

            for(int i = 1; i <= qtdContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string dateEntry = Console.ReadLine();
            int month = int.Parse(dateEntry.Substring(0,2));
            int year = int.Parse(dateEntry.Substring(3,4));
            double income = worker.Income(year, month);
            Console.WriteLine(worker);
            Console.WriteLine($"Income for {dateEntry}: R$ {income:F2}");
        }
    }
}

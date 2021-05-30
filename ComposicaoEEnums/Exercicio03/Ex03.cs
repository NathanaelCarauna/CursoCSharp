using ComposicaoEEnums.Exercicio03.Entities;
using ComposicaoEEnums.Exercicio03.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoEEnums.Exercicio03
{
    class Ex03
    {
        public static void Exercicio03()
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            var client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(client, DateTime.Now, status);
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Enter #{i} item data");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int qte = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem(new Product(pName, pPrice), qte);
                order.AddItem(item);
            }

            Console.WriteLine(order);
        }
    }
}

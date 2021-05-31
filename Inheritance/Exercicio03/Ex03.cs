using Inheritance.Exercicio03.Entities;
using Inheritance.Exercicio03.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Exercicio03
{
    class Ex03
    {
        public static void Exercicio03()
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or circle (r/c)? ");
                char kind = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(kind == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(color, width, height));
                }
                else if(kind == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine("\nSHAPES AREAS:");
            foreach(var shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}

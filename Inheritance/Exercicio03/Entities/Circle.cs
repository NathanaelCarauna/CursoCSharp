using Inheritance.Exercicio03.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Exercicio03.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

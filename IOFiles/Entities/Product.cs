using System;
using System.Collections.Generic;
using System.Text;

namespace IOFiles.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double value, int soldQty)
        {
            Name = name;
            Price = value;
            Quantity = soldQty;
        }

        public double TotalValue()
        {
            return Price * Quantity;
        }
    }
}

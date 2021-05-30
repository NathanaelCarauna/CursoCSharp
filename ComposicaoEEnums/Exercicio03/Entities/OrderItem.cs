using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoEEnums.Exercicio03.Entities
{
    class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = Product.Price;
        }

        public double Subtotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Price:F2}, Quantity: {Quantity}, Subtotal: ${Subtotal():F2}";
        }
    }
}

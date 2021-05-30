using ComposicaoEEnums.Exercicio03.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoEEnums.Exercicio03.Entities
{
    class Order
    {
        public Client Client { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        

        public Order()
        {

        }

        public Order(Client client, DateTime moment, OrderStatus status)
        {
            Client = client;
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach(var item in Items)
            {
                total += item.Subtotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");

            foreach(var item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}

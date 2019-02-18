using System;
using System.Collections.Generic;
using System.Text;
using Shopping.Entities.Enums;
using System.Globalization;

namespace Shopping.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public  Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
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
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.Subtotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: "+ Date.ToString("dd/MM/yyyy HH:mm:ss "));
            sb.AppendLine("Order status " + Status);
            sb.AppendLine("Client " + Client);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $"  + Total().ToString(("F2"), CultureInfo.InvariantCulture));
            return sb.ToString();

            

        }
    }
}

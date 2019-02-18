using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChamadaOs.Entities.Enums;

namespace ChamadaOs.Entities
{
    class Ordercs
    {
        public DateTime DateTime { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderService> Items { get; set; } = new List<OrderService>();

        public Ordercs()
        {
        }

        public Ordercs(DateTime dateTime, OrderStatus status, Client client)
        {
            DateTime = dateTime;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderService item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderService item)
        {
            Items.Remove(item);
        }
        public int TotalServices()
        {
            int sum = 0;
            foreach (OrderService item in Items)
            {
                sum += item.Cont();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Order status: "+Status);
            stringBuilder.AppendLine("Service: "+Client);
            stringBuilder.AppendLine("Order items:");
            foreach (OrderService item in Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            stringBuilder.AppendLine("Total services"+TotalServices());
            return stringBuilder.ToString();

            
        }

    }
}

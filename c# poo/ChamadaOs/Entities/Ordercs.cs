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
        public List<Components> components { get; set; } = new List<Components>();

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
        public void AddComponent(Components component)
        {
            components.Add(component);
        }
        public void RemoveComponent(Components component)
        {
            components.Remove(component);
        }

        public int TotalComponent()
        {
            int sum=0;
            foreach (Components comp in components)
            {
                sum += comp.ContComp();
            }
            return sum=0;
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
            stringBuilder.AppendLine("Order moment: "+ DateTime.ToString("dd/MM/yyyy HH:mm:ss"));
            
            stringBuilder.AppendLine("Order status: "+Status);
            stringBuilder.AppendLine("Service: "+Client);
            stringBuilder.AppendLine("Order items:");
            foreach (OrderService item in Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            stringBuilder.AppendLine("Total services"+TotalServices());
            foreach (Components comp in components)
            {
                stringBuilder.AppendLine(comp.ToString());
            }
            stringBuilder.AppendLine("Total components" + TotalServices());
            return stringBuilder.ToString();

            
        }

    }
}

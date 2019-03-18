using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Call.Entities;
using Call.Entities.Enums;

namespace Call.Entities
{
    class Order
    {
        public DateTime DateTime { get; set; }
        public OrderStatus Status { get; set; }
        public Trainee Trainee { get; set; }
        public List<Service> Service { get; set; } = new List<Service>();
        public List<OrderService> OrderServices { get; set; } = new List<OrderService>();
        public List<Components> Components { get; set; } = new List<Components>();

        public Order()
        {
        }

        public Order(DateTime dateTime, OrderStatus status, Trainee trainee) { 
            this.DateTime = dateTime;
            this.Status = status;
            this.Trainee = trainee;
         
        }

        public void AddService(OrderService order)
        {
            OrderServices.Add(order);
        }
        public void RemoveService(OrderService order)
        {
            OrderServices.Remove(order);
        }

        public void AddComponent(Components component)
        {
            Components.Add(component);
        }
        public void RemoveComponent(Components component)
        {
            Components.Remove(component);
        }

        public int TotalOrderService()
        {
            int sum = 0;
            foreach (OrderService ord in OrderServices)
            {
                sum += ord.ContService();
            }
            return sum;
        }
        public int Totalcomponent()
        {
            int sum = 0;
            foreach (Components comp in Components)
            {
                sum += comp.TotalComponents();
            }
            return sum;
        }
        public int TotalService()
        {
            int sum = 0;
            foreach (Service serv in Service)
            {
                sum += serv.ContService();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: \n" + DateTime.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status: \n" + Status);
            sb.AppendLine("Data trainee: \n" + Trainee);
                 
            
            foreach (Components comp in Components)
            {
                sb.AppendLine(comp.ToString());
            }
            sb.AppendLine("Total components: \n" + Totalcomponent());
            foreach (Service serv in Service)
            {
                sb.AppendLine(serv.ToString());
            }
            sb.AppendLine("Total services: \n" + Service.ToString());
            sb.AppendLine("Order service: \n");
            foreach (OrderService ord in OrderServices)
            {
                sb.AppendLine(ord.ToString());
            }
            sb.AppendLine("Total Orderservice: \n" + TotalOrderService());
            
            return sb.ToString();
        }

    }
}

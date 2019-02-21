using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Call.Entities;
using Call.Entities.Enums;

namespace Call.Entities
{
    class OrderService
    {
        public  Service Service { get; set; }
        public int Quantity { get; set; }

        public OrderService()
        {
        }

        public OrderService(Service service, int quantity)
        {
            this.Service = service;
            this.Quantity = quantity;
        }

        public int ContService()
        {
            return Quantity;
        }

        public override string ToString()
        {
            return "quantity components in order service: \n"
                + Service.QuantService;

        }
    }
}

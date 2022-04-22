using mert_software_task.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Entities.Concrete.API
{
    public class Order : IEntity
    {
        public int id { get; set; }
        public string customerId { get; set; }
        public int employeeId { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime requiredDate { get; set; }
        public DateTime shippedDate { get; set; }
        public int shipVia { get; set; }
        public float freight { get; set; }
        public string shipName { get; set; }
        public ShipAddressOfOrder shipAddress { get; set; }
        public DetailOfOrder details { get; set; }

    }
    public class ShipAddressOfOrder : IEntity
    {
        public string street { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
    }
    public class DetailsfOrder : IEntity
    {
        public int productId { get; set; }
        public int unitPrice { get; set; }
        public int quantity { get; set; }
        public int discount { get; set; }
    }
}

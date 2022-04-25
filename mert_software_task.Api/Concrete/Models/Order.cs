using mert_software_task.Api.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Api.Concrete.Models

{
    public class Order : IEntity
    {
        public int id { get; set; }
        public string customerId { get; set; }
        public int employeeId { get; set; }
        public DateTime? orderDate { get; set; }
        public DateTime? requiredDate { get; set; }
        public string shippedDate { get; set; }
        public int shipVia { get; set; }
        public float freight { get; set; }
        public string shipName { get; set; }
        public ShipAddressOfOrder shipAddress { get; set; }
        public List<DetailsOfOrder> details { get; set; }

    }
}

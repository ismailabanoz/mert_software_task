using mert_software_task.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Entities.Concrete
{
    public class Order :IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int ShipAddressId { get; set; }
        public int DetailsId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredTime { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public float Freight { get; set; }
        public string ShipName { get; set; }
    }
}

using mert_software_task.Api.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Api.Concrete.Models
{
    public class Supplier : IEntity
    {
        public int id { get; set; }
        public string companyName { get; set; }
        public string contactName { get; set; }
        public string contactTitle { get; set; }
        public AddressOfSupplier address { get; set; }
    }
}

using mert_software_task.Api.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Api.Concrete.Models
{
    public class Shipper : IEntity
    {
        public int id { get; set; }
        public string companyName { get; set; }
        public string phone { get; set; }
    }
}

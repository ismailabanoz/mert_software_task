using mert_software_task.Api.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Api.Concrete.Models
{
    public class Employee : IEntity
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string title { get; set; }
        public string titleOfCourtesy { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime hireDate { get; set; }
        public AddressOfEmloyee address { get; set; }
        public string notes { get; set; }
        public string reportsTo { get; set; }
        public int[] territoryIds { get; set; }
    }
}

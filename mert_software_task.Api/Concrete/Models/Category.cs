using mert_software_task.Api.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Api.Concrete.Models
{
    public class Category : IEntity
    {
        public int id { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }
}

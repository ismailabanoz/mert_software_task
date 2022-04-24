using mert_software_task.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Entities.Concrete.API
{
    public class DetailsOfOrder :IEntity
    {
        public int productId { get; set; }
        public int unitPrice { get; set; }
        public int quantity { get; set; }
        public int discount { get; set; }
    }
}

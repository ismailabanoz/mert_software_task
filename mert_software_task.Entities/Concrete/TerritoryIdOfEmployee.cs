using mert_software_task.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Entities.Concrete
{
    public class TerritoryIdOfEmployee : IEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Territory { get; set; }
    }
}

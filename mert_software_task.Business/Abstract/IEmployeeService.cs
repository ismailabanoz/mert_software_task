using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        void Add(Employee archive);
        void Update(Employee archive);
        void Delete(Employee archive);
        List<Employee> SearchAll(string key);
    }
}

using mert_software_task.Entities.ComplexTypes;
using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        void Add(Customer archive);
        void Update(Customer archive);
        void Delete(Customer archive);
        List<Customer> SearchAll(string key);
        List<GetCustomers> GetCustomers();
    }
}

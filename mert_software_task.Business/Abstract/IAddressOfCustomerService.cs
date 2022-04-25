using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface IAddressOfCustomerService
    {
        List<AddressOfCustomer> GetAll();
        void Add(AddressOfCustomer archive);
        void Update(AddressOfCustomer archive);
        void Delete(AddressOfCustomer archive);
        List<AddressOfCustomer> SearchAll(string key);
    }
}

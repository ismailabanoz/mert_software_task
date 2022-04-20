using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface IAddressOfSupplierService
    {
        List<AddressOfSupplier> GetAll();
        void Add(AddressOfSupplier archive);
        void Update(AddressOfSupplier archive);
        void Delete(AddressOfSupplier archive);
        List<AddressOfSupplier> SearchAll(string key);
    }
}

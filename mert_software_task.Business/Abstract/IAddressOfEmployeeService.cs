using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface IAddressOfEmployeeService
    {
        List<AddressOfEmployee> GetAll();
        void Add(AddressOfEmployee archive);
        void Update(AddressOfEmployee archive);
        void Delete(AddressOfEmployee archive);
        List<AddressOfEmployee> SearchAll(string key);
    }
}

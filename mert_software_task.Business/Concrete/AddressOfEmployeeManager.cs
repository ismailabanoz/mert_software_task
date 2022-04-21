using mert_software_task.Business.Abstract;
using mert_software_task.DataAccess.Abstract;
using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Concrete
{
    public class AddressOfEmployeeManager: IAddressOfEmployeeService
    {
        IAddressOfEmployeeDal _AddressOfEmployeeDal;
        public AddressOfEmployeeManager(IAddressOfEmployeeDal addressOfEmployeeDal)
        {
            _AddressOfEmployeeDal = addressOfEmployeeDal;
        }
        public void Add(AddressOfEmployee addressOfEmployee)
        {
            _AddressOfEmployeeDal.Add(addressOfEmployee);
        }

        public void Delete(AddressOfEmployee addressOfEmployee)
        {
            _AddressOfEmployeeDal.Delete(addressOfEmployee);
        }

        public List<AddressOfEmployee> GetAll()
        {
            return _AddressOfEmployeeDal.GetAll();
        }

        public void Update(AddressOfEmployee addressOfEmployee)
        {
            _AddressOfEmployeeDal.Update(addressOfEmployee);
        }
        public List<AddressOfEmployee> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _AddressOfEmployeeDal.GetAll().Where(p => p.City.ToLower().Contains(keyToLower)).ToList();
        }
    }
}

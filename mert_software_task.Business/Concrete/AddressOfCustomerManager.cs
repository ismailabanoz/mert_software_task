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
    public class AddressOfCustomerManager :IAddressOfCustomerService
    {
        private IAddressOfCustomerDal _AddressOfCustomerDal;
        public AddressOfCustomerManager(IAddressOfCustomerDal addressOfCustomerDal)
        {
            _AddressOfCustomerDal = addressOfCustomerDal;
        }
        public void Add(AddressOfCustomer addressOfCustomer)
        {
            _AddressOfCustomerDal.Add(addressOfCustomer);
        }

        public void Delete(AddressOfCustomer addressOfCustomer)
        {
            _AddressOfCustomerDal.Delete(addressOfCustomer);
        }

        public List<AddressOfCustomer> GetAll()
        {
            return _AddressOfCustomerDal.GetAll();
        }

        public void Update(AddressOfCustomer addressOfCustomer)
        {
            _AddressOfCustomerDal.Update(addressOfCustomer);
        }
        public List<AddressOfCustomer> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _AddressOfCustomerDal.GetAll().Where(p => p.City.ToLower().Contains(keyToLower)).ToList();
        }
    }
}

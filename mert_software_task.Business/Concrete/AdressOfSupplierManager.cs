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
    public class AdressOfSupplierManager : IAddressOfSupplierService
    {
        IAddressOfSupplierDal _AddressOfSupplierDal;
        public AdressOfSupplierManager(IAddressOfSupplierDal addressOfSupplierDal)
        {
            _AddressOfSupplierDal = addressOfSupplierDal;
        }
        public void Add(AddressOfSupplier addressOfSupplier)
        {
            _AddressOfSupplierDal.Add(addressOfSupplier);
        }

        public void Delete(AddressOfSupplier addressOfSupplier)
        {
            _AddressOfSupplierDal.Delete(addressOfSupplier);
        }

        public List<AddressOfSupplier> GetAll()
        {
            return _AddressOfSupplierDal.GetAll();
        }

        public void Update(AddressOfSupplier addressOfSupplier)
        {
            _AddressOfSupplierDal.Update(addressOfSupplier);
        }
        public List<AddressOfSupplier> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _AddressOfSupplierDal.GetAll().Where(p => p.City.ToLower().Contains(keyToLower)).ToList();
        }
    }
}

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
    public class SupplierManager : ISupplierService
    {
        ISupplierDal _SupplierDal;
        public SupplierManager(ISupplierDal supplierDal)
        {
            _SupplierDal = supplierDal;
        }
        public void Add(Supplier supplier)
        {
            _SupplierDal.Add(supplier);
        }

        public void Delete(Supplier supplier)
        {
            _SupplierDal.Delete(supplier);
        }

        public List<Supplier> GetAll()
        {
            return _SupplierDal.GetAll();
        }

        public void Update(Supplier supplier)
        {
            _SupplierDal.Update(supplier);
        }
        public List<Supplier> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _SupplierDal.GetAll().Where(p => p.CompanyName.ToLower().Contains(keyToLower)).ToList();
        }
    }
}

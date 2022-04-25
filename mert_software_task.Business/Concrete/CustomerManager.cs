using mert_software_task.Business.Abstract;
using mert_software_task.DataAccess.Abstract;
using mert_software_task.Entities.ComplexTypes;
using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Concrete
{
    public class CustomerManager :ICustomerService
    {
        ICustomerDal _CustomerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _CustomerDal = customerDal;
        }
        public void Add(Customer customer)
        {
            _CustomerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _CustomerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _CustomerDal.GetAll();
        }

        public void Update(Customer customer)
        {
            _CustomerDal.Update(customer);
        }
        public List<Customer> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _CustomerDal.GetAll().Where(p => p.CompanyName.ToLower().Contains(keyToLower)).ToList();
        }
        public List<GetCustomers> GetCustomers()
        {
            return _CustomerDal.GetCustomers();
        }
    }
}

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
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;
        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }
        public void Add(Product product)
        {
            _ProductDal.Add(product);
        }

        public void Delete(Product product)
        {
            _ProductDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _ProductDal.GetAll();
        }

        public void Update(Product product)
        {
            _ProductDal.Update(product);
        }
        public List<Product> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _ProductDal.GetAll().Where(p => p.Name.ToLower().Contains(keyToLower)).ToList();
        }
    }
}

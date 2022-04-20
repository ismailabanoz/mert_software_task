using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product archive);
        void Update(Product archive);
        void Delete(Product archive);
        List<Product> SearchAll(string key);
    }
}

using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface ISupplierService
    {
        List<Supplier> GetAll();
        void Add(Supplier archive);
        void Update(Supplier archive);
        void Delete(Supplier archive);
        List<Supplier> SearchAll(string key);
    }
}

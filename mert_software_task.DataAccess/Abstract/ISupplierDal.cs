using mert_software_task.Entities.ComplexTypes;
using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace mert_software_task.DataAccess.Abstract
{
    public interface  ISupplierDal : IEntityRepository<Supplier>
    {
        List<GetSuppliers> GetSuppliers();
    }
}

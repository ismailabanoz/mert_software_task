using mert_software_task.DataAccess.Abstract;
using mert_software_task.Entities.ComplexTypes;
using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace mert_software_task.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, mert_software_taskContext>, ICustomerDal
    {
        public List<GetCustomers> GetCustomers()
        {
            using (mert_software_taskContext context = new mert_software_taskContext())
            {
                return context.Database.SqlQuery<GetCustomers>("GetCustomers").ToList();
            }
        }
    }
}

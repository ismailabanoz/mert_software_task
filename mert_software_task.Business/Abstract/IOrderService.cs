using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        void Add(Order archive);
        void Update(Order archive);
        void Delete(Order archive);
        List<Order> SearchAll(string key);
    }
}

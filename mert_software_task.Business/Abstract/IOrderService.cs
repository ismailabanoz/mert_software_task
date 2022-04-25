using mert_software_task.Entities.ComplexTypes;
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
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
        List<Order> SearchAll(string key);
        List<GetOrders> GetOrders();
    }
}

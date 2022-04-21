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
    public class OrderManager : IOrderService
    {
        IOrderDal _OrderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _OrderDal = orderDal;
        }
        public void Add(Order order)
        {
            _OrderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _OrderDal.Delete(order);
        }

        public List<Order> GetAll()
        {
            return _OrderDal.GetAll();
        }

        public void Update(Order order)
        {
            _OrderDal.Update(order);
        }
        public List<Order> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _OrderDal.GetAll().Where(p => p.ShipName.ToLower().Contains(keyToLower)).ToList();
        }
    }
}

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
    public class ShipAddressOfOrderManager : IShipAddressOfOrderService
    {
        IShipAddressOfOrderDal _ShipAddressOfOrderDal;
        public ShipAddressOfOrderManager(IShipAddressOfOrderDal shipAddressOfOrderDal)
        {
            _ShipAddressOfOrderDal = shipAddressOfOrderDal;
        }
        public void Add(ShipAddressOfOrder shipAddressOfOrder)
        {
            _ShipAddressOfOrderDal.Add(shipAddressOfOrder);
        }

        public void Delete(ShipAddressOfOrder shipAddressOfOrder)
        {
            _ShipAddressOfOrderDal.Delete(shipAddressOfOrder);
        }

        public List<ShipAddressOfOrder> GetAll()
        {
            return _ShipAddressOfOrderDal.GetAll();
        }

        public void Update(ShipAddressOfOrder shipAddressOfOrder)
        {
            _ShipAddressOfOrderDal.Update(shipAddressOfOrder);
        }
        public List<ShipAddressOfOrder> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _ShipAddressOfOrderDal.GetAll().Where(p => p.Street.ToLower().Contains(keyToLower)).ToList();
        }
    }
}

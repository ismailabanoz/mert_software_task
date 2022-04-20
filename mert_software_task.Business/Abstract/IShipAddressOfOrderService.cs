using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface IShipAddressOfOrderService
    {
        List<ShipAddressOfOrder> GetAll();
        void Add(ShipAddressOfOrder archive);
        void Update(ShipAddressOfOrder archive);
        void Delete(ShipAddressOfOrder archive);
        List<ShipAddressOfOrder> SearchAll(string key);
    }
}

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
    public class ShipperManager : IShipperService
    {
        IShipperDal _ShipperDal;
        public ShipperManager(IShipperDal shipperDal)
        {
            _ShipperDal = shipperDal;
        }
        public void Add(Shipper shipper)
        {
            _ShipperDal.Add(shipper);
        }

        public void Delete(Shipper shipper)
        {
            _ShipperDal.Delete(shipper);
        }

        public List<Shipper> GetAll()
        {
            return _ShipperDal.GetAll();
        }

        public void Update(Shipper shipper)
        {
            _ShipperDal.Update(shipper);
        }
        public List<Shipper> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _ShipperDal.GetAll().Where(p => p.CompanyName.ToLower().Contains(keyToLower)).ToList();
        }
    }
}

using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface IShipperService
    {
        List<Shipper> GetAll();
        void Add(Shipper archive);
        void Update(Shipper archive);
        void Delete(Shipper archive);
        List<Shipper> SearchAll(string key);
    }
}

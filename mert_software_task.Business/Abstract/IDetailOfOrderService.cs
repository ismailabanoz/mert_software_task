using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface IDetailOfOrderService
    {
        List<DetailOfOrder> GetAll();
        void Add(DetailOfOrder archive);
        void Update(DetailOfOrder archive);
        void Delete(DetailOfOrder archive);
        List<DetailOfOrder> SearchAll(string key);
    }
}

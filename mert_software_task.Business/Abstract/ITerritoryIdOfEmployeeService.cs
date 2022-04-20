using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface ITerritoryIdOfEmployeeService
    {
        List<TerritoryIdOfEmployee> GetAll();
        void Add(TerritoryIdOfEmployee archive);
        void Update(TerritoryIdOfEmployee archive);
        void Delete(TerritoryIdOfEmployee archive);
        List<TerritoryIdOfEmployee> SearchAll(string key);
    }
}

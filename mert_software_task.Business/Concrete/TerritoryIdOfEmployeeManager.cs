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
    public class TerritoryIdOfEmployeeManager : ITerritoryIdOfEmployeeService
    {
        ITerritoryIdOfEmployeeDal _TerritoryIdOfEmployeeDal;
        public TerritoryIdOfEmployeeManager(ITerritoryIdOfEmployeeDal TerritoryIdOfEmployeeDal)
        {
            _TerritoryIdOfEmployeeDal = TerritoryIdOfEmployeeDal;
        }
        public void Add(TerritoryIdOfEmployee territoryIdOfEmployee)
        {
            _TerritoryIdOfEmployeeDal.Add(territoryIdOfEmployee);
        }

        public void Delete(TerritoryIdOfEmployee territoryIdOfEmployee)
        {
            _TerritoryIdOfEmployeeDal.Delete(territoryIdOfEmployee);
        }

        public List<TerritoryIdOfEmployee> GetAll()
        {
            return _TerritoryIdOfEmployeeDal.GetAll();
        }

        public void Update(TerritoryIdOfEmployee territoryIdOfEmployee)
        {
            _TerritoryIdOfEmployeeDal.Update(territoryIdOfEmployee);
        }
        public List<TerritoryIdOfEmployee> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _TerritoryIdOfEmployeeDal.GetAll().Where(p => p.EmployeeId.ToString().Contains(keyToLower)).ToList();
        }
    }
}

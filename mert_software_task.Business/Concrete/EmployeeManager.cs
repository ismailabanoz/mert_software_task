using mert_software_task.Business.Abstract;
using mert_software_task.DataAccess.Abstract;
using mert_software_task.Entities.ComplexTypes;
using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Concrete
{
    public class EmployeeManager :IEmployeeService
    {
        IEmployeeDal _EmployeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _EmployeeDal = employeeDal;
        }
        public void Add(Employee employee)
        {
            _EmployeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _EmployeeDal.Delete(employee);
        }

        public List<Employee> GetAll()
        {
            return _EmployeeDal.GetAll();
        }

        public void Update(Employee employee)
        {
            _EmployeeDal.Update(employee);
        }
        public List<Employee> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _EmployeeDal.GetAll().Where(p => p.Title.ToLower().Contains(keyToLower)).ToList();
        }
        public List<GetEmployess> GetEmployess()
        {
            return _EmployeeDal.GetEmployess();
        }
    }
}

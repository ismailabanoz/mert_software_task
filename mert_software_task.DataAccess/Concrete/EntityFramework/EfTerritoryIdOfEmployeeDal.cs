﻿using mert_software_task.DataAccess.Abstract;
using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.DataAccess.Concrete.EntityFramework
{
    public class EfTerritoryIdOfEmployeeDal: EfEntityRepositoryBase<TerritoryIdOfEmployee, mert_software_taskContext>, ITerritoryIdOfEmployee
    {
    }
}

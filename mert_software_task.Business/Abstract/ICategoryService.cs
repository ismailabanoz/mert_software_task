using mert_software_task.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mert_software_task.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category archive); 
        void Update(Category archive);
        void Delete(Category archive);
        List<Category> SearchAll(string key);
    }
}

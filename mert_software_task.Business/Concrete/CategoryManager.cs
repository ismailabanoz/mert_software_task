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
    public class CategoryManager :ICategoryService
    {
        ICategoryDal _CategoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _CategoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _CategoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _CategoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _CategoryDal.GetAll();
        }

        public void Update(Category category)
        {
            _CategoryDal.Update(category);
        }
        public List<Category> SearchAll(string key)
        {
            string keyToLower = key.ToLower();
            return _CategoryDal.GetAll().Where(p => p.Description.ToLower().Contains(keyToLower)).ToList();
        }
    }
}

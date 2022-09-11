using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repos;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            
            _categoryDal.Insert(category);
        }

        public void DelCategory(Category category)
        {
            _categoryDal.Remove(category);
            
        }
        public void UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category getbyID(int ID)
        {
            return _categoryDal.Get(x=>x.CategoryID == ID);
            
        }

        public List<Category> GetCategories()
        {
            return _categoryDal.List();
        }
    }
}

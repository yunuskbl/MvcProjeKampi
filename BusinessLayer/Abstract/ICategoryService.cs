using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        void CategoryAdd(Category category);
        Category getbyID(int ID);

        void DelCategory(Category category);
        void UpdateCategory(Category category);
       
    }
}

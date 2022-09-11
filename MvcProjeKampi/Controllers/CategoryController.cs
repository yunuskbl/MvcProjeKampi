using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var CatValues = cm.GetCategories();
            return View(CatValues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category Cat)
        {
            categoryValidator categoryValidator = new categoryValidator();
            ValidationResult result = categoryValidator.Validate(Cat);
            if(result.IsValid)
            {               
                cm.CategoryAdd(Cat);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
    }   
}
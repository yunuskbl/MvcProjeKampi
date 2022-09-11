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
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        public ActionResult Index()
        {
            var catValues = cm.GetCategories();
            return View(catValues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category P)
        {
            categoryValidator CV = new categoryValidator();
            ValidationResult results = CV.Validate(P);
            if (results.IsValid)
            {
                cm.CategoryAdd(P);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DelCategory(int id)
        {
            var catValues = cm.getbyID(id);
            cm.DelCategory(catValues);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var catValues = cm.getbyID(id);
            return View(catValues);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category T)
        {
            cm.UpdateCategory(T);
            return RedirectToAction("Index");
        }
    }
}
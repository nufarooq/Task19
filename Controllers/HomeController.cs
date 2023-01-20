using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task19_MVC.Models;

namespace Task19_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Value = "1", Text = "Visa" });
            list.Add(new SelectListItem() { Value = "2", Text = "Master" });
            
            User model = new User();
            model.CardTypeList = list;
            return View(model);
        }

        public ActionResult Validate()
        {
            if(ModelState.IsValid)
            {
                ViewBag.Message = "Valid";
                List<SelectListItem> list = new List<SelectListItem>();
                list.Add(new SelectListItem() { Value = "1", Text = "Visa" });
                list.Add(new SelectListItem() { Value = "2", Text = "Master" });
                
                User model = new User();
                model.CardTypeList = list;
                return View("Index", model);
            }
            return View("Index");
        }

    }
}
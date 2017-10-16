using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZumraModel;
using ZumraService;

namespace ZumraPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly CategoryService cs;
        public HomeController()
        {
            cs = new CategoryService();
        }
        public ActionResult Index()
        {
            ViewBag._CatList = cs.CategoryList(7);
            return View();
        }
    }
}
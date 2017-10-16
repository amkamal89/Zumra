using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZumraModel;
using ZumraService;

namespace ZumraPortal.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService cs;
        public CategoryController()
        {
            cs = new CategoryService();
        }
        public ActionResult Index(int ID)
        {
            var Model = cs.ProductsByCategoyID(ID);
            return View(Model);
        }
    }
}
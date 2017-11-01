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
        public ActionResult Index(int ID, string Title)
        {
            var Model = cs.ProductsByCategoyID(ID);
            if (Title == Helper.NormalizeTitle(Model.TitleEN))
                return View(Model);
            else
                return RedirectToAction("Index", new { ID = Model.ID, Title = Helper.NormalizeTitle(Model.TitleEN) });
        }
    }
}
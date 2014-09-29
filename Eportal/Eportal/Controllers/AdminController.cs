using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkartBusiness.Controller;
using EkartDataModel.DataModel;
namespace Eportal.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult LeftMenu()
        {
            List<Menu> menu = Admin.GetMenu().ToList();
            return PartialView("LeftMenu", menu);
        }

    }
}

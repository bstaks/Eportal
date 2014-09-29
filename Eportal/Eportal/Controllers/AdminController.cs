using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkartBusiness.Controller;
using EkartDataModel.DataModel;
using EkartDataModel.ViewModel;
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
            try
            {
                IEnumerable<MenuInfo> menu = Admin.GetMenu();
                return PartialView("LeftMenu", menu);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

    }
}

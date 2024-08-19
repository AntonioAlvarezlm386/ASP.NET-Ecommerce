using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPanel.Controllers
{
    public class ManagementController : Controller
    {
        public ActionResult Category()
        {
            return View();
        }

        public ActionResult Brand()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }
    }
}
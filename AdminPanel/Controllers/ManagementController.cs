using BussinesLayer.Interfaces;
using BussinesLayer.Services;
using System.Collections.Generic;
using System.Web.Mvc;
using EntityLayer;
using System.Linq;

namespace AdminPanel.Controllers
{
    public class ManagementController : Controller
    {
        private readonly IProductService _productService; 

        public ManagementController(IProductService productService)
        {
            _productService = productService;
        }

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
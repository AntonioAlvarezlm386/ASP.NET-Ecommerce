using BussinesLayer.Interfaces;
using EntityLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            List<PRODUCT> products = _productService.GetAllProducts().ToList();
            return View(products);
        }

        public ActionResult Users()
        {
            return View();
        }


    }
}
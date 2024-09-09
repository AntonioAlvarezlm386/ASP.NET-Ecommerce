using BussinesLayer.Interfaces;
using EntityLayer;
using BussinesLayer.Common;
using System.Web.Mvc;
using System.Collections.Generic;

namespace AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

       public HomeController(IUserService userservice)
        {
            _userService = userservice;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            Result<List<USER>> result = _userService.GetAllUsers();
            if (!result.isSuccess)
            {
                ViewBag.ErrorMessage = result.ErrorMessage;
                ViewBag.ErrorDetails = result.ErrorDetails;
                ViewBag.InnerException = result.InnerException;
                return View("Error");
            }

            return View(result.Data);
        }

        public ActionResult EditUser(int id)
        {
            Result<USER> result = _userService.GetUserById(id);

            if (!result.isSuccess)
            {
                ViewBag.ErrorMessage = result.ErrorMessage;
                ViewBag.ErrorDetails = result.ErrorDetails;
                ViewBag.Innerexception = result.InnerException;

                return View("Error");
            }
            return PartialView(result.Data);
        }
    }
}
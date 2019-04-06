using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using WebAppWithRazor.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppWithRazor.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Authenticate(UserCredentialsModel model)
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Register(UserCredentialsModel model)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
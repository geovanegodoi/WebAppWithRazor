using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppWithRazor.Context;
using WebAppWithRazor.Models;

namespace WebAppWithRazor.Controllers
{
    public class UserController : Controller
    {
        protected DatabaseContext DbContext => DatabaseContext.Create();

        public UserController()
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            var vmUser = new UserViewModel()
            {
                Collection = DbContext.Users.OrderBy(u => u.Id).ToList()
            };
            return View(vmUser);
        }

        [HttpGet]
        public IActionResult Result()
        {
            return PartialView("_ResultTable", DbContext.Users.OrderBy(u => u.Id).ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new UserModel();

            return View("Model", model);
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            var model = DbContext.Users.FirstOrDefault(u => u.Id == id);

            return View("Model", model);
        }

        [HttpPost]
        public IActionResult Save(UserModel model)
        {
            if (model.Id <= 0)
            {
                model.Id = DbContext.Users.Count() + 1;
                DbContext.Users.Add(model);
            }
            else
            {
                var remove = DbContext.Users.FirstOrDefault(u => u.Id == model.Id);
                if (remove != null)
                {
                    DbContext.Users.Remove(remove);
                    DbContext.Users.Add(model);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public void Delete(long id)
        {
            if(id > 0)
            {
                var remove = DbContext.Users.FirstOrDefault(u => u.Id == id);
                if (remove != null)
                {
                    DbContext.Users.Remove(remove);
                }
            }
        }
    }
}
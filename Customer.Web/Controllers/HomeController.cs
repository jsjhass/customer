using Customer.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Customer.Data.Models;
using Customer.Data.Repository;
using Microsoft.AspNetCore.Http;

namespace Customer.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserRepository userrepository;
        public HomeController(IUserRepository userrepository)
        {
            this.userrepository = userrepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserDetail ud)
        {
            bool r=userrepository.LoginUser(ud);
            if(r==true)
            {
                HttpContext.Session.SetString("user", ud.UserName);
                return RedirectToAction("CustomerMain", "Customer");
            }
            else
            {
                ModelState.AddModelError("", "Invalid Username / Password");
                return View();
            }
           
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

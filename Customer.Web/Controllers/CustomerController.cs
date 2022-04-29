using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customer.Data.Models;
using Customer.Data.Repository;
using Microsoft.AspNetCore.Http;

namespace Customer.Web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private ICustomerRepository customerrepository;
        public CustomerController(ICustomerRepository customerrepository)
        {
            this.customerrepository = customerrepository;
        }
        public IActionResult CustomerMain()
        {
            string user = HttpContext.Session.GetString("user");
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var cu = customerrepository.GetData();
                return View(cu);
            }
        }
        [HttpPost]
        public IActionResult Create(CustomerDetail cu)
        {
            customerrepository.InsertData(cu);
            customerrepository.SaveData();
            return RedirectToAction("CustomerMain");
        }
        [HttpPost]
        public IActionResult Edit(CustomerDetail cu)
        {
            customerrepository.UpdateData(cu);
            customerrepository.SaveData();
            return RedirectToAction("CustomerMain");
        }
        public JsonResult Detail(int id)
        {
            var cu = customerrepository.SelectDataById(id);
            return Json(cu);
        }  
        public IActionResult Delete(int id)
        {
            customerrepository.DeleteData(id);
            customerrepository.SaveData();
            return RedirectToAction("CustomerMain");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            return RedirectToAction("Index", "Home");
        }
    }
}

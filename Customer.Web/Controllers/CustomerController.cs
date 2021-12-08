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
        public CustomerRepository ct = new CustomerRepository();
        public IActionResult CustomerMain()
        {
            string user = HttpContext.Session.GetString("user");
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var cu = ct.GetData();
                return View(cu);
            }
        }
        [HttpPost]
        public IActionResult Create(CustomerDetail cu)
        {
            ct.InsertData(cu);
            ct.SaveData();
            return RedirectToAction("CustomerMain");
        }
        [HttpPost]
        public IActionResult Edit(CustomerDetail cu)
        {
            ct.UpdateData(cu);
            ct.SaveData();
            return RedirectToAction("CustomerMain");
        }
        public JsonResult Detail(int id)
        {
            var cu = ct.SelectDataById(id);
            return Json(cu);
        }  
        public IActionResult Delete(int id)
        {
            ct.DeleteData(id);
            ct.SaveData();
            return RedirectToAction("CustomerMain");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            return RedirectToAction("Index", "Home");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication06HomeWork.Models;
using WebApplication06HomeWork.Repository;

namespace WebApplication06HomeWork.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerRepository _customerRepository = new CustomerRepository();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Customer cuustomer)
        {
            _customerRepository.Save(cuustomer);
            return RedirectToAction("Index");
        }
    }
}
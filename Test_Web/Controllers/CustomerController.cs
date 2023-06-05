using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Web.Models;
using Newtonsoft.Json;
using System.IO;
using Test_Repository;
namespace Test_Web.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            return View();
        }

       // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(CustomerModal customer)//(IFormCollection collection)
        {
            if (_customerRepository.Save(new Test_Modal.CustomerDTOModal { firstName = customer.firstName, lastName = customer.lastName }))
            {
                TempData["SucessMessage"] = "Customer submitted sucessfully";
            }
            else 
            {
                TempData["FailMessage"] = "An error occured";
            }
            return View();
        }          
                        
    }
}

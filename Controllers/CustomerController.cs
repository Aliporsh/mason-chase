using Afshar_test.DTOs;
using Afshar_test.Models;
using Afshar_test.Models.entity;
using Afshar_test.Services.InterFaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Afshar_test.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CustomerController : ControllerBase
    {
        private ICustomerService customerService;
        public CustomerController(ICustomerService customer)
        {
            customerService=customer;

        }
     
        [HttpGet]
        public List<Customer> GetAllCustomer()
        {
            return customerService.GetAllCustomers();
        }

        [HttpPost]
        public string CreateCustomer(CustomerForSHowViewModel cm)
        {
            return "ID :"+ customerService.CreateCustomer(cm);
        }
        [HttpGet]
        public Customer GetCustomer(int id)
        {
            return customerService.GetCustomer(id);
        }
        [HttpGet]
        public void UpdateCustomer(Customer customer)
        {
             customerService.UpdateCustomer(customer);
        }
        [HttpGet]
        public void DeteleCustomer(int id)
        {
             customerService.DeleteCustomer(id);
        }

    }
}

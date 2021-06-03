using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Prototype.Data;
using Prototype.Models;

namespace Prototype.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : Controller
    {
        private readonly IPrototypeRepo _repository;

        // Constructor uses Dependency Injection to map
        public CustomersController(IPrototypeRepo repository)
        {
            _repository = repository;
        }
        // GET api/customers/
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            var customerItems = _repository.GetAllCustomers();

            return Ok(customerItems);
        }

        // GET api/customers/{id}
        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var customerItem = _repository.GetCustomerById(id);
            return Ok(customerItem);
        }
    }
}
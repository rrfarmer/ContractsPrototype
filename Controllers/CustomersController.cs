using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Prototype.Models;

namespace Prototype.Controllers
{
    [Route("api/prototype")]
    [ApiController]
    public class CustomersController : Controller
    {
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {

        }
    }
}
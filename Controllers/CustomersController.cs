using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Prototype.Data;
using Prototype.Dtos;
using Prototype.Models;

namespace Prototype.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : Controller
    {
        private readonly ICustomerRepo _repository;
        private readonly IMapper _mapper;

        // Constructor uses Dependency Injection to map
        public CustomersController(ICustomerRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // GET api/customers/
        [HttpGet]
        public ActionResult<IEnumerable<CustomerReadDto>> GetAllCustomers()
        {
            var customerItems = _repository.GetAllCustomers();

            return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customerItems));
        }

        // GET api/customers/{id}
        [HttpGet("{id}", Name = "GetCustomerById")]
        public ActionResult<CustomerReadDto> GetCustomerById(int id)
        {
            var customerItem = _repository.GetCustomerById(id);

            if (customerItem != null)
            {
                return Ok(_mapper.Map<CustomerReadDto>(customerItem));
            }

            return NotFound();
        }

        // POST api/customers/
        [HttpPost]
        public ActionResult<CustomerReadDto> CreateCustomer(CustomerCreateDto customerCreateDto)
        {
            var customerModel = _mapper.Map<Customer>(customerCreateDto); // Probably need to verify incoming Customer data
            _repository.CreateCustomer(customerModel);
            _repository.SaveChanges();

            var customerReadDto = _mapper.Map<CustomerReadDto>(customerModel);

            return CreatedAtRoute(nameof(GetCustomerById), new { Id = customerReadDto.Id }, customerReadDto);
        }
    }
}
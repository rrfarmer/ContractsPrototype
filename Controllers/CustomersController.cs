using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
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
        [Authorize]
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

        // GET api/customers/search/{term}
        [HttpGet("search/{term}", Name = "SearchCustomer")]
        public ActionResult<CustomerReadDto> SearchCustomer(string term)
        {
            var customerItems = _repository.SearchCustomers(term);

            if (customerItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customerItems));
            }

            return NotFound();
        }

        // POST api/customers/
        [HttpPost]
        public ActionResult<CustomerReadDto> CreateCustomer(CustomerCreateDto customerCreateDto)
        {
            var customerModel = _mapper.Map<Customer>(customerCreateDto); // TODO: Probably need to verify incoming Customer data
            _repository.CreateCustomer(customerModel);
            _repository.SaveChanges();

            var customerReadDto = _mapper.Map<CustomerReadDto>(customerModel);

            return CreatedAtRoute(nameof(GetCustomerById), new { Id = customerReadDto.Id }, customerReadDto);
        }

        // PUT api/customers/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCustomer(int id, CustomerUpdateDto customerUpdateDto)
        {
            var customerModelFromRepo = _repository.GetCustomerById(id); // TODO: refactor to own function
            if (customerModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(customerUpdateDto, customerModelFromRepo);
            _repository.UpdateCustomer(customerModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        // Patch api/customers/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCustomerUpdate(int id, JsonPatchDocument<CustomerUpdateDto> patchDoc)
        {
            var customerModelFromRepo = _repository.GetCustomerById(id); // TODO: refactor to own function
            if (customerModelFromRepo == null)
            {
                return NotFound();
            }

            var customerToPatch = _mapper.Map<CustomerUpdateDto>(customerModelFromRepo);
            patchDoc.ApplyTo(customerToPatch, ModelState);

            if (!TryValidateModel(customerToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(customerToPatch, customerModelFromRepo);

            _repository.UpdateCustomer(customerModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        // DELETE api/customer/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            var customerModelFromRepo = _repository.GetCustomerById(id); // TODO: refactor to own function
            if (customerModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteCustomer(customerModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
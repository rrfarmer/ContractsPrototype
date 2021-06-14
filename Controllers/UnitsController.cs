using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Prototype.Data;
using Prototype.Dtos;
using Prototype.Models;

namespace Prototype.Controllers
{
    [Route("api/units")]
    [ApiController]
    public class UnitsController : Controller
    {
        private readonly IUnitRepo _repository;
        private readonly IMapper _mapper;

        // Constructor uses Dependency Injection to map
        public CustomersController(ICustomerRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

    }
}
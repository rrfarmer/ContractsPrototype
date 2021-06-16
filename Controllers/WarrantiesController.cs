using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Prototype.Data;
using Prototype.Dtos;
using Prototype.Models;

namespace Prototype.Controllers
{
    [Route("api/warranties")]
    [ApiController]
    public class WarrantiesController : Controller
    {
        private readonly ICustomerRepo _repository;
        private readonly IMapper _mapper;

        // Constructor uses Dependency Injection to map
        public WarrantiesController(ICustomerRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



    }

}
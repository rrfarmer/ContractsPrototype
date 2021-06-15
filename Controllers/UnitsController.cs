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
        public UnitsController(IUnitRepo repository, IMapper mapper)
        {
            _repository = repository;
            //_mapper = mapper;
        }

        // GET api/units/
        [HttpGet]
        public ActionResult<IEnumerable<Unit>> GetUnits(int id)
        {
            var units = _repository.GetUnitsInContract(id);
            return Ok(units);
        }

        // GET api/units/{id}
        [HttpGet("{id}", Name = "GetUnit")]
        public ActionResult<Unit> GetUnitById(int id)
        {
            var unitItem = _repository.GetUnitById(id);

            if (unitItem != null)
            {
                return Ok(unitItem);
            }

            return NotFound();
        }

    }
}
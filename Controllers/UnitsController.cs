using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Prototype.Data;
using Prototype.Dtos;
using Prototype.Models;
using System.Linq;

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
            _mapper = mapper;
        }

        // GET api/units/
        [HttpGet]
        public ActionResult<IEnumerable<Unit>> GetUnitsInContract(int contractId)
        {
            var units = _repository.GetUnitsInContract(contractId);

            if (!units.Any())
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<UnitReadDto>>(units));
        }

        // GET api/units/{id}
        [HttpGet("{id}", Name = "GetUnitById")]
        public ActionResult<Unit> GetUnitById(int id)
        {
            var unitItem = _repository.GetUnitById(id);

            if (unitItem != null)
            {
                return Ok(_mapper.Map<UnitReadDto>(unitItem));
            }

            return NotFound();
        }

        // POST api/units/
        [HttpPost]
        public ActionResult<UnitReadDto> CreateUnit(UnitCreateDto unitCreateDto)
        {
            if (unitCreateDto.MediaFilter == null)
            {
                unitCreateDto.MediaFilterId = 1; // Hardcode set to default "Unknown"
            }

            var unitModel = _mapper.Map<Unit>(unitCreateDto);
            _repository.CreateUnit(unitModel);
            _repository.SaveChanges();

            var unitReadDto = _mapper.Map<UnitReadDto>(unitModel);

            return CreatedAtRoute(nameof(GetUnitById), new { Id = unitReadDto.Id }, unitReadDto);
        }

    }
}
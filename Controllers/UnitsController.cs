using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Prototype.Data;
using Prototype.Dtos;
using Prototype.Models;
using System.Linq;
using Microsoft.AspNetCore.JsonPatch;

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

        // PUT api/units/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateUnit(int id, UnitUpdateDto unitUpdateDto)
        {
            var unitModelFromRepo = _repository.GetUnitById(id);
            if (unitModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(unitUpdateDto, unitModelFromRepo);
            _repository.UpdateUnit(unitModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        // Patch api/units/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialUnitUpdate(int id, JsonPatchDocument<UnitUpdateDto> patchDoc)
        {
            var unitModelFromRepo = _repository.GetUnitById(id); //TODO: refactor to own function
            if (unitModelFromRepo == null)
            {
                return NotFound();
            }

            var unitToPatch = _mapper.Map<UnitUpdateDto>(unitModelFromRepo);
            patchDoc.ApplyTo(unitToPatch, ModelState);

            if (!TryValidateModel(unitToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(unitToPatch, unitModelFromRepo);

            _repository.UpdateUnit(unitModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

    }
}
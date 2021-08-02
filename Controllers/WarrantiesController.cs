using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
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
        private readonly IWarrantyRepo _repository;
        private readonly IMapper _mapper;

        // Constructor uses Dependency Injection to map
        public WarrantiesController(IWarrantyRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/warranties/
        [HttpGet]
        public ActionResult<IEnumerable<WarrantyReadDto>> GetAllWarranties()
        {
            var warrantyItems = _repository.GetAllWarranties();

            return Ok(_mapper.Map<IEnumerable<WarrantyReadDto>>(warrantyItems));
        }

        // GET api/warranties/{id}
        [HttpGet("{id}", Name = "GetWarrantyById")]
        public ActionResult<WarrantyReadDto> GetWarrantyById(int id)
        {
            var warrantyItem = _repository.GetWarrantyById(id);

            if (warrantyItem != null)
            {
                return Ok(_mapper.Map<WarrantyReadDto>(warrantyItem));
            }

            return NotFound();
        }

        // POST api/warranties/
        [HttpPost]
        public ActionResult<WarrantyReadDto> CreateWarranty(WarrantyCreateDto warrantyCreateDto)
        {
            var warrantyModel = _mapper.Map<OtherWarranty>(warrantyCreateDto); // Probably need to verify incoming data
            _repository.CreateWarranty(warrantyModel);
            _repository.SaveChanges();

            var warrantyReadDto = _mapper.Map<WarrantyReadDto>(warrantyModel);

            return CreatedAtRoute(nameof(GetWarrantyById), new { Id = warrantyReadDto.Id }, warrantyReadDto);
        }

        // PUT api/warranties/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateWarranty(int id, WarrantyUpdateDto warrantyUpdateDto)
        {
            var warrantyModelFromRepo = _repository.GetWarrantyById(id);
            if (warrantyModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(warrantyUpdateDto, warrantyModelFromRepo);
            _repository.UpdateWarranty(warrantyModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        // Patch api/warranties/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialWarrantyUpdate(int id, JsonPatchDocument<WarrantyUpdateDto> patchDoc)
        {
            var warrantyModelFromRepo = _repository.GetWarrantyById(id); //TODO: refactor to own function
            if (warrantyModelFromRepo == null)
            {
                return NotFound();
            }

            var warrantyToPatch = _mapper.Map<WarrantyUpdateDto>(warrantyModelFromRepo);
            patchDoc.ApplyTo(warrantyToPatch, ModelState);

            if (!TryValidateModel(warrantyToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(warrantyToPatch, warrantyModelFromRepo);

            _repository.UpdateWarranty(warrantyModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        // DELETE api/warranties/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteWarranty(int id)
        {
            var warrantyModelFromRepo = _repository.GetWarrantyById(id); //TODO: refactor to own function
            if (warrantyModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteWarranty(warrantyModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

    }

}
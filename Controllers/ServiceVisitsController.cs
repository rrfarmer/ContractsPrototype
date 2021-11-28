using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Prototype.Data;
using Prototype.Dtos;
using Prototype.Models;

namespace Prototype.Controllers
{
    [Route("api/ServiceVisits")]
    [ApiController]
    public class ServiceVisitsController : Controller
    {
        private readonly IServiceVisitRepo _repository;
        private readonly IMapper _mapper;

        // Constructor uses Dependency Injection to map
        public ServiceVisitsController(IServiceVisitRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/ServiceVisits
        [HttpGet]
        public ActionResult<IEnumerable<ServiceVisitReadDto>> GetAllServiceVisits()
        {
            var ServiceVisitItems = _repository.GetAllServiceVisits();

            return Ok(_mapper.Map<IEnumerable<ServiceVisitReadDto>>(ServiceVisitItems));
        }

        // GET api/ServiceVisits/{id}
        [HttpGet("{id}", Name = "GetServiceVisitById")]
        public ActionResult<ServiceVisitReadDto> GetServiceVisitById(int id)
        {
            var ServiceVisitItem = _repository.GetServiceVisitById(id);

            if (ServiceVisitItem != null)
            {
                return Ok(_mapper.Map<ServiceVisitReadDto>(ServiceVisitItem));
            }

            return NotFound();
        }

        // POST api/ServiceVisits/
        [HttpPost]
        public ActionResult<ServiceVisitReadDto> CreateServiceVisit(ServiceVisitCreateDto ServiceVisitCreateDto)
        {
            // TODO: Create a function that checks if CustomerID exists

            var ServiceVisitModel = _mapper.Map<ServiceVisit>(ServiceVisitCreateDto);
            _repository.CreateServiceVisit(ServiceVisitModel);
            _repository.SaveChanges();

            var ServiceVisitReadDto = _mapper.Map<ServiceVisitReadDto>(ServiceVisitModel);

            return CreatedAtRoute(nameof(GetServiceVisitById), new { Id = ServiceVisitModel.Id }, ServiceVisitReadDto);
        }

        // PUT api/ServiceVisits/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateServiceVisit(int id, ServiceVisitUpdateDto ServiceVisitUpdateDto)
        {
            var ServiceVisitModelFromRepo = _repository.GetServiceVisitById(id);
            if (ServiceVisitModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(ServiceVisitUpdateDto, ServiceVisitModelFromRepo);
            _repository.UpdateServiceVisit(ServiceVisitModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        // Patch api/ServiceVisits/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialServiceVisitUpdate(int id, JsonPatchDocument<ServiceVisitUpdateDto> patchDoc)
        {
            var ServiceVisitModelFromRepo = _repository.GetServiceVisitById(id); //TODO: refactor to own function
            if (ServiceVisitModelFromRepo == null)
            {
                return NotFound();
            }

            var ServiceVisitToPatch = _mapper.Map<ServiceVisitUpdateDto>(ServiceVisitModelFromRepo);
            patchDoc.ApplyTo(ServiceVisitToPatch, ModelState);

            if (!TryValidateModel(ServiceVisitToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(ServiceVisitToPatch, ServiceVisitModelFromRepo);

            _repository.UpdateServiceVisit(ServiceVisitModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        // DELETE api/ServiceVisits/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteServiceVisit(int id)
        {
            var ServiceVisitModelFromRepo = _repository.GetServiceVisitById(id); //TODO: refactor to own function
            if (ServiceVisitModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteServiceVisit(ServiceVisitModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
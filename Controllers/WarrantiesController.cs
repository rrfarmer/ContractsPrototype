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

    }

}
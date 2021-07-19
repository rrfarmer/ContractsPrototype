using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Prototype.Data;
using Prototype.Dtos;
using Prototype.Models;

namespace Prototype.Controllers
{
    [Route("api/filters")]
    [ApiController]
    public class MediaFiltersController : Controller
    {
        private readonly IMediaFilterRepo _repository;
        private readonly IMapper _mapper;

        public MediaFiltersController(IMediaFilterRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/filters/
        [HttpGet]
        public ActionResult<IEnumerable<MediaFilterReadDto>> GetAllMediaFilters()
        {
            var mediaFilterItems = _repository.GetAllMediaFilters();

            return Ok(_mapper.Map<IEnumerable<MediaFilterReadDto>>(mediaFilterItems));
        }

        // GET api/filters/{id}
        [HttpGet("{id}", Name = "GetMediaFilterById")]
        public ActionResult<MediaFilterReadDto> GetMediaFilterById(int id)
        {
            var mediaFilterItem = _repository.GetMediaFilterById(id);

            if (mediaFilterItem != null)
            {
                return Ok(_mapper.Map<MediaFilterReadDto>(mediaFilterItem));
            }

            return NotFound();
        }

        // POST api/filters/
        [HttpPost]
        public ActionResult<MediaFilterReadDto> CreateMediaFilter(MediaFilterCreateDto mediaFilterCreateDto)
        {
            var filterModel = _mapper.Map<MediaFilter>(mediaFilterCreateDto); // Probably need to verify incoming MediaFilter data
            _repository.CreateMediaFilter(filterModel);
            _repository.SaveChanges();

            var filterReadDto = _mapper.Map<MediaFilterReadDto>(filterModel);

            return CreatedAtRoute(nameof(GetMediaFilterById), new { Id = filterReadDto.Id }, filterReadDto);
        }
    }
}
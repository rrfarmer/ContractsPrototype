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
        private readonly ICustomerRepo _repository;
        private readonly IMapper _mapper;

        public MediaFiltersController(ICustomerRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // // GET api/filters/
        // [HttpGet]
        // public ActionResult<IEnumerable<MediaFilter>> GetAllMediaFilters()
        // {

        // }
    }
}
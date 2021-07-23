using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Prototype.Data;
using Prototype.Dtos;
using Prototype.Models;

namespace Prototype.Controllers
{
    [Route("api/contracts")]
    [ApiController]
    public class ContractsController : Controller
    {
        private readonly IContractRepo _repository;
        private readonly IMapper _mapper;

        // Constructor uses Dependency Injection to map
        public ContractsController(IContractRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/contracts
        [HttpGet]
        public ActionResult<IEnumerable<ContractReadDto>> GetAllContracts()
        {
            var contractItems = _repository.GetAllContracts();

            return Ok(_mapper.Map<IEnumerable<ContractReadDto>>(contractItems));
        }

        // GET api/contracts/{id}
        [HttpGet("{id}", Name = "GetContractById")]
        public ActionResult<CustomerReadDto> GetContractById(int id)
        {
            var contractItem = _repository.GetContractById(id);

            if (contractItem != null)
            {
                return Ok(_mapper.Map<ContractReadDto>(contractItem));
            }

            return NotFound();
        }

        // POST api/contracts/
        [HttpPost]
        public ActionResult<ContractReadDto> CreateContract(ContractCreateDto contractCreateDto)
        {
            // TODO: Create a function that checks if CustomerID exists

            var contractModel = _mapper.Map<Contract>(contractCreateDto);
            _repository.CreateContract(contractModel);
            _repository.SaveChanges();

            var contractReadDto = _mapper.Map<ContractReadDto>(contractModel);

            return CreatedAtRoute(nameof(GetContractById), new { Id = contractModel.Id }, contractReadDto);
        }

        // PUT api/contracts/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateContract(int id, ContractUpdateDto contractUpdateDto)
        {
            var contractModelFromRepo = _repository.GetContractById(id);
            if (contractModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(contractUpdateDto, contractModelFromRepo);
            _repository.UpdateContract(contractModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        // Patch api/commands/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialCustomerUpdate(int id, JsonPatchDocument<ContractUpdateDto> patchDoc)
        {
            var contractModelFromRepo = _repository.GetContractById(id); //TODO: refactor to own function
            if (contractModelFromRepo == null)
            {
                return NotFound();
            }

            var contractToPatch = _mapper.Map<ContractUpdateDto>(contractModelFromRepo);
            patchDoc.ApplyTo(contractToPatch, ModelState);

            if (!TryValidateModel(contractToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(contractToPatch, contractModelFromRepo);

            _repository.UpdateContract(contractModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }
    }
}
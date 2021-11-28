using System;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Models
{
    public class ServiceVisitCreateDto
    {

        [Required]
        public int ContractId { get; set; }

        public DateTime Visit { get; set; }

        public string Notes {get; set;}
    }
}
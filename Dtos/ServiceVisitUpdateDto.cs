using System;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Models
{
    public class ServiceVisitUpdateDto
    {

        [Required]
        public int ContractId { get; set; }

        public DateTime Visit { get; set; }

        public string Notes {get; set;}
    }
}
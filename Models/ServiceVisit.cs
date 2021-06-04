using System;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Models
{
    public class ServiceVisit
    {
        public int Id { get; set; }

        // [Required]
        // public int ContractId { get; set; }

        public DateTime Visit { get; set; }
    }
}
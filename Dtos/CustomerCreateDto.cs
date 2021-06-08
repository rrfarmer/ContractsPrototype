// For mapping a new customer
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Prototype.Models;

namespace Prototype.Dtos
{
    public class CustomerCreateDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }
        public string Notes { get; set; }
        public IList<Contract> Contracts { get; set; }
    }
}
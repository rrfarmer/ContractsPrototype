// DTO For updating a new customer, TODO: Make this not duplicate code
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Prototype.Models;

namespace Prototype.Dtos
{
    public class CustomerUpdateDto
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
        //public IList<Contract> Contracts { get; set; }
    }
}
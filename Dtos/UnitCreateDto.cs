using System.ComponentModel.DataAnnotations;
using Prototype.Models;

namespace Prototype.Dtos
{
    public class UnitCreateDto
    {
        [Required]
        public int ContractId { get; set; }

        [Required]
        public int MediaFilterId { get; set; }
        //public MediaFilter MediaFilter { get; set; } // Drop down list
    }
}
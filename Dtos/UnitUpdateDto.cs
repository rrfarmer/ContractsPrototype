using System.ComponentModel.DataAnnotations;
using Prototype.Models;

namespace Prototype.Dtos
{
    public class UnitUpdateDto
    {
        [Required]
        public int ContractId { get; set; }
        public int MediaFilterId { get; set; }
        public MediaFilter MediaFilter { get; set; } // Drop down list
    }
}
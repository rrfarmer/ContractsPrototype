using System.ComponentModel.DataAnnotations;

namespace Prototype
{
    public class WarrantyUpdateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
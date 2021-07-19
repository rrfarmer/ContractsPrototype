using System.ComponentModel.DataAnnotations;

namespace Prototype
{
    public class WarrantyCreateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
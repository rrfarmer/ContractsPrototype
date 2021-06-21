// A list of media filters
using System.ComponentModel.DataAnnotations;

namespace Prototype.Models
{
    public class MediaFilterCreateDto
    {
        [Required]
        public string Size { get; set; }
    }
}
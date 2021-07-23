// A list of media filters
using System.ComponentModel.DataAnnotations;

namespace Prototype.Models
{
    public class MediaFilterUpdateDto
    {
        [Required]
        public string Size { get; set; }
    }
}
using Prototype.Models;

namespace Prototype.Dtos
{
    public class UnitReadDto
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public int MediaFilterId { get; set; }
        public MediaFilter MediaFilter { get; set; } // Drop down list
    }
}
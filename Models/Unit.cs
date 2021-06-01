// Unit is referring to external AC units/compressors
namespace Prototype.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public int MediaFilterId { get; set; }
        public MediaFilter MediaFilter { get; set; }
    }
}
// Unit is referring to external AC units/compressors
// Model to use vor V2 or later iteration
namespace Prototype.Models
{
    public class Unit
    {
        public int Id { get; set; }
        //public int ContractId { get; set; }
        public int MediaFilterId { get; set; }
        public MediaFilter MediaFilter { get; set; } // Drop down list
    }
}
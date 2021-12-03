// Describes billing period types, Ex: monthly, annual, quarterly
namespace Prototype.Models
{
    public class BillingPeriod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public double additionalUnitPrice { get; set; }
    }
}
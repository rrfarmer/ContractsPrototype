// Defines a customer, who owns a contract, can have multiple contracts
using System.Collections.Generic;

namespace Prototype.Models
{
    public class Customer
    {
        public int Id { get; set; }
        //public int ContractId { get; set; }
        public Contract Contract { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public IList<Contract> Contracts { get; set; }
    }
}
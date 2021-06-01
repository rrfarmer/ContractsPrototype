// Defines a customer, who owns a contract, can have multiple contracts
using System.Collections.Generic;

namespace Prototype.Models
{
    public class Customer
    {
        public int Id { get; set; }

        // This will be removed when ability for multiple contracts added
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }

        //Update this later to add multiple contracts per customer
        //public List<Contract> Contracts { get; set; }
    }
}
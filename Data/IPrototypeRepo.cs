using System.Collections.Generic;
using Prototype.Models;

namespace Prototype.Data
{
    public interface IPrototypeRepo
    {
        bool SaveChanges();
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void CreateCustomer(Customer customer);
        void CreateContract(Contract contract);
    }
}
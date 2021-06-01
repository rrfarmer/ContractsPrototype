using System.Collections.Generic;
using Prototype.Models;

namespace Prototype.Data
{
    public interface IPrototypeRepo
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
    }
}
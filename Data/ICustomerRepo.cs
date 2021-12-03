using System.Collections.Generic;
using Prototype.Models;

namespace Prototype.Data
{
    public interface ICustomerRepo
    {
        bool SaveChanges();
        IEnumerable<Customer> GetAllCustomers();
        IEnumerable<Customer> SearchCustomers(string term);
        Customer GetCustomerById(int id);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}
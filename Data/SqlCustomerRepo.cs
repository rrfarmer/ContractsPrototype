using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Prototype.Models;

namespace Prototype.Data
{
    public class SqlCustomerRepo : IPrototypeRepo
    {
        private readonly PrototypeContext _context;

        public SqlCustomerRepo(PrototypeContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            var customer = _context.Customers.FirstOrDefault(p => p.Id == id);
            var contracts = _context.Contracts.Where(p => p.CustomerId == id)
                                              .Include(c => c.BillingPeriod)
                                              .Include(c => c.OtherWarranty)
                                              .Include(c => c.Units)
                                              .Include(c => c.ServiceVisits)
                                              .ToList();
            var units = _context.Units.Include(u => u.MediaFilter).ToList();

            return customer;
        }
    }
}
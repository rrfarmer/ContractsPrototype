using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Prototype.Models;

namespace Prototype.Data
{
    public class SqlContractRepo : IContractRepo
    {
        private readonly PrototypeContext _context;

        public SqlContractRepo(PrototypeContext context)
        {
            _context = context;
        }

        public void CreateContract(Contract contract)
        {
            if (contract == null)
            {
                throw new ArgumentNullException(nameof(contract));
            }

            _context.Contracts.Add(contract);
        }

        public IEnumerable<Contract> GetAllContracts()
        {
            return _context.Contracts.ToList();
        }

        public Contract GetContractById(int id)
        {
            var contract = _context.Contracts.Where(p => p.Id == id)
                                              .Include(c => c.BillingPeriod)
                                              .Include(c => c.OtherWarranty)
                                              .Include(c => c.Units)
                                              .Include(c => c.ServiceVisits)
                                              .Single();
            var units = _context.Units.Include(u => u.MediaFilter).ToList();

            return contract;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateContract(Contract contract)
        {
            // Nothing
        }
    }
}
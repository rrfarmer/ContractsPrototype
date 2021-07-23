using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Prototype.Models;

namespace Prototype.Data
{
    public class SqlWarrantyRepo : IWarrantyRepo
    {
        private readonly PrototypeContext _context;

        public SqlWarrantyRepo(PrototypeContext context)
        {
            _context = context;
        }

        public void CreateWarranty(OtherWarranty warranty)
        {
            if (warranty == null)
            {
                throw new ArgumentNullException(nameof(warranty));
            }

            _context.OtherWarranties.Add(warranty);
        }

        public IEnumerable<OtherWarranty> GetAllWarranties()
        {
            return _context.OtherWarranties.ToList();
        }

        public OtherWarranty GetWarrantyById(int id)
        {
            var warranty = _context.OtherWarranties.First(w => w.Id == id);

            return warranty;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateWarranty(OtherWarranty warranty)
        {
            // Nothing
        }
    }
}
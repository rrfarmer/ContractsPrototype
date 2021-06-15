using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Prototype.Models;

namespace Prototype.Data
{
    public class SqlUnitRepo : IUnitRepo
    {
        private readonly PrototypeContext _context;

        public SqlUnitRepo(PrototypeContext context)
        {
            _context = context;
        }

        public void CreateUnit(Unit unit)
        {
            if (unit == null)
            {
                throw new ArgumentNullException(nameof(unit));
            }

            _context.Units.Add(unit);
        }

        public IEnumerable<Unit> GetUnitsInContract(int id)
        {
            return _context.Units.Where(u => u.ContractId == id).Include(u => u.MediaFilter).ToList();
        }

        public Unit GetUnitById(int id)
        {
            var unit = _context.Units.First(u => u.Id == id);
            var mediaFilters = _context.Units.Include(u => u.MediaFilter).Single();

            return unit;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
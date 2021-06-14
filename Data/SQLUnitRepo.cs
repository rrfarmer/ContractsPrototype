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

        public void CreateUnit(Unit unit)
        {
            throw new NotImplementedException();
        }

        public Unit GetUnitById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Unit> GetUnits()
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
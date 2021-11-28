using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Prototype.Models;

namespace Prototype.Data
{
    public class SqlServiceVisitRepo : IServiceVisitRepo
    {
        private readonly PrototypeContext _context;

        public SqlServiceVisitRepo(PrototypeContext context)
        {
            _context = context;
        }

        public void CreateServiceVisit(ServiceVisit ServiceVisit)
        {
            if (ServiceVisit == null)
            {
                throw new ArgumentNullException(nameof(ServiceVisit));
            }

            _context.ServiceVisit.Add(ServiceVisit);
        }

        public void DeleteServiceVisit(ServiceVisit ServiceVisit)
        {
            if (ServiceVisit == null)
            {
                throw new ArgumentNullException(nameof(ServiceVisit));
            }

            _context.ServiceVisit.Remove(ServiceVisit);
        }

        public IEnumerable<ServiceVisit> GetAllServiceVisits()
        {
            return _context.ServiceVisit.ToList();
        }

        public ServiceVisit GetServiceVisitById(int id)
        {
            var ServiceVisit = _context.ServiceVisit.First(s => s.Id == id);

            return ServiceVisit;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateServiceVisit(ServiceVisit ServiceVisit)
        {
            // Nothing
        }
    }
}
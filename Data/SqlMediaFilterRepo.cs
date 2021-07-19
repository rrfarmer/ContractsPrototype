using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Prototype.Models;

namespace Prototype.Data
{
    public class SqlMediaFilterRepo : IMediaFilterRepo
    {
        private readonly PrototypeContext _context;

        public SqlMediaFilterRepo(PrototypeContext context)
        {
            _context = context;
        }

        public void CreateMediaFilter(MediaFilter filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            _context.MediaFilters.Add(filter);
        }

        public IEnumerable<MediaFilter> GetAllMediaFilters()
        {
            return _context.MediaFilters.ToList();
        }

        public MediaFilter GetMediaFilterById(int id)
        {
            var filter = _context.MediaFilters.First(p => p.Id == id);
            return filter;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
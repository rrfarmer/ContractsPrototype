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
        public void CreateMediaFilter(MediaFilter filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MediaFilter> GetAllMediaFilters()
        {
            throw new NotImplementedException();
        }

        public Customer GetMediaFilterById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
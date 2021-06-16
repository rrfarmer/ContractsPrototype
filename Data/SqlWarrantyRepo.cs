using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Prototype.Models;

namespace Prototype.Data
{
    public class SqlWarrantyRepo : IWarrantyRepo
    {
        public void CreateWarranty(OtherWarranty warranty)
        {
            throw new NotImplementedException();
        }

        public OtherWarranty GetWarrantyId(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
using System.Collections.Generic;
using Prototype.Models;

namespace Prototype.Data
{
    public interface IWarrantyRepo
    {
        bool SaveChanges();
        OtherWarranty GetWarrantyId(int id);
        void CreateWarranty(OtherWarranty warranty);
    }
}
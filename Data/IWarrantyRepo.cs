using System.Collections.Generic;
using Prototype.Models;

namespace Prototype.Data
{
    public interface IWarrantyRepo
    {
        bool SaveChanges();
        IEnumerable<OtherWarranty> GetAllWarranties(); // For utility and testing purposes
        OtherWarranty GetWarrantyById(int id);
        void CreateWarranty(OtherWarranty warranty);
        void UpdateWarranty(OtherWarranty warranty);
    }
}
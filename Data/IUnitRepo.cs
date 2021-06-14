using System.Collections.Generic;
using Prototype.Models;

namespace Prototype.Data
{
    public interface IUnitRepo
    {
        bool SaveChanges();
        IEnumerable<Unit> GetUnits();
        Unit GetUnitById(int id);
        void CreateUnit(Unit unit);
    }
}
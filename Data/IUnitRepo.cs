using System.Collections.Generic;
using Prototype.Models;

namespace Prototype.Data
{
    public interface IUnitRepo
    {
        bool SaveChanges();
        IEnumerable<Unit> GetUnitsInContract(int id);
        Unit GetUnitById(int id);
        void CreateUnit(Unit unit);
        void UpdateUnit(Unit unit);
        void DeleteUnit(Unit unit);
    }
}
using System.Collections.Generic;
using Prototype.Models;

namespace Prototype.Data
{
    public interface IContractRepo
    {
        bool SaveChanges();
        IEnumerable<Contract> GetAllContracts();
        Contract GetContractById(int id);
        void CreateContract(Contract contract);
        void UpdateContract(Contract contract);
    }
}
using System.Collections.Generic;
using Prototype.Models;

namespace Prototype.Data
{
    public interface IServiceVisitRepo
    {
        bool SaveChanges();
        IEnumerable<ServiceVisit> GetAllServiceVisits();
        ServiceVisit GetServiceVisitById(int id);
        void CreateServiceVisit(ServiceVisit serviceVisit);
        void UpdateServiceVisit(ServiceVisit serviceVisit);
        void DeleteServiceVisit(ServiceVisit serviceVisit);
    }
}
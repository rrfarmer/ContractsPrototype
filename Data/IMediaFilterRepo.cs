using System.Collections.Generic;
using Prototype.Models;

namespace Prototype.Data
{
    public interface IMediaFilterRepo
    {
        bool SaveChanges();
        IEnumerable<MediaFilter> GetAllMediaFilters();
        Customer GetMediaFilterById(int id);
        void CreateMediaFilter(MediaFilter filter);
    }
}
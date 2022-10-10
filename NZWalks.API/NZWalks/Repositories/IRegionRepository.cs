using NZWalks.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NZWalks.Repositories
{
   public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}

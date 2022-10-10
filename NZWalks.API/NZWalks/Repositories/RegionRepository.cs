using Microsoft.EntityFrameworkCore;
using NZWalks.Data;
using NZWalks.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NZWalks.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalkDbContext _nZWalkDbContext;

        public RegionRepository(NZWalkDbContext nZWalkDbContext)
        {
            this._nZWalkDbContext = nZWalkDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await _nZWalkDbContext.Regions.ToListAsync();

        }
    }
}
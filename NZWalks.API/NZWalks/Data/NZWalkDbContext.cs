using Microsoft.EntityFrameworkCore;
using NZWalks.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NZWalks.Data
{
    public class NZWalkDbContext : DbContext
    {
        public NZWalkDbContext(DbContextOptions<NZWalkDbContext>options):base(options)
        {

     
        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walks> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulties { get; set; }
    }
    

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SnoahRpg;
using SnoahRpg.Model;

namespace SnoahRpg.Model
{
    public class SnoahRpgContext : DbContext
    {
        public SnoahRpgContext(DbContextOptions<SnoahRpgContext> options) : base(options)
        {

        }
        public DbSet<Item> Item { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Monster> Monster { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<SnoahRpg.Model.Store> Store { get; set; }
    }
}

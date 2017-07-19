using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverwatchHeroInfo.API.Entities
{
    public class HeroInfoContext : DbContext
    {
        public HeroInfoContext(DbContextOptions<HeroInfoContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<CounterPick> CounterPicks { get; set; }
    }
}

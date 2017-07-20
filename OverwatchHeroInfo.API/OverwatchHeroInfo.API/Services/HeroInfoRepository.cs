using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OverwatchHeroInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace OverwatchHeroInfo.API.Services
{
    public class HeroInfoRepository : IHeroInfoRepository
    {
        HeroInfoContext _context;

        public HeroInfoRepository(HeroInfoContext context)
        {
            _context = context;
        }

        public Hero GetHero(int heroId, bool includeIsStrongAgainst, bool includeIsWeakAgainst)
        {
            if (includeIsStrongAgainst && !includeIsWeakAgainst)
            {
                return _context.Heroes
                    .Include(h => h.CounterPicks
                    .Where(j => j.IsStrongAgainst == true))
                    .Where(h => h.Id == heroId).FirstOrDefault();
            }

            if (!includeIsStrongAgainst && includeIsWeakAgainst)
            {
                return _context.Heroes
                    .Include(h => h.CounterPicks
                    .Where(j => j.IsWeakAgainst == true))
                    .Where(h => h.Id == heroId).FirstOrDefault();
            }

            return _context.Heroes.Include(h => h.CounterPicks).Where(h => h.Id == heroId).FirstOrDefault();
        }
    
        public IEnumerable<Hero> GetHeroes()
        {
            return _context.Heroes.OrderBy(h => h.Name).ToList();
        }
    }
}

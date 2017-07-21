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
        private HeroInfoContext _context;
        public HeroInfoRepository(HeroInfoContext context)
        {
            _context = context;
        }

        public ICollection<CounterPick> GetCounterPicks(int heroId, bool includeIsStrongAgainst, bool includeIsWeakAgainst)
        {
            if (includeIsStrongAgainst && !includeIsWeakAgainst)
            {
                return _context.CounterPicks
                    .Where(h => h.HeroId == heroId && h.CounterPickState == Enums.CounterPickState.IsStrongAgainst)
                    .ToList();
            }

            if (!includeIsStrongAgainst && includeIsWeakAgainst)
            {
                return _context.CounterPicks
                    .Where(h => h.HeroId == heroId && h.CounterPickState == Enums.CounterPickState.IsWeakAgainst)
                    .ToList();
            }

            return _context.CounterPicks
                .Where(h => h.HeroId == heroId)
                .ToList();
        }
    
        public IEnumerable<Hero> GetHeroes()
        {
            return _context.Heroes
                .OrderBy(h => h.Name)
                .Include(h => h.CounterPicks)
                .ToList();
        }
    }
}

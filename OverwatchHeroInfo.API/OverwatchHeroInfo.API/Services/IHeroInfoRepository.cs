using OverwatchHeroInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverwatchHeroInfo.API
{
    public interface IHeroInfoRepository
    {
        IEnumerable<Hero> GetHeroes();
        ICollection<CounterPick> GetCounterPicks(int heroId, bool includeIsStrongAgainst, bool includeIsWeakAgainst);
    }
}

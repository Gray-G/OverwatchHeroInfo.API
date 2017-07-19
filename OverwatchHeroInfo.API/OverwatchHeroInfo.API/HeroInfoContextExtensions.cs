using OverwatchHeroInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverwatchHeroInfo.API
{
    public static class HeroInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this HeroInfoContext context)
        {
            if (context.Heroes.Any())
            {
                return;
            }

            // Initialize seed data
            var heroes = new List<Hero>()
            {
                new Hero()
                {
                    Name =  Enums.Name.Ana,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick() { Name = Enums.Name.Lucio, IsStrongAgainst = true },
                        new CounterPick() { Name = Enums.Name.Mercy, IsStrongAgainst = true },
                        new CounterPick() { Name = Enums.Name.Zenyatta, IsStrongAgainst = true },
                        new CounterPick() { Name = Enums.Name.Genji, IsWeakAgainst = true },
                        new CounterPick() { Name = Enums.Name.Reaper, IsWeakAgainst = true },
                        new CounterPick() { Name = Enums.Name.Tracer, IsWeakAgainst = true }
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Bastion,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Torbjorn, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Reinhardt, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Winston, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Genji, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Tracer, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Pharah, IsWeakAgainst = true }
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Dva,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Pharah, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Reinhardt, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Orisa, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mei, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Symmetra, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Zenyatta, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Doomfist,
                    CounterPicks = new List<CounterPick>()
                    {
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Genji,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Bastion, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mercy, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mei, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Zarya, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Winston, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Hanzo,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Bastion, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Torbjorn, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Dva, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Tracer, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mei, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Junkrat,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Bastion, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mei, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Torbjorn, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.McCree, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Pharah, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Lucio,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Dva, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Reaper, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Winston, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mei, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.McCree, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Pharah, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.McCree,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Reaper, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Tracer, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Winston, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Genji, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Soldier76, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Hanzo, IsWeakAgainst = true }
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Mei,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Genji, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Winston, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Tracer, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Junkrat, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Pharah, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Mercy,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.McCree, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Tracer, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Orisa,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Reinhardt, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Roadhog, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Torbjorn, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Sombra, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Tracer, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Genji, IsWeakAgainst = true }
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Pharah,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Bastion, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Junkrat, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mei, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Roadhog, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Soldier76, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Reaper,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Bastion, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mei, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Winston, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Junkrat, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.McCree, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Pharah, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Reinhardt,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Soldier76, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Torbjorn, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Reaper, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Roadhog, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Symmetra, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Roadhog,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Pharah, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Reinhardt, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Tracer, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Dva, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Genji, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Reaper, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Soldier76,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Torbjorn, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Zarya, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Symmetra, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mei, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Roadhog, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Sombra,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Bastion, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Pharah, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mercy, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Genji, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mei, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Tracer, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Symmetra,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Bastion, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Dva, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Reinhardt, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Junkrat, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Pharah, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Roadhog, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Torbjorn,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Genji, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Lucio, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Tracer, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Junkrat, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Pharah, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Tracer,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Bastion, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mercy, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Orisa, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.McCree, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mei, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Soldier76, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Widowmaker,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Torbjorn, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Orisa, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Pharah, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Dva, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Genji, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Winston, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Winston,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Genji, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Hanzo, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.McCree, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Mei, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Reaper, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Zarya,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Dva, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Genji, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Winston, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Pharah, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Roadhog, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Reaper, IsWeakAgainst = true },
                    }
                },

                new Hero()
                {
                    Name = Enums.Name.Zenyatta,
                    CounterPicks = new List<CounterPick>()
                    {
                        new CounterPick(){ Name = Enums.Name.Dva, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Roadhog, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Winston, IsStrongAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Hanzo, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Tracer, IsWeakAgainst = true },
                        new CounterPick(){ Name = Enums.Name.Widowmaker, IsWeakAgainst = true },
                    }
                },
            };
            context.Heroes.AddRange(heroes);
            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverwatchHeroInfo.API.Models
{
    public class HeroDto
    {
        public int Id { get; set; }
        public Enums.Name Name { get; set; }
        public ICollection<CounterPickDto> CounterPicks { get; set; }
            = new List<CounterPickDto>();
    }
}

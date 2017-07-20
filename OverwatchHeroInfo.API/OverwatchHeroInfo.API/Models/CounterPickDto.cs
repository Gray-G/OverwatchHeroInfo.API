using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverwatchHeroInfo.API.Models
{
    public class CounterPickDto
    {
        public int Id { get; set; }
        public Enums.Name Name { get; set; }
    }
}

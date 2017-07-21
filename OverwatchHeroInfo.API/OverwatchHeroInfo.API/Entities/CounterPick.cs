using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OverwatchHeroInfo.API.Entities
{
    public class CounterPick
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
      
        public Enums.Name Name { get; set; }
        public Enums.CounterPickState CounterPickState { get; set; }

        public Hero Hero { get; set; }
        public int HeroId { get; set; }
    }
}

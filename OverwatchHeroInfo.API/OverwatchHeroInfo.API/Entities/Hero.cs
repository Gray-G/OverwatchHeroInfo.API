using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OverwatchHeroInfo.API.Entities
{
    public class Hero
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Enums.Name Name { get; set; }

        public ICollection<CounterPick> CounterPicks { get; set; }

    }
}

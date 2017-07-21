using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OverwatchHeroInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverwatchHeroInfo.API.Controllers
{
    [Route("api/heroes")]
    public class HeroesController : Controller
    {
        private IHeroInfoRepository _heroInfoRepository;
        public HeroesController(IHeroInfoRepository heroInfoRepository)
        {
            _heroInfoRepository = heroInfoRepository;
        }

        [HttpGet()]
        public IActionResult GetHeroes()
        {
            var heroEntities = _heroInfoRepository.GetHeroes();
            var results = AutoMapper.Mapper.Map<IEnumerable<Models.HeroDto>>(heroEntities);

            return Ok(results);
        }

        [HttpGet("{id}")]
        public IActionResult GetCounterPicks(int id, bool includeIsStrongAgainst = true, bool includeIsWeakAgainst = true)
        {
            var counterPickEntities = _heroInfoRepository.GetCounterPicks(id, includeIsStrongAgainst, includeIsWeakAgainst);
            var results = AutoMapper.Mapper.Map<ICollection<CounterPickDto>>(counterPickEntities);
            return Ok(results);
        }
    }
}

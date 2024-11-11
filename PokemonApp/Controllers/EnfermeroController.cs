using System;
using System.Linq;
using System.Web.Mvc;
using PokemonApp.Models;
using PokemonApp.Repository;

namespace PokemonApp.Controllers
{
    public class EnfermeroController : Controller
    {
        private readonly RepositoryBase _repository;

        public EnfermeroController()
        {
            _repository = new RepositoryBase(new POKEMON_PROYECTEntities());
        }

        public ActionResult Index()
        {
            var pokemons = _repository.GetPokemon().ToList();
            var averageWeight = pokemons.Any() ? pokemons.Average(p => p.Peso) : 0;
            var pokemonsByType = pokemons
                .GroupBy(p => p.Tipo)
                .Select(g => new { Tipo = g.Key, Count = g.Count() })
                .ToList();

            ViewBag.AverageWeight = averageWeight;
            ViewBag.PokemonsByType = pokemonsByType;

            return View(pokemons);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}

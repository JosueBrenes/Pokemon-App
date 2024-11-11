using System.Linq;
using System.Web.Mvc;
using PokemonApp.Models;
using PokemonApp.Repository;

namespace PokemonApp.Controllers
{
    public class EntrenadorController : Controller
    {
        private readonly RepositoryBase _repository;

        public EntrenadorController()
        {
            _repository = new RepositoryBase(new POKEMON_PROYECTEntities());
        }

        public ActionResult Index()
        {

            var pokemons = _repository.GetPokemon().ToList();

            int totalPokemons = pokemons.Count;
            var pokemonsByType = pokemons.GroupBy(p => p.Tipo)
                                         .Select(g => new { Tipo = g.Key, Count = g.Count() })
                                         .ToList();

            ViewBag.TotalPokemons = totalPokemons;
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
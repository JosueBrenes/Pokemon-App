using System.Linq;
using System.Web.Mvc;
using PokemonApp.Models;
using PokemonApp.Repository;

namespace PokemonApp.Controllers
{
    public class TrainerController : Controller
    {
        private readonly RepositoryBase _repository;

        public TrainerController()
        {
            _repository = new RepositoryBase(new POKEMON_PROYECTEntities());
        }

        public ActionResult Index()
        {

            var pokemons = _repository.GetPokemon().ToList();

            int totalPokemons = pokemons.Count;
            var pokemonsByType = pokemons.GroupBy(p => p.Tipo)
                                         .Select(g => new { Tipo = g.Key, Count = g.Count() })
                                         .ToList();//prueba

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
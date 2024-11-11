using System.Linq;
using System.Web.Mvc;
using PokemonApp.Models;
using PokemonApp.Repository;

namespace PokemonApp.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly RepositoryBase _repository;

        public AdministradorController()
        {
            _repository = new RepositoryBase(new POKEMON_PROYECTEntities());
        }

        public ActionResult Index()
        {
            var usersByRole = _repository.GetUsuarios()
                                         .GroupBy(u => u.Role.Nombre)
                                         .Select(g => new { Role = g.Key, Count = g.Count() })
                                         .ToList();

            var pokemonsByType = _repository.GetPokemon()
                                            .GroupBy(p => p.Tipo)
                                            .Select(g => new { Tipo = g.Key, Count = g.Count() })
                                            .ToList();

            ViewBag.UsersByRole = usersByRole;
            ViewBag.PokemonsByType = pokemonsByType;

            return View();
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

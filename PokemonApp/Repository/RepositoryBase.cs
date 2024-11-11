using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using PokemonApp.Models;

namespace PokemonApp.Repository
{
    public class RepositoryBase
    {
        private readonly POKEMON_PROYECTEntities _POKEMON_PROYECTEntities;

        public RepositoryBase(POKEMON_PROYECTEntities POKEMON_PROYECTEntities)
        {
            _POKEMON_PROYECTEntities = POKEMON_PROYECTEntities;
        }

        public IEnumerable<Pokemon> GetPokemon()
        {
            return _POKEMON_PROYECTEntities.Pokemons.ToList();
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            return _POKEMON_PROYECTEntities.Usuarios.ToList();
        }

        public IEnumerable<Role> GetRoles()
        {
            return _POKEMON_PROYECTEntities.Roles.ToList();
        }
    }

    //prueba 2
}

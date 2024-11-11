using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonApp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public string Usuario1 { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public Role Rol { get; set; }

        //prueba
    }
}
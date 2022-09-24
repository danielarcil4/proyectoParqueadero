using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParqueadero
{
    abstract public class Usuario
    {
        public abstract string NombreUsuario { get; set; }
        public abstract string Contrasenia { get; set; }
        public static string tipoUsuario { get; }
    }
}

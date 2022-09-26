using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParqueadero
{
    public class usuarioUsual:Usuario
    {
        string _nombreUsuario="_";
        string _contrasenia="_";
        const string _TIPOUSUARIO = "USUAL";

        public usuarioUsual()
        { }
            public usuarioUsual(string nombreUsuario, string contrasenia)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
        }

        public override string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public override string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
        public static string TIPOUSUARIO => _TIPOUSUARIO;
    }
}

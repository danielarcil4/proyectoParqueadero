using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParqueadero
{
    public class usuarioUsual:Usuario
    {
        string _nombreUsuario="";
        string _contrasenia="";

        public usuarioUsual(string nombreUsuario, string contrasenia)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
        }

        public override string NombreUsuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Contrasenia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

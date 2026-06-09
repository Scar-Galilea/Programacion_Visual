using ConexionBD.modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5.Modelo
{
    internal class SesionUsuario
    {
        public static Usuario? UsuarioActual
        {
            get;
            set;
        }
        public static bool Activa => UsuarioActual == null;

        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }
    }
}

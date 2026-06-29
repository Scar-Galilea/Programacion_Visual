using ConexionBD.modelo;
using Practica5.controlador;
using Practica5.Dao;
using Practica5.Modelo;
using System;

namespace Practica5.Controlador
{
    internal class LoginControlador
    {
        private UsuarioDAO repository = new UsuarioDAO();

        public bool Login(string usuario, string password)
        {
            Usuario user = repository.ObtenerPorUsuario(usuario);
            if (user == null)
            {
                return false;
            }

            bool valido = Contraseña.VerificarPassword(password, user.Contrasenia);
            if (!valido)
            {
                return false;
            }
            SesionUsuario.UsuarioActual = user;

            return true;
        }
    }
}
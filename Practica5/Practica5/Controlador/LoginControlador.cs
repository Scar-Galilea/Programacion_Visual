using ConexionBD.modelo;
using Practica5.controlador;
using Practica5.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5.Controlador
{
    internal class LoginControlador
    {
        public bool Login(string usuario, string password)
        {
            Usuario user = repository.ObtenerPorUsuario(usuario);
            if (user == null){
                return false;
            }

            bool valido = Contraseña.VerificarPassword(password, user.PasswordHash);

            if (valido){
                return false;
            }

            SesionUsuario.UsuarioActual = user;

            return true;
        }
    }
}

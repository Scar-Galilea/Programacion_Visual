using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionBD.configuracion
{

    internal class Conexion{
        private String cadena = "server=localhost;database=sistema;uid=admin;pwd=admin;";
        public MySqlConnection ObtenerConexion(){
            return new MySqlConnection(cadena);
        }
    }
}

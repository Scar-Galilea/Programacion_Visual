using System;
using MySql.Data.MySqlClient;
using ConexionBD.configuracion;
using ConexionBD.modelo;

namespace Practica5.Dao
{
    internal class UsuarioDAO
    {
        private Conexion conexion = new Conexion();
        public Usuario ObtenerPorUsuario(string usuario)
        {
            string sql = "SELECT * FROM Usuario WHERE Correo = @Usuario";
            using (MySqlConnection cn = conexion.ObtenerConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);

                    cn.Open(); 

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Usuario
                            {
                                Id = Convert.ToInt32(dr["id_usuarios"]),
                                Nombre = dr["nombre"].ToString(),
                                Apellido = dr["apellido"].ToString(),
                                Correo = dr["correo"].ToString(),     
                                Contrasenia = dr["contrasenia"].ToString(),
                            };
                        }
                    }
                }
                return null;
            }
        }
    }
}
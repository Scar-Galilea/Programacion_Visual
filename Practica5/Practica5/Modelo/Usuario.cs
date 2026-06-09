using System;
using System.Collections.Generic;
using System.Text;

namespace ConexionBD.modelo{
    internal class Usuario{
        public int Id { get; set; }
        public required string Nombre {  get; set; }
        public required string Apellido { get; set; }
        public required string Correo { get; set; }
        public required string Contrasenia { get; set; }
        public string? Rol { get; internal set; }
    }
}

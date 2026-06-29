using System;
using System.Security.Cryptography;
using System.Text;

namespace Practica5.controlador
{
    internal class Contraseña
    {
        public static string HashPassword(string password)
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 65536, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(32);
                string saltBase64 = Convert.ToBase64String(salt);
                string hashBase64 = Convert.ToBase64String(hash);
                return $"{saltBase64};{hashBase64}";
            }
        }

        public static bool VerificarPassword(string password, string hashAlmacenado)
        {
            if (string.IsNullOrEmpty(hashAlmacenado)) return false;

            try
            {
                string[] partes = hashAlmacenado.Split(';');
                if (partes.Length != 2) return false;

                byte[] salt = Convert.FromBase64String(partes[0]);
                byte[] hashOriginal = Convert.FromBase64String(partes[1]);

                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 65536, HashAlgorithmName.SHA256))
                {
                    byte[] hashNuevo = pbkdf2.GetBytes(32);
                    return CryptographicOperations.FixedTimeEquals(hashOriginal, hashNuevo);
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
using System;
using LADU.Data;
using LADU.Entities;

namespace LADU.Business
{
    public class AuthService
    {
        private readonly UsuarioRepository _usuarioRepo;

        public AuthService()
        {
            _usuarioRepo = new UsuarioRepository();
        }

        public Usuario Login(string legajoDni, string password)
        {
            if (string.IsNullOrWhiteSpace(legajoDni) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Debe ingresar el usuario y la contraseña.");

            Usuario usuario = _usuarioRepo.ObtenerPorLegajoDni(legajoDni);

            if (usuario == null)
                throw new Exception("Usuario no encontrado o inactivo.");

            bool esPasswordValida = SecurityHelper.VerificarPassword(password, usuario.PasswordHash, usuario.PasswordSalt);

            if (!esPasswordValida)
                throw new Exception("Contraseña incorrecta.");

            return usuario;
        }
    }
}
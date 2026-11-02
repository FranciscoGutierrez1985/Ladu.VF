namespace LADU.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string LegajoDni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string NombreRol { get; set; }
        public bool Activo { get; set; }
    }
}

using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace LADU.Business
{
    public static class SecurityHelper
    {
        public static bool VerificarPassword(string passwordIngresada, byte[] hashAlmacenado, byte[] saltAlmacenado)
        {
            using (var hmac = new HMACSHA512(saltAlmacenado))
            {
                var hashCalculado = hmac.ComputeHash(Encoding.UTF8.GetBytes(passwordIngresada));
                return hashCalculado.SequenceEqual(hashAlmacenado);
            }
        }
    }
}
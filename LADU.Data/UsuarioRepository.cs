using System;
using System.Data;
using Microsoft.Data.SqlClient;
using LADU.Entities;

namespace LADU.Data
{
    public class UsuarioRepository
    {
        public Usuario ObtenerPorLegajoDni(string legajoDni)
        {
            Usuario usuario = null;
            using (var conn = ConnectionFactory.ObtenerConexion())
            {
                System.Diagnostics.Debug.WriteLine("=== CONECTADO A LA BD: " + conn.Database + " ===");
                using (var cmd = new SqlCommand("sp_Usuarios_Login", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@LegajoDni", SqlDbType.VarChar, 20).Value = legajoDni.Trim();
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                                LegajoDni = reader["legajo_dni"].ToString(),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                PasswordHash = (byte[])reader["password_hash"],
                                PasswordSalt = (byte[])reader["password_salt"],
                                NombreRol = reader["nombre_rol"].ToString()
                            };
                        }
                    }
                }
            }
            return usuario;
        }
    }
}
using LADU.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LADU.Data
{
    public class MateriaRepository
    {
        // 1. Listar todas las materias (tanto activas como inactivas)
        public List<Materia> ObtenerMaterias()
        {
            List<Materia> lista = new List<Materia>();

            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Materias_Listar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Materia materia = new Materia
                            {
                                IdMateria = Convert.ToInt32(reader["IdMateria"]),
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["Descripcion"] != DBNull.Value ? reader["Descripcion"].ToString() : string.Empty,
                                Activo = Convert.ToBoolean(reader["Activo"])
                            };

                            lista.Add(materia);
                        }
                    }
                }
            }

            return lista;
        }

        // 2. Insertar una nueva materia
        public void InsertarMateria(Materia materia)
        {
            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Materias_Insertar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", materia.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)materia.Descripcion ?? DBNull.Value);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 3. Modificar una materia existente
        public void ModificarMateria(Materia materia)
        {
            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Materias_Modificar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdMateria", materia.IdMateria);
                    cmd.Parameters.AddWithValue("@Nombre", materia.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", (object)materia.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Activo", materia.Activo);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 4. Eliminar físicamente una materia
        public void EliminarMateria(int idMateria)
        {
            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Materias_Eliminar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdMateria", idMateria);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

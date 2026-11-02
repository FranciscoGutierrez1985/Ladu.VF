using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using LADU.Entities;

namespace LADU.Data
{
    public class CursoRepository
    {
        public List<Curso> ObtenerCursos()
        {
            var listaCursos = new List<Curso>();

            // Usamos ConnectionFactory para que tome el Server=.\SQLEXPRESS del App.config
            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Cursos_Listar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var curso = new Curso
                            {
                                IdCurso = Convert.ToInt32(reader["IdCurso"]),
                                Nombre = reader["Nombre"].ToString(),
                                Division = reader["Division"].ToString(),
                                Anio = Convert.ToInt32(reader["Anio"]),
                                Activo = Convert.ToBoolean(reader["Activo"])
                            };
                            listaCursos.Add(curso);
                        }
                    }
                }
            }
            return listaCursos;
        }
    }
}
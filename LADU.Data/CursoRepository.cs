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
        public bool InsertarCurso(Curso curso)
        {
            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Cursos_Insertar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", curso.Nombre);
                    cmd.Parameters.AddWithValue("@Division", curso.Division);
                    cmd.Parameters.AddWithValue("@Anio", curso.Anio);
                    cmd.Parameters.AddWithValue("@Activo", curso.Activo);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
        public bool ActualizarCurso(Curso curso)
        {
            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Cursos_Actualizar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCurso", curso.IdCurso);
                    cmd.Parameters.AddWithValue("@Nombre", curso.Nombre);
                    cmd.Parameters.AddWithValue("@Division", curso.Division);
                    cmd.Parameters.AddWithValue("@Anio", curso.Anio);
                    cmd.Parameters.AddWithValue("@Activo", curso.Activo);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
        public void EliminarCurso(int idCurso)
        {
            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Cursos_Eliminar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCurso", idCurso);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool AsignarMateriaACurso(int idCurso, int idMateria)
        {
            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_AsignarMateriaACurso", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCurso", idCurso);
                    cmd.Parameters.AddWithValue("@IdMateria", idMateria);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public void QuitarMateriaDeCurso(int idCurso, int idMateria)
        {
            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_QuitarMateriaDeCurso", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCurso", idCurso);
                    cmd.Parameters.AddWithValue("@IdMateria", idMateria);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Materia> ObtenerMateriasPorCurso(int idCurso)
        {
            var listaMaterias = new List<Materia>();

            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerMateriasPorCurso", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCurso", idCurso);
                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var materia = new Materia
                            {
                                IdMateria = Convert.ToInt32(reader["IdMateria"]),
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["Descripcion"] != DBNull.Value ? reader["Descripcion"].ToString() : string.Empty
                            };
                            listaMaterias.Add(materia);
                        }
                    }
                }
            }
            return listaMaterias;
        }

        // --- INSCRIPCIÓN DE ALUMNOS A CURSOS ---

        public bool InscribirAlumnoACurso(int idCurso, int idAlumno)
        {
            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InscribirAlumnoACurso", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCurso", idCurso);
                    cmd.Parameters.AddWithValue("@IdAlumno", idAlumno);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public void DesinscribirAlumnoDeCurso(int idCurso, int idAlumno)
        {
            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_DesinscribirAlumnoDeCurso", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCurso", idCurso);
                    cmd.Parameters.AddWithValue("@IdAlumno", idAlumno);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Alumno> ObtenerAlumnosPorCurso(int idCurso)
        {
            var listaAlumnos = new List<Alumno>();

            using (SqlConnection conexion = ConnectionFactory.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerAlumnosPorCurso", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCurso", idCurso);
                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var alumno = new Alumno
                            {
                                IdAlumno = Convert.ToInt32(reader["IdAlumno"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Dni = reader["Dni"].ToString(),
                                Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty,
                                Legajo = reader["Legajo"] != DBNull.Value ? reader["Legajo"].ToString() : string.Empty,
                                Activo = Convert.ToBoolean(reader["Activo"])
                            };
                            listaAlumnos.Add(alumno);
                        }
                    }
                }
            }
            return listaAlumnos;
        }
    }
}
using LADU.Entities;
using Microsoft.Data.SqlClient; // <-- Cambió de System.Data.SqlClient a este
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LADU.Data
{
    public class AlumnoRepository
    {


        public List<Alumno> ObtenerAlumnos()
        {
            List<Alumno> lista = new List<Alumno>();

            
            using (SqlConnection conn = ConnectionFactory.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerAlumnos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Alumno
                        {
                            IdAlumno = Convert.ToInt32(dr["IdAlumno"]),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            Dni = dr["Dni"].ToString(),
                            Email = dr["Email"] != DBNull.Value ? dr["Email"].ToString() : string.Empty,
                            Legajo = dr["Legajo"] != DBNull.Value ? dr["Legajo"].ToString() : string.Empty,
                            Activo = Convert.ToBoolean(dr["Activo"])
                        });
                    }
                }
            }
            return lista;
        }

        public void InsertarAlumno(Alumno alumno)
        {
            using (SqlConnection conn = ConnectionFactory.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarAlumno", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", alumno.Apellido);
                cmd.Parameters.AddWithValue("@Dni", alumno.Dni);
                cmd.Parameters.AddWithValue("@Email", (object)alumno.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Legajo", (object)alumno.Legajo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Activo", alumno.Activo);
                conn.Open(); 
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarAlumno(Alumno alumno)
        {
            using (SqlConnection conn = ConnectionFactory.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarAlumno", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdAlumno", alumno.IdAlumno);
                cmd.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", alumno.Apellido);
                cmd.Parameters.AddWithValue("@Dni", alumno.Dni);
                cmd.Parameters.AddWithValue("@Email", (object)alumno.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Legajo", (object)alumno.Legajo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Activo", alumno.Activo);

                conn.Open(); 
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarAlumno(int idAlumno)
        {
            using (SqlConnection conn = ConnectionFactory.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarAlumno", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdAlumno", idAlumno);

                conn.Open(); 
                cmd.ExecuteNonQuery();
            }
        }
    }
}

using System;
using System.Configuration;
using Microsoft.Data.SqlClient; // <-- Cambió de System.Data.SqlClient a este
using LADU.Entities;

namespace LADU.Data
{
    public class ConnectionFactory
    {
        public static SqlConnection ObtenerConexion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LADU_Connection"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}
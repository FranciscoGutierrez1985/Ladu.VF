using System;
using System.Collections.Generic;
using System.Text;

namespace LADU.Entities
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Legajo { get; set; }
        public bool Activo { get; set; }

        // Propiedad calculada para mostrar Nombre Completo si hace falta en alguna vista
        public string NombreCompleto => $"{Apellido}, {Nombre}";
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LADU.Entities
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public string Division { get; set; }
        public int Anio { get; set; }
        public bool Activo { get; set; }
    }
}

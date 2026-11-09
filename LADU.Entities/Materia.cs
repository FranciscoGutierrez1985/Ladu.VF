using System;
using System.Collections.Generic;
using System.Text;

namespace LADU.Entities
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        // Sobrescribimos el ToString o mantenemos las propiedades para el DataBinding directo
        public override string ToString()
        {
            return Nombre;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LADU.Entities;
using LADU.Data;

namespace LADU.UI
{
    public enum TipoGestion
    {
        Materias,
        Alumnos
    }
    public partial class FrmGestionCurso : Form
    {
        private int _idCurso;
        private string _nombreCurso;
        private TipoGestion _tipo;
        private CursoRepository _cursoRepository;
        private MateriaRepository _materiaRepository; // Necesitamos el repo para listar todas las materias
        private AlumnoRepository _alumnoRepository;
        public FrmGestionCurso(int idCurso, string nombreCurso, TipoGestion tipo)
        {
            InitializeComponent();
            _idCurso = idCurso;
            _nombreCurso = nombreCurso;
            _tipo = tipo;

            _cursoRepository = new CursoRepository();
            _materiaRepository = new MateriaRepository();
            _alumnoRepository = new AlumnoRepository();
        }

        private void FrmGestionCurso_Load(object sender, EventArgs e)
        {
            if (_tipo == TipoGestion.Materias)
            {
                this.Text = "Gestión de Materias del Curso";
                lblTituloCurso.Text = $"Curso: {_nombreCurso} - Asignación de Materias";
            }
            else
            {
                this.Text = "Gestión de Alumnos del Curso";
                lblTituloCurso.Text = $"Curso: {_nombreCurso} - Inscripción de Alumnos";
            }

            CargarDatos();
        }
        private void CargarDatos()
        {
            if (_tipo == TipoGestion.Materias)
            {
                // 1. Obtener materias ya asignadas al curso
                var materiasAsignadas = _cursoRepository.ObtenerMateriasPorCurso(_idCurso);
                lstAsignados.DataSource = materiasAsignadas;
                lstAsignados.DisplayMember = "Nombre";
                lstAsignados.ValueMember = "IdMateria";

                // 2. Obtener todas las materias del sistema para ver cuáles faltan asignar
                var todasLasMaterias = _materiaRepository.ObtenerMaterias(); // Asumiendo que tenés este método

                // Filtramos para dejar en "Disponibles" solo las que NO están asignadas
                var asignadasIds = new HashSet<int>();
                foreach (Materia m in materiasAsignadas) asignadasIds.Add(m.IdMateria);

                var materiasDisponibles = new List<Materia>();
                foreach (var m in todasLasMaterias)
                {
                    if (!asignadasIds.Contains(m.IdMateria))
                    {
                        materiasDisponibles.Add(m);
                    }
                }

                lstDisponibles.DataSource = materiasDisponibles;
                lstDisponibles.DisplayMember = "Nombre";
                lstDisponibles.ValueMember = "IdMateria";
            }
            else
            {
                // 1. Obtener alumnos ya inscriptos
                var alumnosAsignados = _cursoRepository.ObtenerAlumnosPorCurso(_idCurso);
                lstAsignados.DataSource = alumnosAsignados;
                lstAsignados.DisplayMember = "Apellido"; // O una propiedad combinada si preferís
                lstAsignados.ValueMember = "IdAlumno";

                // 2. Obtener todos los alumnos del sistema
                var todosLosAlumnos = _alumnoRepository.ObtenerAlumnos(); // Asumiendo que tenés este método

                var asignadasIds = new HashSet<int>();
                foreach (Alumno a in alumnosAsignados) asignadasIds.Add(a.IdAlumno);

                var alumnosDisponibles = new List<Alumno>();
                foreach (var a in todosLosAlumnos)
                {
                    if (!asignadasIds.Contains(a.IdAlumno))
                    {
                        alumnosDisponibles.Add(a);
                    }
                }

                lstDisponibles.DataSource = alumnosDisponibles;
                lstDisponibles.DisplayMember = "Apellido";
                lstDisponibles.ValueMember = "IdAlumno";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_tipo == TipoGestion.Materias)
            {
                if (lstDisponibles.SelectedItem is Materia materiaSeleccionada)
                {
                    _cursoRepository.AsignarMateriaACurso(_idCurso, materiaSeleccionada.IdMateria);
                    CargarDatos();
                }
            }
            else
            {
                if (lstDisponibles.SelectedItem is Alumno alumnoSeleccionado)
                {
                    _cursoRepository.InscribirAlumnoACurso(_idCurso, alumnoSeleccionado.IdAlumno);
                    CargarDatos();
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (_tipo == TipoGestion.Materias)
            {
                if (lstAsignados.SelectedItem is Materia materiaSeleccionada)
                {
                    _cursoRepository.QuitarMateriaDeCurso(_idCurso, materiaSeleccionada.IdMateria);
                    CargarDatos();
                }
            }
            else
            {
                if (lstAsignados.SelectedItem is Alumno alumnoSeleccionado)
                {
                    _cursoRepository.DesinscribirAlumnoDeCurso(_idCurso, alumnoSeleccionado.IdAlumno);
                    CargarDatos();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

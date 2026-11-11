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
    public partial class FrmMenuDocente : Form
    {
        private Usuario _docenteLogueado;
        private CursoRepository _cursoRepository;
        public FrmMenuDocente(Usuario docente)
        {
            InitializeComponent();
            _docenteLogueado = docente;
            _cursoRepository = new CursoRepository();
        }

        private void FrmMenuDocente_Load(object sender, EventArgs e)
        {
            // Saludamos usando las propiedades Nombre y Apellido de tu entidad Usuario
            lblBienvenida.Text = $"Bienvenido/a, Profesor/a: {_docenteLogueado.Nombre} {_docenteLogueado.Apellido}";

            // Cargamos los cursos asociados al docente en el ComboBox
            CargarCursosEnComboBox();
        }
        private void CargarCursosEnComboBox()
        {
            try
            {
                var cursosDocente = _cursoRepository.ObtenerCursosPorDocente(_docenteLogueado.IdUsuario);

                cmbCursos.DataSource = cursosDocente;
                cmbCursos.DisplayMember = "Nombre";    // Lo que se ve en el desplegable
                cmbCursos.ValueMember = "IdCurso";      // El ID interno que se guarda por detrás
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cursos asignados: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            if (cmbCursos.SelectedItem != null)
            {
                int idCursoSeleccionado = Convert.ToInt32(cmbCursos.SelectedValue);
                string nombreCurso = cmbCursos.Text;

                // Acá en el futuro se abre ventana de asistencia:
                // FrmAsistencia frm = new FrmAsistencia(idCursoSeleccionado, nombreCurso);
                // frm.ShowDialog();

                MessageBox.Show($"Abriendo módulo de Asistencia para el curso: {nombreCurso}", "Acción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un curso de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLibroTemas_Click(object sender, EventArgs e)
        {
            if (cmbCursos.SelectedItem != null)
            {
                int idCursoSeleccionado = Convert.ToInt32(cmbCursos.SelectedValue);
                string nombreCurso = cmbCursos.Text;

                MessageBox.Show($"Abriendo Libro de Temas para el curso: {nombreCurso}", "Acción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un curso de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

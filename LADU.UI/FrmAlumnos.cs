using LADU.Data;
using LADU.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LADU.UI
{
    public partial class FrmAlumnos : Form
    {
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void FrmALumnos_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void CargarAlumnos()
        {
            try
            {
                AlumnoRepository repo = new AlumnoRepository();
                dataGridViewAlumnos.DataSource = repo.ObtenerAlumnos();

                if (dataGridViewAlumnos.Columns["IdAlumno"] != null)
                    dataGridViewAlumnos.Columns["IdAlumno"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los alumnos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoAlumno frm = new FrmNuevoAlumno();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarAlumnos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.SelectedRows.Count > 0)
            {
                Alumno alumnoSeleccionado = (Alumno)dataGridViewAlumnos.SelectedRows[0].DataBoundItem;
                FrmNuevoAlumno frm = new FrmNuevoAlumno(alumnoSeleccionado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarAlumnos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un alumno para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.SelectedRows.Count > 0)
            {
                Alumno alumnoSeleccionado = (Alumno)dataGridViewAlumnos.SelectedRows[0].DataBoundItem;

                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de eliminar permanentemente al alumno '{alumnoSeleccionado.NombreCompleto}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        AlumnoRepository repo = new AlumnoRepository();
                        repo.EliminarAlumno(alumnoSeleccionado.IdAlumno);

                        MessageBox.Show("El alumno ha sido eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarAlumnos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar el alumno. Detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un alumno para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Pinta de gris los alumnos inactivos
        private void dataGridViewAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewAlumnos.Rows[e.RowIndex].DataBoundItem is Alumno alumno)
            {
                if (!alumno.Activo)
                {
                    dataGridViewAlumnos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                    dataGridViewAlumnos.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.LightGray;
                }
            }
        }

        // Doble clic para edición rápida
        private void dataGridViewAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Alumno alumnoSeleccionado = (Alumno)dataGridViewAlumnos.Rows[e.RowIndex].DataBoundItem;
                FrmNuevoAlumno frm = new FrmNuevoAlumno(alumnoSeleccionado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarAlumnos();
                }
            }

        }

    }
}

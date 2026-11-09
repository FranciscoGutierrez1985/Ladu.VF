using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LADU.Data;
using LADU.Entities;

namespace LADU.UI
{
    public partial class FrmCursos : Form
    {
        public FrmCursos()
        {
            InitializeComponent();
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            CargarCursos();
        }

        private void CargarCursos()
        {
            try
            {
                CursoRepository repo = new CursoRepository();
                dataGridViewCursos.DataSource = repo.ObtenerCursos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cursos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoCurso frm = new FrmNuevoCurso();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarCursos(); // Recarga la grilla automáticamente al guardar
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCursos.SelectedRows.Count > 0)
            {
                // Obtenemos el objeto Curso ligado a la fila seleccionada en la grilla
                Curso cursoSeleccionado = (Curso)dataGridViewCursos.SelectedRows[0].DataBoundItem;

                // Abrimos el formulario pasándole el curso seleccionado
                FrmNuevoCurso frm = new FrmNuevoCurso(cursoSeleccionado);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarCursos(); // Recargamos la grilla para ver los cambios reflejados
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un curso de la grilla para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificamos que la fila sea válida
            if (dataGridViewCursos.Rows[e.RowIndex].DataBoundItem is Curso curso)
            {
                // Si el curso está inactivo (Activo == false)
                if (!curso.Activo)
                {
                    // Pintamos toda la fila de un gris clarito para distinguirla
                    dataGridViewCursos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                    dataGridViewCursos.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LightGray;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos que haya una fila seleccionada
            if (dataGridViewCursos.SelectedRows.Count > 0)
            {
                // Obtenemos el curso de la fila seleccionada
                Curso cursoSeleccionado = (Curso)dataGridViewCursos.SelectedRows[0].DataBoundItem;

                // Mensaje de confirmación de seguridad (¡Muy importante!)
                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de que querés eliminar permanentemente el curso '{cursoSeleccionado.Nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Llamamos al repositorio para borrarlo de la base de datos
                        CursoRepository repositorio = new CursoRepository();
                        repositorio.EliminarCurso(cursoSeleccionado.IdCurso);

                        MessageBox.Show("El curso ha sido eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargamos la grilla
                        CargarCursos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar el curso. Es posible que tenga registros asociados.\n\nDetalle: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un curso de la grilla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGestionarMaterias_Click(object sender, EventArgs e)
        {
            // Verificamos que haya un curso seleccionado en la grilla
            if (dataGridViewCursos.CurrentRow != null)
            {
                // Obtenemos el ID y el Nombre del curso de la fila seleccionada
                int idCurso = Convert.ToInt32(dataGridViewCursos.CurrentRow.Cells["IdCurso"].Value);
                string nombreCurso = dataGridViewCursos.CurrentRow.Cells["Nombre"].Value.ToString();

                // Abrimos el formulario pasándole los datos y el tipo "Materias"
                FrmGestionCurso frm = new FrmGestionCurso(idCurso, nombreCurso, TipoGestion.Materias);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un curso de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGestionarAlumnos_Click(object sender, EventArgs e)
        {
            if (dataGridViewCursos.CurrentRow != null)
            {
                // Obtenemos el ID y el Nombre del curso
                int idCurso = Convert.ToInt32(dataGridViewCursos.CurrentRow.Cells["IdCurso"].Value);
                string nombreCurso = dataGridViewCursos.CurrentRow.Cells["Nombre"].Value.ToString();

                // Abrimos el formulario pasándole los datos y el tipo "Alumnos"
                FrmGestionCurso frm = new FrmGestionCurso(idCurso, nombreCurso, TipoGestion.Alumnos);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un curso de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
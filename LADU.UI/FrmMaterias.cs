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
    public partial class FrmMaterias : Form
    {
        public FrmMaterias()
        {
            InitializeComponent();
        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            CargarMaterias();
        }
        private void CargarMaterias()
        {
            try
            {
                MateriaRepository repo = new MateriaRepository();
                dataGridViewMaterias.DataSource = repo.ObtenerMaterias();

                // Opcional: Ocultar o renombrar columnas si es necesario
                if (dataGridViewMaterias.Columns["IdMateria"] != null)
                    dataGridViewMaterias.Columns["IdMateria"].Visible = false; // Ocultamos el ID si querés
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las materias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaMateria frm = new FrmNuevaMateria();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarMaterias();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaterias.SelectedRows.Count > 0)
            {
                Materia materiaSeleccionada = (Materia)dataGridViewMaterias.SelectedRows[0].DataBoundItem;
                FrmNuevaMateria frm = new FrmNuevaMateria(materiaSeleccionada);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarMaterias();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una materia para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaterias.SelectedRows.Count > 0)
            {
                Materia materiaSeleccionada = (Materia)dataGridViewMaterias.SelectedRows[0].DataBoundItem;

                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de que querés eliminar permanentemente la materia '{materiaSeleccionada.Nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        MateriaRepository repo = new MateriaRepository();
                        repo.EliminarMateria(materiaSeleccionada.IdMateria);

                        MessageBox.Show("La materia ha sido eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarMaterias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar la materia. Detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una materia para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento para pintar de gris las materias inactivas
        private void dataGridViewMaterias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewMaterias.Rows[e.RowIndex].DataBoundItem is Materia materia)
            {
                if (!materia.Activo)
                {
                    dataGridViewMaterias.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                    dataGridViewMaterias.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.LightGray;
                }
            }
        }

        // Evento de doble clic para editar de forma rápida
        private void dataGridViewMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Materia materiaSeleccionada = (Materia)dataGridViewMaterias.Rows[e.RowIndex].DataBoundItem;
                FrmNuevaMateria frm = new FrmNuevaMateria(materiaSeleccionada);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarMaterias();
                }
            }
        }

    }
}

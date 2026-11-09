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
    public partial class FrmNuevoCurso : Form
    {
        private int? idCursoActual = null; // Si es null, es un alta. Si tiene valor, es edición.

        // Constructor para NUEVO curso
        public FrmNuevoCurso()
        {
            InitializeComponent();
            chkActivo.Checked = true;
            chkActivo.Visible = false;
        }

        // Constructor para EDITAR curso (recibe el curso seleccionado)
        public FrmNuevoCurso(Curso cursoAModificar) : this()
        {
            idCursoActual = cursoAModificar.IdCurso;
            txtNombre.Text = cursoAModificar.Nombre;
            txtDivision.Text = cursoAModificar.Division;
            txtNumAnio.Text = cursoAModificar.Anio.ToString();
            chkActivo.Checked = cursoAModificar.Activo;
            
            chkActivo.Visible = true;
            

            this.Text = "Modificar Curso"; // Cambiamos el título de la ventana
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del curso.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Curso curso = new Curso
                {
                    Nombre = txtNombre.Text.Trim(),
                    Division = txtDivision.Text.Trim(),
                    Anio = Convert.ToInt32(txtNumAnio.Text.Trim()),
                    Activo = chkActivo.Checked
                };

                CursoRepository repo = new CursoRepository();
                bool resultado = false;

                if (idCursoActual == null)
                {
                    // Es un alta
                    resultado = repo.InsertarCurso(curso);
                }
                else
                {
                    // Es una actualización
                    curso.IdCurso = idCursoActual.Value;
                    resultado = repo.ActualizarCurso(curso);
                }

                if (resultado)
                {
                    string mensaje = idCursoActual == null ? "Curso guardado correctamente." : "Curso actualizado correctamente.";
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el curso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

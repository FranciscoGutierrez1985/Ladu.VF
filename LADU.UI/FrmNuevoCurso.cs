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
        public FrmNuevoCurso()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del curso.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Curso nuevoCurso = new Curso
                {
                    Nombre = txtNombre.Text.Trim(),
                    Division = txtDivision.Text.Trim(),
                    Anio = Convert.ToInt32(txtNumAnio.Text.Trim()),
                    Activo = chkActivo.Checked
                };

                CursoRepository repo = new CursoRepository();
                if (repo.InsertarCurso(nuevoCurso))
                {
                    MessageBox.Show("Curso guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Indica que guardó ok para recargar la grilla
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

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
    public partial class FrmNuevaMateria : Form
    {
        private int idMateriaActual = 0;
        private bool esEdicion = false;
        public FrmNuevaMateria()
        {
            InitializeComponent();
            this.Text = "Nueva Materia";

            // En alta el checkbox de activo no va visible (nace activa por defecto)
            chkActivo.Checked = true;
            chkActivo.Visible = false;
        }
        public FrmNuevaMateria(Materia materiaAModificar) : this()
        {
            esEdicion = true;
            this.Text = "Modificar Materia";

            idMateriaActual = materiaAModificar.IdMateria;
            txtNombre.Text = materiaAModificar.Nombre;
            txtDescripcion.Text = materiaAModificar.Descripcion;
            chkActivo.Checked = materiaAModificar.Activo;

            // Al editar sí mostramos el checkbox para permitir activar/desactivar
            chkActivo.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la materia es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            try
            {
                MateriaRepository repo = new MateriaRepository();

                if (!esEdicion)
                {
                    // Alta
                    Materia nuevaMateria = new Materia
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Descripcion = txtDescripcion.Text.Trim()
                    };
                    repo.InsertarMateria(nuevaMateria);
                    MessageBox.Show("Materia creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Modificación
                    Materia materiaModificada = new Materia
                    {
                        IdMateria = idMateriaActual,
                        Nombre = txtNombre.Text.Trim(),
                        Descripcion = txtDescripcion.Text.Trim(),
                        Activo = chkActivo.Checked
                    };
                    repo.ModificarMateria(materiaModificada);
                    MessageBox.Show("Materia modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmNuevaMateria_Load(object sender, EventArgs e)
        {

        }

    }
}

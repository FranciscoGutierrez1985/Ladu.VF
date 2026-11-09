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
    public partial class FrmNuevoAlumno : Form
    {
        private int idAlumnoActual = 0;
        private bool esEdicion = false;

        public FrmNuevoAlumno()
        {
            InitializeComponent();
            this.Text = "Nuevo Alumno";

            // En alta el checkbox de activo no va visible (nace activo por defecto)
            chkActivo.Checked = true;
            chkActivo.Visible = false;
        }

        public FrmNuevoAlumno(Alumno alumnoAModificar) : this()
        {
            esEdicion = true;
            this.Text = "Modificar Alumno";

            idAlumnoActual = alumnoAModificar.IdAlumno;
            txtNombre.Text = alumnoAModificar.Nombre;
            txtApellido.Text = alumnoAModificar.Apellido;
            txtDni.Text = alumnoAModificar.Dni;
            txtEmail.Text = alumnoAModificar.Email;
            txtLegajo.Text = alumnoAModificar.Legajo;
            chkActivo.Checked = alumnoAModificar.Activo;

            // Al editar sí mostramos el checkbox para permitir activar/desactivar
            chkActivo.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas (Nombre, Apellido y DNI obligatorios)
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor complete los campos obligatorios (Nombre, Apellido y DNI).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            try
            {
                AlumnoRepository repo = new AlumnoRepository();

                if (!esEdicion)
                {
                    // Alta
                    Alumno nuevoAlumno = new Alumno
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Apellido = txtApellido.Text.Trim(),
                        Dni = txtDni.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Legajo = txtLegajo.Text.Trim()
                    };
                    repo.InsertarAlumno(nuevoAlumno);
                    MessageBox.Show("Alumno creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Modificación
                    Alumno alumnoModificado = new Alumno
                    {
                        IdAlumno = idAlumnoActual,
                        Nombre = txtNombre.Text.Trim(),
                        Apellido = txtApellido.Text.Trim(),
                        Dni = txtDni.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Legajo = txtLegajo.Text.Trim(),
                        Activo = chkActivo.Checked
                    };
                    repo.ActualizarAlumno(alumnoModificado);
                    MessageBox.Show("Alumno modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FrmNuevoAlumno_Load(object sender, EventArgs e)
        {

        }

    }
}

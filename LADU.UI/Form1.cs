using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LADU.Business;

namespace LADU.UI
{
    public partial class Form1 : Form
    {
        private AuthService _authService;
        public Form1()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string legajo = txtLegajo.Text.Trim();

            if (string.IsNullOrEmpty(legajo))
            {
                MessageBox.Show("Por favor, ingrese un legajo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Instanciamos el repositorio que creamos en LADU.Data
                var usuarioRepo = new LADU.Data.UsuarioRepository();
                var usuario = usuarioRepo.ObtenerPorLegajoDni(legajo);

                if (usuario != null)
                {
                    // Ocultamos el login actual
                    this.Hide();

                    // Abrimos el formulario principal pasándole el objeto usuario
                    FrmPrincipal principal = new FrmPrincipal(usuario);
                    principal.ShowDialog();

                    // Cuando se cierre el principal, cerramos toda la aplicación
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El legajo ingresado no existe en el sistema.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al conectar con la base de datos: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

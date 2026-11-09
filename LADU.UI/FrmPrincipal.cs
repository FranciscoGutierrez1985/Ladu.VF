using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LADU.Entities;

namespace LADU.UI
{
    public partial class FrmPrincipal : Form
    {
        private Usuario _usuarioLogueado;

        // Constructor que recibe el usuario autenticado
        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogueado = usuario;
            ConfigurarPantallaSegunRol();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Saludo de bienvenida
            lblBienvenida.Text = $"¡Hola, {_usuarioLogueado.Nombre} {_usuarioLogueado.Apellido}!";

            // Actualizamos el texto del StatusStrip
            toolStripStatusLabel1.Text = $"Conectado | Usuario: {_usuarioLogueado.Nombre} {_usuarioLogueado.Apellido} [{_usuarioLogueado.NombreRol}]";
        }

        private void ConfigurarPantallaSegunRol()
        {
            // Ejemplo práctico de seguridad por roles:
            if (_usuarioLogueado.NombreRol == "Docente")
            {
                // Si es docente, ocultamos botones de administración avanzada
                // btnAdministracion.Visible = false; 
            }
            else if (_usuarioLogueado.NombreRol == "Administrador" || _usuarioLogueado.NombreRol == "Directivo")
            {
                // Tienen acceso total
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            FrmCursos frm = new FrmCursos();
            frm.ShowDialog(); // Abre la ventana de cursos
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerramos este form y volvemos a mostrar el Login (Form1)
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Close();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FrmMaterias frm = new FrmMaterias();
            frm.ShowDialog();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FrmAlumnos frm = new FrmAlumnos();
            frm.ShowDialog(); // Abre la ventana de alumnos
        }
    }
}

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
                dataGridView1.DataSource = repo.ObtenerCursos();
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
    }
}
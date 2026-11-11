namespace LADU.UI
{
    partial class FrmMenuDocente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenida = new Label();
            cmbCursos = new ComboBox();
            btnAsistencia = new Button();
            btnLibroTemas = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(448, 35);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(38, 15);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "label1";
            // 
            // cmbCursos
            // 
            cmbCursos.FormattingEnabled = true;
            cmbCursos.Location = new Point(198, 145);
            cmbCursos.Name = "cmbCursos";
            cmbCursos.Size = new Size(201, 23);
            cmbCursos.TabIndex = 1;
            // 
            // btnAsistencia
            // 
            btnAsistencia.Location = new Point(198, 248);
            btnAsistencia.Name = "btnAsistencia";
            btnAsistencia.Size = new Size(75, 23);
            btnAsistencia.TabIndex = 2;
            btnAsistencia.Text = "Asistencia";
            btnAsistencia.UseVisualStyleBackColor = true;
            btnAsistencia.Click += btnAsistencia_Click;
            // 
            // btnLibroTemas
            // 
            btnLibroTemas.Location = new Point(305, 248);
            btnLibroTemas.Name = "btnLibroTemas";
            btnLibroTemas.Size = new Size(94, 23);
            btnLibroTemas.TabIndex = 3;
            btnLibroTemas.Text = "Libro de temas";
            btnLibroTemas.UseVisualStyleBackColor = true;
            btnLibroTemas.Click += btnLibroTemas_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(251, 323);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(91, 23);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerra Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // FrmMenuDocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 520);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnLibroTemas);
            Controls.Add(btnAsistencia);
            Controls.Add(cmbCursos);
            Controls.Add(lblBienvenida);
            Name = "FrmMenuDocente";
            Text = "FrmMenuDocente";
            Load += FrmMenuDocente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private ComboBox cmbCursos;
        private Button btnAsistencia;
        private Button btnLibroTemas;
        private Button btnCerrarSesion;
    }
}
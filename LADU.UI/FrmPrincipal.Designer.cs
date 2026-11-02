namespace LADU.UI
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            btnCerrarSesion = new ToolStripMenuItem();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnAsistencia = new Button();
            btnCursosyMaterias = new Button();
            statusStripInfoUsuario = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblBienvenida = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            statusStripInfoUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, gestionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(936, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnCerrarSesion });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(142, 22);
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(59, 20);
            gestionToolStripMenuItem.Text = "Gestion";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnAsistencia);
            panel1.Controls.Add(btnCursosyMaterias);
            panel1.Controls.Add(statusStripInfoUsuario);
            panel1.Controls.Add(lblBienvenida);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 579);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btnAsistencia
            // 
            btnAsistencia.Location = new Point(496, 212);
            btnAsistencia.Name = "btnAsistencia";
            btnAsistencia.Size = new Size(120, 75);
            btnAsistencia.TabIndex = 3;
            btnAsistencia.Text = "Asistencia";
            btnAsistencia.UseVisualStyleBackColor = true;
            btnAsistencia.Click += button2_Click;
            // 
            // btnCursosyMaterias
            // 
            btnCursosyMaterias.Location = new Point(294, 212);
            btnCursosyMaterias.Name = "btnCursosyMaterias";
            btnCursosyMaterias.Size = new Size(120, 75);
            btnCursosyMaterias.TabIndex = 2;
            btnCursosyMaterias.Text = "Cursos y Materias";
            btnCursosyMaterias.UseVisualStyleBackColor = true;
            btnCursosyMaterias.Click += btnCursosyMaterias_Click;
            // 
            // statusStripInfoUsuario
            // 
            statusStripInfoUsuario.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStripInfoUsuario.Location = new Point(0, 557);
            statusStripInfoUsuario.Name = "statusStripInfoUsuario";
            statusStripInfoUsuario.Size = new Size(936, 22);
            statusStripInfoUsuario.TabIndex = 1;
            statusStripInfoUsuario.Text = "statusStrip1";
            statusStripInfoUsuario.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(412, 30);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(65, 22);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "label1";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 607);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStripInfoUsuario.ResumeLayout(false);
            statusStripInfoUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem btnCerrarSesion;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private Panel panel1;
        private Label lblBienvenida;
        private StatusStrip statusStripInfoUsuario;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btnCursosyMaterias;
        private Button btnAsistencia;
    }
}
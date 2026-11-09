namespace LADU.UI
{
    partial class FrmGestionCurso
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
            lblTituloCurso = new Label();
            lstDisponibles = new ListBox();
            lstAsignados = new ListBox();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTituloCurso
            // 
            lblTituloCurso.AutoSize = true;
            lblTituloCurso.Location = new Point(379, 18);
            lblTituloCurso.Name = "lblTituloCurso";
            lblTituloCurso.Size = new Size(38, 15);
            lblTituloCurso.TabIndex = 0;
            lblTituloCurso.Text = "label1";
            // 
            // lstDisponibles
            // 
            lstDisponibles.FormattingEnabled = true;
            lstDisponibles.Location = new Point(188, 73);
            lstDisponibles.Name = "lstDisponibles";
            lstDisponibles.Size = new Size(187, 214);
            lstDisponibles.TabIndex = 1;
            // 
            // lstAsignados
            // 
            lstAsignados.FormattingEnabled = true;
            lstAsignados.Location = new Point(477, 73);
            lstAsignados.Name = "lstAsignados";
            lstAsignados.Size = new Size(187, 214);
            lstAsignados.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(394, 112);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(58, 20);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = ">";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(394, 179);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(58, 20);
            btnQuitar.TabIndex = 4;
            btnQuitar.Text = "<";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(394, 324);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmGestionCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 553);
            Controls.Add(btnCerrar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(lstAsignados);
            Controls.Add(lstDisponibles);
            Controls.Add(lblTituloCurso);
            Name = "FrmGestionCurso";
            Text = "FrmGestionCurso";
            Load += FrmGestionCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloCurso;
        private ListBox lstDisponibles;
        private ListBox lstAsignados;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnCerrar;
    }
}
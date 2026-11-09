namespace LADU.UI
{
    partial class FrmNuevoAlumno
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtEmail = new TextBox();
            txtLegajo = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblEmail = new Label();
            lblLegajo = new Label();
            chkActivo = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(147, 135);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(147, 184);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(147, 280);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(100, 23);
            txtLegajo.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 88);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre : ";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(12, 138);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido : ";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(12, 187);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(36, 15);
            lblDni.TabIndex = 7;
            lblDni.Text = "DNI : ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 239);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(45, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email : ";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(12, 283);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(48, 15);
            lblLegajo.TabIndex = 9;
            lblLegajo.Text = "Legajo: ";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(15, 349);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 10;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(75, 386);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 32);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(210, 386);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 32);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmNuevoAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(chkActivo);
            Controls.Add(lblLegajo);
            Controls.Add(lblEmail);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtLegajo);
            Controls.Add(txtEmail);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FrmNuevoAlumno";
            Text = "FrmNuevoAlumno";
            Load += FrmNuevoAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtEmail;
        private TextBox txtLegajo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblEmail;
        private Label lblLegajo;
        private CheckBox chkActivo;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
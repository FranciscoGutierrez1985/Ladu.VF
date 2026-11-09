namespace LADU.UI
{
    partial class FrmNuevaMateria
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
            txtDescripcion = new TextBox();
            lblNombre = new Label();
            lbldescripcion = new Label();
            chkActivo = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(114, 125);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(157, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(36, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lbldescripcion
            // 
            lbldescripcion.AutoSize = true;
            lbldescripcion.Location = new Point(36, 128);
            lbldescripcion.Name = "lbldescripcion";
            lbldescripcion.Size = new Size(72, 15);
            lbldescripcion.TabIndex = 3;
            lbldescripcion.Text = "Descripción:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(36, 186);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(82, 19);
            chkActivo.TabIndex = 4;
            chkActivo.Text = "checkBox1";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(32, 258);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(139, 258);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmNuevaMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 512);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(chkActivo);
            Controls.Add(lbldescripcion);
            Controls.Add(lblNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Name = "FrmNuevaMateria";
            Text = "FrmNuevaMateria";
            Load += FrmNuevaMateria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label lblNombre;
        private Label lbldescripcion;
        private CheckBox chkActivo;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
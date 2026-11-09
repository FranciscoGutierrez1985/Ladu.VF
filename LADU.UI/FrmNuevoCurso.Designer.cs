namespace LADU.UI
{
    partial class FrmNuevoCurso
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
            txtDivision = new TextBox();
            txtNumAnio = new TextBox();
            chkActivo = new CheckBox();
            btnguardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            Division = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(201, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(208, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDivision
            // 
            txtDivision.Location = new Point(201, 88);
            txtDivision.Name = "txtDivision";
            txtDivision.Size = new Size(208, 23);
            txtDivision.TabIndex = 1;
            // 
            // txtNumAnio
            // 
            txtNumAnio.Location = new Point(201, 135);
            txtNumAnio.Name = "txtNumAnio";
            txtNumAnio.Size = new Size(208, 23);
            txtNumAnio.TabIndex = 2;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(70, 208);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 3;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(68, 267);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(122, 46);
            btnguardar.TabIndex = 4;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(211, 267);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 46);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 45);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // Division
            // 
            Division.AutoSize = true;
            Division.Location = new Point(34, 96);
            Division.Name = "Division";
            Division.Size = new Size(49, 15);
            Division.TabIndex = 7;
            Division.Text = "Division";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 143);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 8;
            label3.Text = "Año";
            // 
            // FrmNuevoCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(Division);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnguardar);
            Controls.Add(chkActivo);
            Controls.Add(txtNumAnio);
            Controls.Add(txtDivision);
            Controls.Add(txtNombre);
            Name = "FrmNuevoCurso";
            Text = "FrmNuevoCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDivision;
        private TextBox txtNumAnio;
        private CheckBox chkActivo;
        private Button btnguardar;
        private Button btnCancelar;
        private Label label1;
        private Label Division;
        private Label label3;
    }
}
namespace LADU.UI
{
    partial class FrmAlumnos
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
            dataGridViewAlumnos = new DataGridView();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAlumnos
            // 
            dataGridViewAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlumnos.Location = new Point(56, 37);
            dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            dataGridViewAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAlumnos.Size = new Size(667, 217);
            dataGridViewAlumnos.TabIndex = 0;
            dataGridViewAlumnos.CellContentClick += dataGridViewAlumnos_CellDoubleClick;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(59, 342);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(156, 342);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(253, 342);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridViewAlumnos);
            Name = "FrmAlumnos";
            Text = "FrmALumnos";
            Load += FrmALumnos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAlumnos;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
    }
}
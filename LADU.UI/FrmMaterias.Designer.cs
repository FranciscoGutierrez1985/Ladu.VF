namespace LADU.UI
{
    partial class FrmMaterias
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
            components = new System.ComponentModel.Container();
            dataGridViewMaterias = new DataGridView();
            cursoBindingSource = new BindingSource(components);
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaterias
            // 
            dataGridViewMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterias.Location = new Point(127, 12);
            dataGridViewMaterias.Name = "dataGridViewMaterias";
            dataGridViewMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaterias.Size = new Size(538, 207);
            dataGridViewMaterias.TabIndex = 0;
            dataGridViewMaterias.CellFormatting += dataGridViewMaterias_CellFormatting;
            // 
            // cursoBindingSource
            // 
            cursoBindingSource.DataSource = typeof(Entities.Curso);
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(75, 277);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(92, 32);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nueva Materia";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(173, 277);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(89, 32);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar Materia";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(268, 277);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 32);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Materia";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridViewMaterias);
            Name = "FrmMaterias";
            Text = "FrmMaterias";
            Load += FrmMaterias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMaterias;
        private BindingSource cursoBindingSource;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
    }
}
namespace LADU.UI
{
    partial class FrmCursos
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
            dataGridViewCursos = new DataGridView();
            cursoBindingSource = new BindingSource(components);
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGestionarMaterias = new Button();
            btnGestionarAlumnos = new Button();
            IdCurso = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            divisionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCursos
            // 
            dataGridViewCursos.AutoGenerateColumns = false;
            dataGridViewCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCursos.Columns.AddRange(new DataGridViewColumn[] { IdCurso, Nombre, divisionDataGridViewTextBoxColumn, anioDataGridViewTextBoxColumn, activoDataGridViewCheckBoxColumn });
            dataGridViewCursos.DataSource = cursoBindingSource;
            dataGridViewCursos.Location = new Point(193, 64);
            dataGridViewCursos.Name = "dataGridViewCursos";
            dataGridViewCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCursos.Size = new Size(545, 256);
            dataGridViewCursos.TabIndex = 0;
            dataGridViewCursos.CellContentClick += dataGridView1_CellContentClick;
            dataGridViewCursos.CellFormatting += dataGridViewCursos_CellFormatting;
            // 
            // cursoBindingSource
            // 
            cursoBindingSource.DataSource = typeof(Entities.Curso);
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(39, 64);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo Curso";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(39, 139);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(39, 199);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGestionarMaterias
            // 
            btnGestionarMaterias.Location = new Point(281, 372);
            btnGestionarMaterias.Name = "btnGestionarMaterias";
            btnGestionarMaterias.Size = new Size(125, 23);
            btnGestionarMaterias.TabIndex = 4;
            btnGestionarMaterias.Text = "Gestionar Materias";
            btnGestionarMaterias.UseVisualStyleBackColor = true;
            btnGestionarMaterias.Click += btnGestionarMaterias_Click;
            // 
            // btnGestionarAlumnos
            // 
            btnGestionarAlumnos.Location = new Point(421, 372);
            btnGestionarAlumnos.Name = "btnGestionarAlumnos";
            btnGestionarAlumnos.Size = new Size(120, 23);
            btnGestionarAlumnos.TabIndex = 5;
            btnGestionarAlumnos.Text = "Gestionar Alumnos";
            btnGestionarAlumnos.UseVisualStyleBackColor = true;
            btnGestionarAlumnos.Click += btnGestionarAlumnos_Click;
            // 
            // IdCurso
            // 
            IdCurso.DataPropertyName = "IdCurso";
            IdCurso.HeaderText = "IdCurso";
            IdCurso.Name = "IdCurso";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            divisionDataGridViewTextBoxColumn.HeaderText = "Division";
            divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            // 
            // anioDataGridViewTextBoxColumn
            // 
            anioDataGridViewTextBoxColumn.DataPropertyName = "Anio";
            anioDataGridViewTextBoxColumn.HeaderText = "Anio";
            anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            activoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // FrmCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 542);
            Controls.Add(btnGestionarAlumnos);
            Controls.Add(btnGestionarMaterias);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridViewCursos);
            Name = "FrmCursos";
            Text = "FrmCursos";
            Load += FrmCursos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCursos;
        private BindingSource cursoBindingSource;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGestionarMaterias;
        private Button btnGestionarAlumnos;
        private DataGridViewTextBoxColumn IdCurso;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}
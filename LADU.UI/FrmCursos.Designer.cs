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
            dataGridView1 = new DataGridView();
            idCursoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            divisionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            cursoBindingSource = new BindingSource(components);
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idCursoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, divisionDataGridViewTextBoxColumn, anioDataGridViewTextBoxColumn, activoDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = cursoBindingSource;
            dataGridView1.Location = new Point(188, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(486, 256);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idCursoDataGridViewTextBoxColumn
            // 
            idCursoDataGridViewTextBoxColumn.DataPropertyName = "IdCurso";
            idCursoDataGridViewTextBoxColumn.HeaderText = "IdCurso";
            idCursoDataGridViewTextBoxColumn.Name = "idCursoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
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
            // 
            // cursoBindingSource
            // 
            cursoBindingSource.DataSource = typeof(Entities.Curso);
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(193, 368);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo Curso";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // FrmCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 542);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridView1);
            Name = "FrmCursos";
            Text = "FrmCursos";
            Load += FrmCursos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private BindingSource cursoBindingSource;
        private Button btnNuevo;
    }
}
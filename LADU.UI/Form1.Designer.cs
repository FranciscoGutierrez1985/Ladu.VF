namespace LADU.UI
{
    partial class Form1
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
            txtLegajo = new TextBox();
            txtLogin = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(296, 219);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(245, 23);
            txtLegajo.TabIndex = 0;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(296, 266);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(245, 23);
            txtLogin.TabIndex = 1;
            txtLogin.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(373, 316);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 219);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "USUARIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 274);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 4;
            label2.Text = "CONTRASEÑA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 9);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 5;
            label3.Text = "BIENVENIDO A LADU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtLogin);
            Controls.Add(txtLegajo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLegajo;
        private TextBox txtLogin;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
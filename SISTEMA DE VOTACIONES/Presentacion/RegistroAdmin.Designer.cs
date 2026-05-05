namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    partial class RegistroAdminForm
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
            btnCerrar = new Button();
            btnGuardar = new Button();
            cmbRol = new ComboBox();
            txtContraseña = new TextBox();
            txtMatricula = new TextBox();
            txtSeccion = new TextBox();
            txtCurso = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCerrar.Location = new Point(125, 410);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 26);
            btnCerrar.TabIndex = 19;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(125, 370);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 26);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbRol
            // 
            cmbRol.Enabled = false;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(67, 329);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(193, 23);
            cmbRol.TabIndex = 17;
            cmbRol.Text = "Administrador";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(67, 290);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(193, 23);
            txtContraseña.TabIndex = 16;
            txtContraseña.Text = "Contraseña";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(67, 250);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(193, 23);
            txtMatricula.TabIndex = 15;
            txtMatricula.Text = "Matricula";
            // 
            // txtSeccion
            // 
            txtSeccion.Location = new Point(67, 208);
            txtSeccion.Name = "txtSeccion";
            txtSeccion.Size = new Size(193, 23);
            txtSeccion.TabIndex = 14;
            txtSeccion.Text = "Seccion";
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(67, 166);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(193, 23);
            txtCurso.TabIndex = 13;
            txtCurso.Text = "Curso";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(67, 123);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 23);
            txtNombre.TabIndex = 12;
            txtNombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(13, 48);
            label2.Name = "label2";
            label2.Size = new Size(302, 47);
            label2.TabIndex = 11;
            label2.Text = "ADMINISTRADORES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(110, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 10;
            label1.Text = "REGISTRO";
            // 
            // RegistroAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(327, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbRol);
            Controls.Add(txtContraseña);
            Controls.Add(txtMatricula);
            Controls.Add(txtSeccion);
            Controls.Add(txtCurso);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroAdminForm";
            Text = "RegistroAdmin";
            Load += RegistroAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnGuardar;
        private ComboBox cmbRol;
        private TextBox txtContraseña;
        private TextBox txtMatricula;
        private TextBox txtSeccion;
        private TextBox txtCurso;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
    }
}
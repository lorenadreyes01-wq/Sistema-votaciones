namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    partial class RegistroUVForm
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
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtCurso = new TextBox();
            txtSeccion = new TextBox();
            txtMatricula = new TextBox();
            txtContraseña = new TextBox();
            cmbRol = new ComboBox();
            btnGuardar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(95, 20);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(56, 44);
            label2.Name = "label2";
            label2.Size = new Size(187, 48);
            label2.TabIndex = 1;
            label2.Text = "VOTANTES";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(52, 125);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 23);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "Nombre";
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(52, 168);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(193, 23);
            txtCurso.TabIndex = 3;
            txtCurso.Text = "Curso";
            // 
            // txtSeccion
            // 
            txtSeccion.Location = new Point(52, 210);
            txtSeccion.Name = "txtSeccion";
            txtSeccion.Size = new Size(193, 23);
            txtSeccion.TabIndex = 4;
            txtSeccion.Text = "Seccion";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(52, 252);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(193, 23);
            txtMatricula.TabIndex = 5;
            txtMatricula.Text = "Matricula";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(52, 292);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(193, 23);
            txtContraseña.TabIndex = 6;
            txtContraseña.Text = "Contraseña";
            // 
            // cmbRol
            // 
            cmbRol.Enabled = false;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(52, 331);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(193, 23);
            cmbRol.TabIndex = 7;
            cmbRol.Text = "Votante";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(110, 372);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 26);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCerrar.Location = new Point(110, 412);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 26);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // RegistroUVForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(301, 450);
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
            Name = "RegistroUVForm";
            Text = "RegistroUVForm";
            Load += RegistroUsuariosForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtCurso;
        private TextBox txtSeccion;
        private TextBox txtMatricula;
        private TextBox txtContraseña;
        private ComboBox cmbRol;
        private Button btnGuardar;
        private Button btnCerrar;
    }
}
namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    partial class UsuariosForm
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
            dgvUsuarios = new DataGridView();
            button1 = new Button();
            btnVer = new Button();
            btnRegistrar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(293, 16);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 0;
            label1.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(34, 64);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(609, 296);
            dgvUsuarios.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(79, 383);
            button1.Name = "button1";
            button1.Size = new Size(150, 31);
            button1.TabIndex = 2;
            button1.Text = "Añadir admin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = SystemColors.GradientInactiveCaption;
            btnVer.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            btnVer.ForeColor = SystemColors.MenuHighlight;
            btnVer.Location = new Point(266, 383);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(150, 31);
            btnVer.TabIndex = 3;
            btnVer.Text = "VER";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.GradientInactiveCaption;
            btnRegistrar.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            btnRegistrar.ForeColor = SystemColors.MenuHighlight;
            btnRegistrar.Location = new Point(455, 383);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 31);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar Votante";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.GradientInactiveCaption;
            btnEliminar.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.MenuHighlight;
            btnEliminar.Location = new Point(155, 439);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 31);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.GradientInactiveCaption;
            btnActualizar.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.MenuHighlight;
            btnActualizar.Location = new Point(335, 439);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 31);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // UsuariosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 500);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnVer);
            Controls.Add(button1);
            Controls.Add(dgvUsuarios);
            Controls.Add(label1);
            Name = "UsuariosForm";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvUsuarios;
        private Button button1;
        private Button btnVer;
        private Button btnRegistrar;
        private Button btnEliminar;
        private Button btnActualizar;
    }
}
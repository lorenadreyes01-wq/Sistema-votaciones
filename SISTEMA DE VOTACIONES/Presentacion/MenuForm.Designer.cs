namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    partial class MenuForm
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
            btnVotaciones = new Button();
            btnPanel = new Button();
            btnDatos = new Button();
            btnCerrar = new Button();
            btnPlancha = new Button();
            btnUsuarios = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Felix Titling", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(264, 18);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 0;
            label1.Text = "MENU";
            label1.Click += label1_Click;
            // 
            // btnVotaciones
            // 
            btnVotaciones.BackColor = Color.DarkCyan;
            btnVotaciones.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            btnVotaciones.ForeColor = SystemColors.ButtonHighlight;
            btnVotaciones.Location = new Point(46, 61);
            btnVotaciones.Name = "btnVotaciones";
            btnVotaciones.Size = new Size(167, 48);
            btnVotaciones.TabIndex = 1;
            btnVotaciones.Text = "Votaciones";
            btnVotaciones.UseVisualStyleBackColor = false;
            // 
            // btnPanel
            // 
            btnPanel.BackColor = Color.DarkCyan;
            btnPanel.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            btnPanel.ForeColor = SystemColors.ButtonHighlight;
            btnPanel.Location = new Point(219, 61);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(184, 48);
            btnPanel.TabIndex = 2;
            btnPanel.Text = "Panel de Votaciones";
            btnPanel.UseVisualStyleBackColor = false;
            // 
            // btnDatos
            // 
            btnDatos.BackColor = Color.DarkCyan;
            btnDatos.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            btnDatos.ForeColor = SystemColors.ButtonHighlight;
            btnDatos.Location = new Point(409, 61);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(159, 48);
            btnDatos.TabIndex = 3;
            btnDatos.Text = "Datos Generales";
            btnDatos.UseVisualStyleBackColor = false;
            btnDatos.Click += btnDatos_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.CadetBlue;
            btnCerrar.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            btnCerrar.ForeColor = SystemColors.Control;
            btnCerrar.Location = new Point(157, 121);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(129, 48);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar sesion";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnPlancha
            // 
            btnPlancha.BackColor = Color.RoyalBlue;
            btnPlancha.Font = new Font("Sitka Banner Semibold", 12F, FontStyle.Bold);
            btnPlancha.ForeColor = SystemColors.ButtonFace;
            btnPlancha.Location = new Point(303, 180);
            btnPlancha.Name = "btnPlancha";
            btnPlancha.Size = new Size(226, 48);
            btnPlancha.TabIndex = 5;
            btnPlancha.Text = "Planchas";
            btnPlancha.UseVisualStyleBackColor = false;
            btnPlancha.Click += btnPlancha_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.RoyalBlue;
            btnUsuarios.Font = new Font("Sitka Banner Semibold", 12F, FontStyle.Bold);
            btnUsuarios.ForeColor = SystemColors.ButtonFace;
            btnUsuarios.Location = new Point(86, 180);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(211, 48);
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.CadetBlue;
            btnSalir.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(336, 121);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 48);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(622, 246);
            Controls.Add(btnSalir);
            Controls.Add(btnCerrar);
            Controls.Add(btnPlancha);
            Controls.Add(btnUsuarios);
            Controls.Add(btnDatos);
            Controls.Add(btnPanel);
            Controls.Add(btnVotaciones);
            Controls.Add(label1);
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVotaciones;
        private Button btnPanel;
        private Button btnDatos;
        private Button btnCerrar;
        private Button btnPlancha;
        private Button btnUsuarios;
        private Button btnSalir;
    }
}
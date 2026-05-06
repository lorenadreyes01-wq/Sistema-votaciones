namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    partial class Datosform
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
            panel1 = new Panel();
            label1 = new Label();
            panelEstadisticas = new Panel();
            lblTiempoRestante = new Label();
            lblTotales = new Label();
            lblParticipantes = new Label();
            lblPadronElectoral = new Label();
            lblVotosEmitidos = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            timerTiempoRestante = new System.Windows.Forms.Timer(components);
            panelRanking = new Panel();
            dgvRankingPartidos = new DataGridView();
            btnCerrar = new Button();
            panel1.SuspendLayout();
            panelEstadisticas.SuspendLayout();
            panelRanking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRankingPartidos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(177, 22);
            label1.Name = "label1";
            label1.Size = new Size(426, 32);
            label1.TabIndex = 0;
            label1.Text = "Datos Generales de la Votación";
            // 
            // panelEstadisticas
            // 
            panelEstadisticas.BackColor = Color.White;
            panelEstadisticas.Controls.Add(lblTiempoRestante);
            panelEstadisticas.Controls.Add(lblTotales);
            panelEstadisticas.Controls.Add(lblParticipantes);
            panelEstadisticas.Controls.Add(lblPadronElectoral);
            panelEstadisticas.Controls.Add(lblVotosEmitidos);
            panelEstadisticas.Controls.Add(label6);
            panelEstadisticas.Controls.Add(label5);
            panelEstadisticas.Controls.Add(label4);
            panelEstadisticas.Controls.Add(label3);
            panelEstadisticas.Controls.Add(label2);
            panelEstadisticas.Location = new Point(39, 94);
            panelEstadisticas.Name = "panelEstadisticas";
            panelEstadisticas.Size = new Size(279, 230);
            panelEstadisticas.TabIndex = 1;
            // 
            // lblTiempoRestante
            // 
            lblTiempoRestante.AutoSize = true;
            lblTiempoRestante.Font = new Font("Archivo Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempoRestante.ForeColor = Color.Blue;
            lblTiempoRestante.Location = new Point(164, 184);
            lblTiempoRestante.Name = "lblTiempoRestante";
            lblTiempoRestante.Size = new Size(139, 21);
            lblTiempoRestante.TabIndex = 9;
            lblTiempoRestante.Text = "Votos Emitidos:";
            // 
            // lblTotales
            // 
            lblTotales.AutoSize = true;
            lblTotales.Font = new Font("Archivo Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotales.ForeColor = Color.Blue;
            lblTotales.Location = new Point(89, 145);
            lblTotales.Name = "lblTotales";
            lblTotales.Size = new Size(139, 21);
            lblTotales.TabIndex = 8;
            lblTotales.Text = "Votos Emitidos:";
            // 
            // lblParticipantes
            // 
            lblParticipantes.AutoSize = true;
            lblParticipantes.Font = new Font("Archivo Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParticipantes.ForeColor = Color.Blue;
            lblParticipantes.Location = new Point(132, 102);
            lblParticipantes.Name = "lblParticipantes";
            lblParticipantes.Size = new Size(139, 21);
            lblParticipantes.TabIndex = 7;
            lblParticipantes.Text = "Votos Emitidos:";
            // 
            // lblPadronElectoral
            // 
            lblPadronElectoral.AutoSize = true;
            lblPadronElectoral.Font = new Font("Archivo Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPadronElectoral.ForeColor = Color.Blue;
            lblPadronElectoral.Location = new Point(158, 60);
            lblPadronElectoral.Name = "lblPadronElectoral";
            lblPadronElectoral.Size = new Size(139, 21);
            lblPadronElectoral.TabIndex = 6;
            lblPadronElectoral.Text = "Votos Emitidos:";
            // 
            // lblVotosEmitidos
            // 
            lblVotosEmitidos.AutoSize = true;
            lblVotosEmitidos.Font = new Font("Archivo Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVotosEmitidos.ForeColor = Color.Blue;
            lblVotosEmitidos.Location = new Point(157, 17);
            lblVotosEmitidos.Name = "lblVotosEmitidos";
            lblVotosEmitidos.Size = new Size(139, 21);
            lblVotosEmitidos.TabIndex = 5;
            lblVotosEmitidos.Text = "Votos Emitidos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold);
            label6.Location = new Point(12, 186);
            label6.Name = "label6";
            label6.Size = new Size(158, 19);
            label6.TabIndex = 4;
            label6.Text = "Tiempo Restante:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold);
            label5.Location = new Point(13, 146);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 3;
            label5.Text = "Totales:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold);
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(124, 19);
            label4.TabIndex = 2;
            label4.Text = "Participantes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold);
            label3.Location = new Point(11, 61);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 1;
            label3.Text = "Padron Electoral:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold);
            label2.Location = new Point(13, 19);
            label2.Name = "label2";
            label2.Size = new Size(143, 19);
            label2.TabIndex = 0;
            label2.Text = "Votos Emitidos:";
            // 
            // panelRanking
            // 
            panelRanking.BackColor = Color.GhostWhite;
            panelRanking.Controls.Add(dgvRankingPartidos);
            panelRanking.Location = new Point(360, 94);
            panelRanking.Name = "panelRanking";
            panelRanking.Size = new Size(398, 228);
            panelRanking.TabIndex = 2;
            // 
            // dgvRankingPartidos
            // 
            dgvRankingPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRankingPartidos.Location = new Point(13, 10);
            dgvRankingPartidos.Name = "dgvRankingPartidos";
            dgvRankingPartidos.Size = new Size(368, 209);
            dgvRankingPartidos.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(340, 358);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(122, 35);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Datosform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 421);
            Controls.Add(btnCerrar);
            Controls.Add(panelRanking);
            Controls.Add(panelEstadisticas);
            Controls.Add(panel1);
            Name = "Datosform";
            Text = "Datosgenerales";
            Load += Datosgenerales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelEstadisticas.ResumeLayout(false);
            panelEstadisticas.PerformLayout();
            panelRanking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRankingPartidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panelEstadisticas;
        private Label label3;
        private Label label2;
        private Label lblVotosEmitidos;
        private Label label6;
        private Label label5;
        private Label label4;
        private System.Windows.Forms.Timer timerTiempoRestante;
        private Label lblTiempoRestante;
        private Label lblTotales;
        private Label lblParticipantes;
        private Label lblPadronElectoral;
        private Panel panelRanking;
        private Button btnCerrar;
        private DataGridView dgvRankingPartidos;
    }
}
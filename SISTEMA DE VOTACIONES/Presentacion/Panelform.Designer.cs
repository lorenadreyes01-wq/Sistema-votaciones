namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    partial class Panelform
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
            panelGrafico = new Panel();
            panelTiempo = new Panel();
            label8 = new Label();
            lblTiempoRestante = new Label();
            btnComparacion = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblEmitidos = new Label();
            lblNulos = new Label();
            lblParticipacion = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            timerTiempo = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            panel1.SuspendLayout();
            panelTiempo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 57);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(165, 12);
            label1.Name = "label1";
            label1.Size = new Size(366, 30);
            label1.TabIndex = 4;
            label1.Text = "Panel de Votaciones en Tiempo Real";
            // 
            // panelGrafico
            // 
            panelGrafico.BackColor = Color.White;
            panelGrafico.Location = new Point(27, 180);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(640, 283);
            panelGrafico.TabIndex = 1;
            // 
            // panelTiempo
            // 
            panelTiempo.BackColor = SystemColors.ActiveCaptionText;
            panelTiempo.BorderStyle = BorderStyle.Fixed3D;
            panelTiempo.Controls.Add(label8);
            panelTiempo.Controls.Add(lblTiempoRestante);
            panelTiempo.ForeColor = Color.Cornsilk;
            panelTiempo.Location = new Point(-6, 538);
            panelTiempo.Name = "panelTiempo";
            panelTiempo.Size = new Size(708, 69);
            panelTiempo.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(203, 14);
            label8.Name = "label8";
            label8.Size = new Size(144, 31);
            label8.TabIndex = 1;
            label8.Text = "Tiempo Restante:";
            // 
            // lblTiempoRestante
            // 
            lblTiempoRestante.AutoSize = true;
            lblTiempoRestante.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempoRestante.ForeColor = SystemColors.ControlLightLight;
            lblTiempoRestante.Location = new Point(353, 24);
            lblTiempoRestante.Name = "lblTiempoRestante";
            lblTiempoRestante.Size = new Size(104, 18);
            lblTiempoRestante.TabIndex = 0;
            lblTiempoRestante.Text = "00 : 00 : 00";
            // 
            // btnComparacion
            // 
            btnComparacion.BackColor = Color.OrangeRed;
            btnComparacion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnComparacion.ForeColor = Color.White;
            btnComparacion.Location = new Point(126, 482);
            btnComparacion.Name = "btnComparacion";
            btnComparacion.Size = new Size(208, 30);
            btnComparacion.TabIndex = 2;
            btnComparacion.Text = "VOTOS";
            btnComparacion.UseVisualStyleBackColor = false;
            btnComparacion.Click += btnMostrarParticipacion_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Blue;
            textBox1.Enabled = false;
            textBox1.Location = new Point(29, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 100);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.OrangeRed;
            textBox2.Enabled = false;
            textBox2.Location = new Point(249, 60);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 100);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Green;
            textBox3.Enabled = false;
            textBox3.Location = new Point(467, 60);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 100);
            textBox3.TabIndex = 6;
            // 
            // lblEmitidos
            // 
            lblEmitidos.AutoSize = true;
            lblEmitidos.BackColor = Color.Blue;
            lblEmitidos.Font = new Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmitidos.ForeColor = Color.White;
            lblEmitidos.Location = new Point(102, 125);
            lblEmitidos.Name = "lblEmitidos";
            lblEmitidos.Size = new Size(48, 25);
            lblEmitidos.TabIndex = 7;
            lblEmitidos.Text = "label2";
            // 
            // lblNulos
            // 
            lblNulos.AutoSize = true;
            lblNulos.BackColor = Color.OrangeRed;
            lblNulos.Font = new Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNulos.ForeColor = Color.White;
            lblNulos.Location = new Point(322, 127);
            lblNulos.Name = "lblNulos";
            lblNulos.Size = new Size(48, 25);
            lblNulos.TabIndex = 8;
            lblNulos.Text = "label2";
            // 
            // lblParticipacion
            // 
            lblParticipacion.AutoSize = true;
            lblParticipacion.BackColor = Color.Green;
            lblParticipacion.Font = new Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParticipacion.ForeColor = Color.White;
            lblParticipacion.Location = new Point(540, 126);
            lblParticipacion.Name = "lblParticipacion";
            lblParticipacion.Size = new Size(48, 25);
            lblParticipacion.TabIndex = 9;
            lblParticipacion.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(58, 94);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 10;
            label2.Text = "________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.OrangeRed;
            label3.Font = new Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(279, 94);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 11;
            label3.Text = "________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Green;
            label4.Font = new Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(496, 95);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 12;
            label4.Text = "________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Blue;
            label5.Font = new Font("Agency FB", 21.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(56, 74);
            label5.Name = "label5";
            label5.Size = new Size(146, 35);
            label5.TabIndex = 13;
            label5.Text = "Votos Emitidos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.OrangeRed;
            label6.Font = new Font("Agency FB", 21.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(288, 75);
            label6.Name = "label6";
            label6.Size = new Size(121, 35);
            label6.TabIndex = 14;
            label6.Text = "Votos Nulos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Green;
            label7.Font = new Font("Agency FB", 21.75F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(498, 75);
            label7.Name = "label7";
            label7.Size = new Size(135, 35);
            label7.TabIndex = 15;
            label7.Text = "Participacion";
            // 
            // timerTiempo
            // 
            timerTiempo.Enabled = true;
            timerTiempo.Interval = 1000;
            timerTiempo.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(340, 482);
            button1.Name = "button1";
            button1.Size = new Size(208, 30);
            button1.TabIndex = 16;
            button1.Text = "DATOS GENERALES";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Panelform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(699, 603);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblEmitidos);
            Controls.Add(lblParticipacion);
            Controls.Add(lblNulos);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnComparacion);
            Controls.Add(panelTiempo);
            Controls.Add(panelGrafico);
            Controls.Add(panel1);
            Name = "Panelform";
            Text = "Panelform";
            Load += Panelform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTiempo.ResumeLayout(false);
            panelTiempo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelGrafico;
        private Panel panelTiempo;
        private Label lblTiempoRestante;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private FlowLayoutPanel flowIndicadores;
        private Button btnComparacion;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblEmitidos;
        private Label lblNulos;
        private Label lblParticipacion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label8;
        private System.Windows.Forms.Timer timerTiempo;
        private Button button1;
    }
}
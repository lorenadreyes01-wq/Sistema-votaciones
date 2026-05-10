namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    partial class ReportesForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblFechaCierre = new Label();
            panel2 = new Panel();
            chartDistribucionGanadora = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelEstadisticasGanadora = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblPorcentajeGanador = new Label();
            lblVotosGanador = new Label();
            lblPartidoGanador = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label5 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            lblSecretarioA = new Label();
            lblPresidenteA = new Label();
            lbl1 = new Label();
            label14 = new Label();
            pictureBoxPresidenteA = new PictureBox();
            lblVicepresidenteA = new Label();
            label11 = new Label();
            pictureBoxLogoA = new PictureBox();
            label9 = new Label();
            label13 = new Label();
            pictureBoxSecretarioA = new PictureBox();
            pictureBoxVicepresidenteA = new PictureBox();
            tabPage3 = new TabPage();
            label7 = new Label();
            chartGeneralVotos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label6 = new Label();
            tabPage4 = new TabPage();
            lblTotal = new Label();
            label12 = new Label();
            dataGridVotos = new DataGridView();
            lblTotalVotantes = new Label();
            label10 = new Label();
            dataGridVotantes = new DataGridView();
            label15 = new Label();
            btnPdf = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDistribucionGanadora).BeginInit();
            panelEstadisticasGanadora.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPresidenteA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecretarioA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVicepresidenteA).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGeneralVotos).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVotos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridVotantes).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(3, 57);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(792, 415);
            tabControl1.TabIndex = 0;
            tabControl1.Enter += tabPage4_Enter;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Blue;
            tabPage1.Controls.Add(lblFechaCierre);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panelEstadisticasGanadora);
            tabPage1.Controls.Add(label1);
            tabPage1.ForeColor = Color.RoyalBlue;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(784, 387);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Plancha Ganadora";
            tabPage1.Click += tabPage1_Click;
            tabPage1.Enter += tabPage1_Enter;
            // 
            // lblFechaCierre
            // 
            lblFechaCierre.AutoSize = true;
            lblFechaCierre.BackColor = Color.Transparent;
            lblFechaCierre.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaCierre.ForeColor = Color.LightGray;
            lblFechaCierre.Location = new Point(369, 318);
            lblFechaCierre.Name = "lblFechaCierre";
            lblFechaCierre.Size = new Size(45, 24);
            lblFechaCierre.TabIndex = 3;
            lblFechaCierre.Text = "label2";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(chartDistribucionGanadora);
            panel2.Location = new Point(282, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 257);
            panel2.TabIndex = 2;
            // 
            // chartDistribucionGanadora
            // 
            chartArea1.Name = "ChartArea1";
            chartDistribucionGanadora.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDistribucionGanadora.Legends.Add(legend1);
            chartDistribucionGanadora.Location = new Point(3, 3);
            chartDistribucionGanadora.Name = "chartDistribucionGanadora";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDistribucionGanadora.Series.Add(series1);
            chartDistribucionGanadora.Size = new Size(453, 251);
            chartDistribucionGanadora.TabIndex = 7;
            chartDistribucionGanadora.Text = "chart1";
            // 
            // panelEstadisticasGanadora
            // 
            panelEstadisticasGanadora.BackColor = Color.LightCyan;
            panelEstadisticasGanadora.Controls.Add(label2);
            panelEstadisticasGanadora.Controls.Add(label3);
            panelEstadisticasGanadora.Controls.Add(label4);
            panelEstadisticasGanadora.Controls.Add(lblPorcentajeGanador);
            panelEstadisticasGanadora.Controls.Add(lblVotosGanador);
            panelEstadisticasGanadora.Controls.Add(lblPartidoGanador);
            panelEstadisticasGanadora.Location = new Point(29, 54);
            panelEstadisticasGanadora.Name = "panelEstadisticasGanadora";
            panelEstadisticasGanadora.Size = new Size(224, 257);
            panelEstadisticasGanadora.TabIndex = 1;
            panelEstadisticasGanadora.Paint += panelEstadisticasGanadora_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Agency FB", 18F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 176);
            label2.Name = "label2";
            label2.Size = new Size(96, 31);
            label2.TabIndex = 9;
            label2.Text = "Porcentaje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Agency FB", 18F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(24, 105);
            label3.Name = "label3";
            label3.Size = new Size(55, 31);
            label3.TabIndex = 8;
            label3.Text = "Votos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Agency FB", 18F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(24, 26);
            label4.Name = "label4";
            label4.Size = new Size(69, 31);
            label4.TabIndex = 7;
            label4.Text = "Partido";
            // 
            // lblPorcentajeGanador
            // 
            lblPorcentajeGanador.AutoSize = true;
            lblPorcentajeGanador.BackColor = Color.Transparent;
            lblPorcentajeGanador.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentajeGanador.ForeColor = Color.DarkSlateGray;
            lblPorcentajeGanador.Location = new Point(27, 204);
            lblPorcentajeGanador.Name = "lblPorcentajeGanador";
            lblPorcentajeGanador.Size = new Size(44, 24);
            lblPorcentajeGanador.TabIndex = 6;
            lblPorcentajeGanador.Text = "label5";
            // 
            // lblVotosGanador
            // 
            lblVotosGanador.AutoSize = true;
            lblVotosGanador.BackColor = Color.Transparent;
            lblVotosGanador.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVotosGanador.ForeColor = Color.DarkSlateGray;
            lblVotosGanador.Location = new Point(27, 136);
            lblVotosGanador.Name = "lblVotosGanador";
            lblVotosGanador.Size = new Size(45, 24);
            lblVotosGanador.TabIndex = 5;
            lblVotosGanador.Text = "label4";
            // 
            // lblPartidoGanador
            // 
            lblPartidoGanador.AutoSize = true;
            lblPartidoGanador.BackColor = Color.Transparent;
            lblPartidoGanador.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPartidoGanador.ForeColor = Color.DarkSlateGray;
            lblPartidoGanador.Location = new Point(27, 55);
            lblPartidoGanador.Name = "lblPartidoGanador";
            lblPartidoGanador.Size = new Size(44, 24);
            lblPartidoGanador.TabIndex = 4;
            lblPartidoGanador.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lobster Two", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(296, 13);
            label1.Name = "label1";
            label1.Size = new Size(198, 30);
            label1.TabIndex = 0;
            label1.Text = "Plancha Ganadora";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.RosyBrown;
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(784, 387);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Integrantes";
            tabPage2.Click += tabPage2_Click;
            tabPage2.Enter += tabPage2_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lobster Two", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(239, 22);
            label5.Name = "label5";
            label5.Size = new Size(286, 37);
            label5.TabIndex = 6;
            label5.Text = "Integrantes del Partido";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblSecretarioA);
            panel1.Controls.Add(lblPresidenteA);
            panel1.Controls.Add(lbl1);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(pictureBoxPresidenteA);
            panel1.Controls.Add(lblVicepresidenteA);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBoxLogoA);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(pictureBoxSecretarioA);
            panel1.Controls.Add(pictureBoxVicepresidenteA);
            panel1.Location = new Point(71, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 258);
            panel1.TabIndex = 5;
            panel1.Tag = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(130, 194);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 11;
            label8.Text = "Presidente";
            // 
            // lblSecretarioA
            // 
            lblSecretarioA.AutoSize = true;
            lblSecretarioA.BackColor = Color.Transparent;
            lblSecretarioA.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSecretarioA.ForeColor = Color.MidnightBlue;
            lblSecretarioA.Location = new Point(440, 170);
            lblSecretarioA.Name = "lblSecretarioA";
            lblSecretarioA.Size = new Size(127, 18);
            lblSecretarioA.TabIndex = 14;
            lblSecretarioA.Text = "Jessica Pereira";
            // 
            // lblPresidenteA
            // 
            lblPresidenteA.AutoSize = true;
            lblPresidenteA.BackColor = Color.Transparent;
            lblPresidenteA.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPresidenteA.ForeColor = Color.MidnightBlue;
            lblPresidenteA.Location = new Point(127, 168);
            lblPresidenteA.Name = "lblPresidenteA";
            lblPresidenteA.Size = new Size(141, 18);
            lblPresidenteA.TabIndex = 9;
            lblPresidenteA.Text = "Santiago Matias";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.Black;
            lbl1.Location = new Point(128, 174);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(140, 18);
            lbl1.TabIndex = 10;
            lbl1.Text = "____________";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(443, 178);
            label14.Name = "label14";
            label14.Size = new Size(140, 18);
            label14.TabIndex = 17;
            label14.Text = "____________";
            // 
            // pictureBoxPresidenteA
            // 
            pictureBoxPresidenteA.Location = new Point(34, 154);
            pictureBoxPresidenteA.Name = "pictureBoxPresidenteA";
            pictureBoxPresidenteA.Size = new Size(87, 74);
            pictureBoxPresidenteA.TabIndex = 0;
            pictureBoxPresidenteA.TabStop = false;
            // 
            // lblVicepresidenteA
            // 
            lblVicepresidenteA.AutoSize = true;
            lblVicepresidenteA.BackColor = Color.Transparent;
            lblVicepresidenteA.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVicepresidenteA.ForeColor = Color.MidnightBlue;
            lblVicepresidenteA.Location = new Point(442, 59);
            lblVicepresidenteA.Name = "lblVicepresidenteA";
            lblVicepresidenteA.Size = new Size(114, 18);
            lblVicepresidenteA.TabIndex = 12;
            lblVicepresidenteA.Text = "Melissa Gate";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(443, 196);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 15;
            label11.Text = "Secretario";
            // 
            // pictureBoxLogoA
            // 
            pictureBoxLogoA.BackgroundImage = (Image)resources.GetObject("pictureBoxLogoA.BackgroundImage");
            pictureBoxLogoA.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLogoA.Location = new Point(17, 30);
            pictureBoxLogoA.Name = "pictureBoxLogoA";
            pictureBoxLogoA.Size = new Size(257, 94);
            pictureBoxLogoA.TabIndex = 7;
            pictureBoxLogoA.TabStop = false;
            pictureBoxLogoA.Click += pictureBoxLogoA_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(443, 82);
            label9.Name = "label9";
            label9.Size = new Size(110, 15);
            label9.TabIndex = 13;
            label9.Text = "Vicepresidente";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(441, 64);
            label13.Name = "label13";
            label13.Size = new Size(140, 18);
            label13.TabIndex = 16;
            label13.Text = "____________";
            // 
            // pictureBoxSecretarioA
            // 
            pictureBoxSecretarioA.Location = new Point(347, 154);
            pictureBoxSecretarioA.Name = "pictureBoxSecretarioA";
            pictureBoxSecretarioA.Size = new Size(87, 74);
            pictureBoxSecretarioA.TabIndex = 2;
            pictureBoxSecretarioA.TabStop = false;
            // 
            // pictureBoxVicepresidenteA
            // 
            pictureBoxVicepresidenteA.Location = new Point(347, 39);
            pictureBoxVicepresidenteA.Name = "pictureBoxVicepresidenteA";
            pictureBoxVicepresidenteA.Size = new Size(87, 74);
            pictureBoxVicepresidenteA.TabIndex = 1;
            pictureBoxVicepresidenteA.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightGray;
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(chartGeneralVotos);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(784, 387);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Votos";
            tabPage3.Click += tabPage3_Click_1;
            tabPage3.Enter += tabPage3_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(247, 321);
            label7.Name = "label7";
            label7.Size = new Size(288, 18);
            label7.TabIndex = 2;
            label7.Text = "Datos consolidados de votaciones";
            // 
            // chartGeneralVotos
            // 
            chartArea2.Name = "ChartArea1";
            chartGeneralVotos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartGeneralVotos.Legends.Add(legend2);
            chartGeneralVotos.Location = new Point(95, 77);
            chartGeneralVotos.Name = "chartGeneralVotos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartGeneralVotos.Series.Add(series2);
            chartGeneralVotos.Size = new Size(585, 229);
            chartGeneralVotos.TabIndex = 1;
            chartGeneralVotos.Text = "chart1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lobster Two", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(212, 18);
            label6.Name = "label6";
            label6.Size = new Size(335, 40);
            label6.TabIndex = 0;
            label6.Text = "Reporte General de Votos";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnPdf);
            tabPage4.Controls.Add(lblTotal);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(dataGridVotos);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(784, 387);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Votantes";
            tabPage4.Click += tabPage4_Click_1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Archivo Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(361, 351);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(61, 17);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "label15";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lobster Two", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(247, 34);
            label12.Name = "label12";
            label12.Size = new Size(269, 40);
            label12.TabIndex = 1;
            label12.Text = "Listado de Votantes";
            // 
            // dataGridVotos
            // 
            dataGridVotos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVotos.Location = new Point(80, 94);
            dataGridVotos.Name = "dataGridVotos";
            dataGridVotos.Size = new Size(613, 239);
            dataGridVotos.TabIndex = 0;
            // 
            // lblTotalVotantes
            // 
            lblTotalVotantes.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalVotantes.ForeColor = SystemColors.ActiveCaptionText;
            lblTotalVotantes.Location = new Point(249, 334);
            lblTotalVotantes.Name = "lblTotalVotantes";
            lblTotalVotantes.Size = new Size(288, 18);
            lblTotalVotantes.TabIndex = 3;
            lblTotalVotantes.Text = "Datos consolidados de votaciones";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lobster Two", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(264, 26);
            label10.Name = "label10";
            label10.Size = new Size(269, 40);
            label10.TabIndex = 1;
            label10.Text = "Listado de Votantes";
            // 
            // dataGridVotantes
            // 
            dataGridVotantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVotantes.Location = new Point(96, 88);
            dataGridVotantes.Name = "dataGridVotantes";
            dataGridVotantes.Size = new Size(592, 218);
            dataGridVotantes.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Lobster Two", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(565, 9);
            label15.Name = "label15";
            label15.Size = new Size(223, 34);
            label15.TabIndex = 3;
            label15.Text = "Reportes del Sistema";
            // 
            // btnPdf
            // 
            btnPdf.Location = new Point(600, 12);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(172, 23);
            btnPdf.TabIndex = 3;
            btnPdf.Text = "Exportar PDF";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
            // 
            // ReportesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 464);
            Controls.Add(label15);
            Controls.Add(tabControl1);
            Name = "ReportesForm";
            Text = "ReportesForm";
            Load += ReportesForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDistribucionGanadora).EndInit();
            panelEstadisticasGanadora.ResumeLayout(false);
            panelEstadisticasGanadora.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPresidenteA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecretarioA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVicepresidenteA).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartGeneralVotos).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVotos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridVotantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel2;
        private Panel panelEstadisticasGanadora;
        private Label lblFechaCierre;
        private Label lblPorcentajeGanador;
        private Label lblVotosGanador;
        private Label lblPartidoGanador;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistribucionGanadora;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label lblSecretarioA;
        private Label lblVicepresidenteA;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label lblPresidenteA;
        private Label lbl1;
        public PictureBox pictureBoxSecretarioA;
        public PictureBox pictureBoxVicepresidenteA;
        public PictureBox pictureBoxPresidenteA;
        public PictureBox pictureBoxLogoA;
        private Label label5;
        private Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGeneralVotos;
        private Label label6;
        private Label label10;
        private DataGridView dataGridVotantes;
        private Label lblTotalVotantes;
        private Label lblTotal;
        private Label label12;
        private DataGridView dataGridVotos;
        private Label label15;
        private Button btnPdf;
    }
}
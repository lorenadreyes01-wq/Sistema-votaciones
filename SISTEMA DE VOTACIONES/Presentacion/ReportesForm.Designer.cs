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
            btnPdf = new Button();
            lblTotalVotantes = new Label();
            label10 = new Label();
            dataGridVotantes = new DataGridView();
            label15 = new Label();
            stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridVotantes).BeginInit();
            SuspendLayout();
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.RosyBrown;
            btnPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPdf.ForeColor = Color.White;
            btnPdf.Location = new Point(12, 12);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(102, 23);
            btnPdf.TabIndex = 3;
            btnPdf.Text = "Exportar PDF";
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
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
            label15.Location = new Point(750, 1);
            label15.Name = "label15";
            label15.Size = new Size(223, 34);
            label15.TabIndex = 3;
            label15.Text = "Reportes del Sistema";
            // 
            // stiViewerControl1
            // 
            stiViewerControl1.AllowDrop = true;
            stiViewerControl1.Dock = DockStyle.Bottom;
            stiViewerControl1.Location = new Point(0, 50);
            stiViewerControl1.Margin = new Padding(4, 4, 4, 4);
            stiViewerControl1.Name = "stiViewerControl1";
            stiViewerControl1.Report = null;
            stiViewerControl1.RightToLeft = RightToLeft.No;
            stiViewerControl1.Size = new Size(973, 552);
            stiViewerControl1.TabIndex = 4;
            stiViewerControl1.Load += stiViewerControl1_Load;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(225, 12);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 5;
            button1.Text = "GANADOR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(345, 12);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 6;
            button2.Text = "INTEGRANTES";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.RosyBrown;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(583, 12);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 8;
            button3.Text = "GENERAL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.RosyBrown;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(463, 12);
            button4.Name = "button4";
            button4.Size = new Size(114, 23);
            button4.TabIndex = 7;
            button4.Text = "PARTICIPANTES";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ReportesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(973, 602);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(stiViewerControl1);
            Controls.Add(btnPdf);
            Controls.Add(label15);
            Name = "ReportesForm";
            Text = "ReportesForm";
            Load += ReportesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridVotantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private DataGridView dataGridVotantes;
        private Label lblTotalVotantes;
        private Label label15;
        private Button btnPdf;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
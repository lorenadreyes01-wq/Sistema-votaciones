using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore;
using SISTEMA_DE_VOTACIONES.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DrawingFont = System.Drawing.Font;
using DrawingImage = System.Drawing.Image;
using iTextFont = iTextSharp.text.Font;
using iTextImage = iTextSharp.text.Image;



namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    public partial class ReportesForm : Form
    {
        private readonly SistemaVotacionesContext _context;

        public ReportesForm(SistemaVotacionesContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void CargarListadoVotantes()
        {
            var votantes = _context.Votaciones
                .Include(v => v.Usuario)
                .Select(v => new
                {
                    Nombre = v.Usuario.Nombre,
                    Matricula = v.Usuario.Matricula,
                    Curso = v.Usuario.Curso,
                    FechaVoto = v.Fecha
                })
                .ToList();

            dataGridVotos.DataSource = votantes;

            dataGridVotos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVotos.BackgroundColor = Color.White;

            dataGridVotos.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dataGridVotos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

            dataGridVotos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridVotos.EnableHeadersVisualStyles = false;

            lblTotal.Text = $"Total de votantes: {votantes.Count}";
        }


        private void CargarReporteGeneralVotos()
        {
          
            chartGeneralVotos.Series.Clear();

            Series serieAlofoke = new Series("Alofoke")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue,
                IsValueShownAsLabel = true
            };

            Series serieOtro = new Series("Otro Partido")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Red,
                IsValueShownAsLabel = true
            };

            chartGeneralVotos.Series.Add(serieAlofoke);
            chartGeneralVotos.Series.Add(serieOtro);

         
            var distribucion = _context.Votaciones
                .Include(v => v.Plancha)
                .ThenInclude(p => p.Partido)
                .Where(v => v.PlanchaId != null)
                .GroupBy(v => v.Plancha.Partido.Nombre)
                .Select(g => new
                {
                    Partido = g.Key,
                    Cantidad = g.Count()
                })
                .ToList();

            foreach (var d in distribucion)
            {
                if (d.Partido == "Alofoke")
                    serieAlofoke.Points.AddXY(d.Partido, d.Cantidad);
                else
                    serieOtro.Points.AddXY(d.Partido, d.Cantidad);
            }

            chartGeneralVotos.ChartAreas[0].AxisX.Title = "Partidos";
            chartGeneralVotos.ChartAreas[0].AxisY.Title = "Cantidad de Votos";
            chartGeneralVotos.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            chartGeneralVotos.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
        }

        


        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CargarIntegrantesGanadora();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            CargarReporteGeneralVotos();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            CargarListadoVotantes();
        }



        private void CargarReportePlanchaGanadora()
        {
            chartDistribucionGanadora.Series.Clear();

            Series serie = new Series("Distribución")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            chartDistribucionGanadora.Series.Add(serie);

            var ganadora = _context.Votaciones
                .Where(v => v.PlanchaId != null)
                .GroupBy(v => v.PlanchaId)
                .Select(g => new
                {
                    PlanchaId = g.Key,
                    Votos = g.Count()
                })
                .OrderByDescending(x => x.Votos)
                .FirstOrDefault();

            if (ganadora != null)
            {
                var plancha = _context.Planchas
                    .Include(p => p.Partido)
                    .FirstOrDefault(p => p.Id == ganadora.PlanchaId);

                if (plancha != null)
                {
                    lblPartidoGanador.Text = $"Ganador: {plancha.Partido.Nombre}";
                    lblVotosGanador.Text = $"Votos: {ganadora.Votos}";

                    int totalVotos = _context.Votaciones.Count();
                    double porcentaje = (ganadora.Votos * 100.0) / totalVotos;
                    lblPorcentajeGanador.Text = $"Participación: {porcentaje:F2}%";
                }
            }

            var distribucion = _context.Votaciones
                .Where(v => v.PlanchaId != null)
                .GroupBy(v => v.Plancha.Partido.Nombre)
                .Select(g => new
                {
                    Partido = g.Key,
                    Cantidad = g.Count()
                })
                .ToList();

            foreach (var d in distribucion)
            {
                chartDistribucionGanadora.Series["Distribución"].Points.AddXY(d.Partido, d.Cantidad);
            }

            chartDistribucionGanadora.Legends[0].Docking = Docking.Bottom;
            chartDistribucionGanadora.Legends[0].Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
        }


        private void panelEstadisticasGanadora_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBoxLogoA_Click(object sender, EventArgs e)
        {

        }

        private void CargarIntegrantesGanadora()
        {
            var ganadora = _context.Votaciones
                .Where(v => v.PlanchaId != null)
                .GroupBy(v => v.PlanchaId)
                .Select(g => new
                {
                    PlanchaId = g.Key,
                    Votos = g.Count()
                })
                .OrderByDescending(x => x.Votos)
                .FirstOrDefault();

            if (ganadora != null)
            {
                var plancha = _context.Planchas
                    .Include(p => p.Partido)
                    .FirstOrDefault(p => p.Id == ganadora.PlanchaId);

                if (plancha != null)
                {
                    lblPresidenteA.Text = plancha.Presidente;
                    lblVicepresidenteA.Text = plancha.Vicepresidente;
                    lblSecretarioA.Text = plancha.Secretario;

                    if (!string.IsNullOrEmpty(plancha.PresidenteFoto) && File.Exists(plancha.PresidenteFoto))
                        pictureBoxPresidenteA.Image = System.Drawing.Image.FromFile(plancha.PresidenteFoto);

                    if (!string.IsNullOrEmpty(plancha.VicepresidenteFoto) && File.Exists(plancha.VicepresidenteFoto))
                        pictureBoxVicepresidenteA.Image = System.Drawing.Image.FromFile(plancha.VicepresidenteFoto);

                    if (!string.IsNullOrEmpty(plancha.SecretarioFoto) && File.Exists(plancha.SecretarioFoto))
                        pictureBoxSecretarioA.Image = System.Drawing.Image.FromFile(plancha.SecretarioFoto);

                    if (plancha.Partido != null && !string.IsNullOrEmpty(plancha.Partido.Logo) && File.Exists(plancha.Partido.Logo))
                        pictureBoxLogoA.Image = System.Drawing.Image.FromFile(plancha.Partido.Logo);

                    pictureBoxPresidenteA.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxVicepresidenteA.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxSecretarioA.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxLogoA.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {

        }



        private void tabPage3_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Ente(object sender, EventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            CargarReportePlanchaGanadora();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "PDF|*.pdf",
                Title = "Guardar Reporte General"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    pdfDoc.Add(new Paragraph("Reporte Plancha Ganadora", new iTextFont(iTextFont.FontFamily.HELVETICA, 14, iTextFont.BOLD)));
                    pdfDoc.Add(new Paragraph($"Partido: {lblPartidoGanador.Text}"));
                    pdfDoc.Add(new Paragraph($"Votos: {lblVotosGanador.Text}"));
                    pdfDoc.Add(new Paragraph($"Porcentaje: {lblPorcentajeGanador.Text}"));
                    pdfDoc.Add(new Paragraph("\n"));

                    using (MemoryStream ms = new MemoryStream())
                    {
                        chartDistribucionGanadora.SaveImage(ms, ChartImageFormat.Png);
                        iTextImage chartImage = iTextImage.GetInstance(ms.ToArray());
                        chartImage.ScaleToFit(400f, 300f);
                        pdfDoc.Add(chartImage);
                    }
                    pdfDoc.Add(new Paragraph("\n"));

                    pdfDoc.Add(new Paragraph("Integrantes de la Plancha Ganadora", new iTextFont(iTextFont.FontFamily.HELVETICA, 14, iTextFont.BOLD)));
                    pdfDoc.Add(new Paragraph($"Presidente: {lblPresidenteA.Text}"));
                    pdfDoc.Add(new Paragraph($"Vicepresidente: {lblVicepresidenteA.Text}"));
                    pdfDoc.Add(new Paragraph($"Secretario: {lblSecretarioA.Text}"));
                    pdfDoc.Add(new Paragraph("\n"));

                    ExportarImagenDePictureBox(pictureBoxPresidenteA, pdfDoc);
                    ExportarImagenDePictureBox(pictureBoxVicepresidenteA, pdfDoc);
                    ExportarImagenDePictureBox(pictureBoxSecretarioA, pdfDoc);
                    ExportarImagenDePictureBox(pictureBoxLogoA, pdfDoc);
                    pdfDoc.Add(new Paragraph("\n"));

                    pdfDoc.Add(new Paragraph("Reporte General de Votos", new iTextFont(iTextFont.FontFamily.HELVETICA, 14, iTextFont.BOLD)));
                    using (MemoryStream ms = new MemoryStream())
                    {
                        chartGeneralVotos.SaveImage(ms, ChartImageFormat.Png);
                        iTextImage chartImage = iTextImage.GetInstance(ms.ToArray());
                        chartImage.ScaleToFit(400f, 300f);
                        pdfDoc.Add(chartImage);
                    }
                    pdfDoc.Add(new Paragraph("\n"));

                    pdfDoc.Add(new Paragraph("Listado de Votantes", new iTextFont(iTextFont.FontFamily.HELVETICA, 14, iTextFont.BOLD)));
                    foreach (DataGridViewRow row in dataGridVotos.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            pdfDoc.Add(new Paragraph(
                                $"{row.Cells["Nombre"].Value} - {row.Cells["Matricula"].Value} - {row.Cells["Curso"].Value} - {row.Cells["FechaVoto"].Value}"
                            ));
                        }
                    }
                    pdfDoc.Add(new Paragraph($"\n{lblTotalVotantes.Text}"));

                    pdfDoc.Close();
                    writer.Close();
                    stream.Close();
                }

                MessageBox.Show("Reporte exportado correctamente a PDF", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void ExportarImagenDePictureBox(PictureBox pic, Document pdfDoc)
        {
            if (pic.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    iTextImage foto = iTextImage.GetInstance(ms.ToArray());
                    foto.ScaleToFit(120f, 120f);
                    pdfDoc.Add(foto);
                }
            }
        }
      

      
    }
}

using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using SISTEMA_DE_VOTACIONES.Conexion;
using SISTEMA_DE_VOTACIONES.Entidades;
using Stimulsoft.Report;
using Stimulsoft.Report.Design;
using Stimulsoft.Report.Viewer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Stimulsoft.Report.Win.Images.StiReportViewerImages;
using DrawingFont = System.Drawing.Font;
using DrawingImage = System.Drawing.Image;
using iTextFont = iTextSharp.text.Font;
using iTextImage = iTextSharp.text.Image;


namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    public partial class ReportesForm : Form
    {
        object varIntegrantes;
        object varGanador;
        object varGeneralVotos;
        object varParticipantes;

        private readonly SistemaVotacionesContext _context;
        private StiReport miReporte;

        public ReportesForm(SistemaVotacionesContext context)
        {
            InitializeComponent();
            _context = context;

            miReporte = new StiReport();
        }




        private void panelEstadisticasGanadora_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBoxLogoA_Click(object sender, EventArgs e)
        {

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


        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (stiViewerControl1.Report == null)
                {
                    MessageBox.Show("Por favor, carga un reporte primero.");
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar Reporte de Votaciones";
                saveFileDialog.FileName = "Reporte_Final_Votaciones.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StiReport reporteAExportar = stiViewerControl1.Report;

                    reporteAExportar.ExportDocument(StiExportFormat.Pdf, saveFileDialog.FileName);

                    MessageBox.Show("¡PDF generado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a PDF: " + ex.Message, "Error Técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private dynamic CargarDatosDeBaseDeDatos(int op)
        {
            switch (op)
            {
                case 0:
                    return _context.Planchas
        .Select(p => new
        {
            NombrePartido = p.Partido.Nombre,
            p.Presidente,
            p.Vicepresidente,
            p.Secretario,
            Votos = _context.Votaciones.Count(v => v.PlanchaId == p.Id) // Usa "Votos" igual que en el case 0
        })
        .OrderByDescending(x => x.Votos)
        .Take(1)
        .ToList();

                case 1: 
                    return _context.Planchas
                        .Select(p => new {
                            NombrePartido = p.Partido.Nombre,
                            p.Presidente,
                            p.Vicepresidente,
                            p.Secretario,
                            Votos = _context.Votaciones.Count(v => v.PlanchaId == p.Id)
                        })
                        .OrderByDescending(x => x.Votos)
                        .Take(1)
                        .ToList();

                case 2:
                    return _context.Planchas
                        .Select(p => new
                        {
                            NombrePartido = p.Partido.Nombre,
                            CantidadVotos = _context.Votaciones.Count(v => v.PlanchaId == p.Id)
                        }).ToList();

                case 3:
                    return _context.Usuarios
                        .Where(u => u.Rol == "Votante")
                        .Select(u => new
                        {
                            u.Matricula,
                            u.Nombre,
                            u.Curso,
                            Estado = _context.Votaciones.Any(v => v.UsuarioId == u.Id) ? "Votó" : "Pendiente"
                        }).ToList();

                default:
                    return null;
            }
        }

        private void CargarReporte(string rutaCompleta)
        {
            try
            {
                varIntegrantes = CargarDatosDeBaseDeDatos(0);
                varGanador = CargarDatosDeBaseDeDatos(1);
                varGeneralVotos = CargarDatosDeBaseDeDatos(2);
                varParticipantes = CargarDatosDeBaseDeDatos(3);

                StiReport report = new StiReport();

                if (!File.Exists(rutaCompleta))
                {
                    MessageBox.Show("No existe el archivo en: " + rutaCompleta);
                    return;
                }

                report.Load(rutaCompleta);

                report.RegData("Repo_Integrantes", varIntegrantes);
                report.RegData("Repo_Ganador", varGanador);
                report.RegData("Repo_General", varGeneralVotos);
                report.RegData("Repo_Participantes", varParticipantes);

                report.Dictionary.Synchronize();
                report.Render(false);

                stiViewerControl1.Report = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error técnico: " + ex.Message);
            }
        }

        private void stiViewerControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarReporte(@"C:\Users\asisc\source\repos\SISTEMA DE VOTACIONES\SISTEMA DE VOTACIONES\Presentacion\REPORTES\Ganador.mrt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarReporte(@"C:\Users\asisc\source\repos\SISTEMA DE VOTACIONES\SISTEMA DE VOTACIONES\Presentacion\REPORTES\Participantes.mrt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarReporte(@"C:\Users\asisc\source\repos\SISTEMA DE VOTACIONES\SISTEMA DE VOTACIONES\Presentacion\REPORTES\GENERAL.mrt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarReporte(@"C:\Users\asisc\source\repos\SISTEMA DE VOTACIONES\SISTEMA DE VOTACIONES\Presentacion\REPORTES\Integrantes.mrt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var data0 = CargarDatosDeBaseDeDatos(0);
                var data1 = CargarDatosDeBaseDeDatos(1);
                var data2 = CargarDatosDeBaseDeDatos(2);
                var data3 = CargarDatosDeBaseDeDatos(3);

                StiReport report = new StiReport();

                string nombreArchivo = "Ganador.mrt";
                string ruta = Path.Combine(@"C:\Users\asisc\source\repos\SISTEMA DE VOTACIONES\SISTEMA DE VOTACIONES\Presentacion\REPORTES", nombreArchivo);

                if (File.Exists(ruta))
                {
                    report.Load(ruta);
                }
                else
                {
                    MessageBox.Show("El archivo no existe en la ruta especificada.");
                    return;
                }

                report.RegData("Repo_Integrantes", data0);
                report.RegData("Repo_Ganador", data1);
                report.RegData("Repo_General", data2);
                report.RegData("Repo_Participantes", data3);

                report.Dictionary.Synchronize();

                report.Design();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el editor: " + ex.Message);
            }
        }
    }
}

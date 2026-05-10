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

namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    public partial class Panelform : Form
    {
        private readonly SistemaVotacionesContext _context;
        private readonly DateTime _horaCierre = new DateTime(2026, 5, 12, 18, 0, 0);
        public Panelform(SistemaVotacionesContext context)
        {
            InitializeComponent();
            _context = context;

            timerTiempo.Interval = 1000; // cada segundo
            timerTiempo.Tick += TimerTiempo_Tick;
            timerTiempo.Start();
        }

        private Chart chartVotos;

        private void TimerTiempo_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoRestante = _horaCierre - DateTime.Now;

            if (tiempoRestante.TotalSeconds <= 0)
            {
                lblTiempoRestante.Text = "Tiempo Restante: Finalizado";
                lblTiempoRestante.ForeColor = Color.Red;
                timerTiempo.Stop();
            }
            else
            {
                lblTiempoRestante.Text = $"{tiempoRestante.Days:D2}d {tiempoRestante.Hours:D2}:{tiempoRestante.Minutes:D2}:{tiempoRestante.Seconds:D2}";
                lblTiempoRestante.ForeColor = Color.Lime;
            }
        }

        private void RefrescarPanel()
        {

            int votosEmitidos = _context.Votaciones.Count();
            int padronElectoral = _context.Usuarios.Count();
            int votosNulos = _context.Votaciones.Count(v => v.PlanchaId == null);
            int participantes = _context.Votaciones.Select(v => v.UsuarioId).Distinct().Count();

            double porcentajeEmitidos = padronElectoral > 0 ? (double)votosEmitidos / padronElectoral * 100 : 0;
            double porcentajeNulos = votosEmitidos > 0 ? (double)votosNulos / votosEmitidos * 100 : 0;
            double porcentajeParticipacion = padronElectoral > 0 ? (double)participantes / padronElectoral * 100 : 0;


            lblEmitidos.Text = $"{Math.Round(porcentajeEmitidos, 2)}%";
            lblNulos.Text = $"{Math.Round(porcentajeNulos, 2)}%";
            lblParticipacion.Text = $"{Math.Round(porcentajeParticipacion, 2)}%";


            chartVotos.Series["Distribución"].Points.Clear();
            var ranking = _context.Votaciones
                .Include(v => v.Plancha)
                .ThenInclude(pl => pl.Partido)
                .Where(v => v.PlanchaId != null)
                .GroupBy(v => v.Plancha.Partido.Nombre)
                .Select(g => new { Partido = g.Key, Votos = g.Count() })
                .ToList();

            foreach (var r in ranking)
            {
                chartVotos.Series["Distribución"].Points.AddXY(r.Partido, r.Votos);
            }
        }

        private void InicializarChart()
        {
            chartVotos = new Chart();
            chartVotos.Name = "chartVotos";
            chartVotos.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea("AreaPrincipal");
            chartVotos.ChartAreas.Add(area);

            Legend leyenda = new Legend("Leyenda");
            chartVotos.Legends.Add(leyenda);

            Series serie = new Series("Distribución");
            serie.ChartType = SeriesChartType.Pie;
            chartVotos.Series.Add(serie);

            panelGrafico.Controls.Add(chartVotos);
        }




        private void Panelform_Load(object sender, EventArgs e)
        {
            InicializarChart();
            RefrescarPanel();


        }

        private void lblEmitidos_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private bool mostrandoComparacion = false;

        private void btnMostrarParticipacion_Click(object sender, EventArgs e)
        {
            chartVotos.Series.Clear();

            if (!mostrandoComparacion)
            {
                Series serieEmitidos = new Series("Emitidos")
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.SteelBlue
                };

                Series serieNulos = new Series("Nulos")
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.Orange
                };

                var votacionesPorHora = _context.Votaciones
                    .GroupBy(v => v.Fecha.Hour)
                    .Select(g => new
                    {
                        Hora = g.Key,
                        Emitidos = g.Count(),
                        Nulos = g.Count(v => v.PlanchaId == null)
                    })
                    .OrderBy(x => x.Hora)
                    .ToList();

                foreach (var punto in votacionesPorHora)
                {
                    serieEmitidos.Points.AddXY(punto.Hora, punto.Emitidos);
                    serieNulos.Points.AddXY(punto.Hora, punto.Nulos);
                }

                chartVotos.Series.Add(serieEmitidos);
                chartVotos.Series.Add(serieNulos);

                chartVotos.ChartAreas[0].AxisX.Title = "Hora";
                chartVotos.ChartAreas[0].AxisY.Title = "Cantidad de Votos";

                mostrandoComparacion = true;
                btnComparacion.Text = "Volver al Gráfico Pastel";
            }
            else
            {
                // 👉 Volver al gráfico pastel
                Series seriePastel = new Series("Distribución")
                {
                    ChartType = SeriesChartType.Pie,
                    Label = "#PERCENT{P0}",
                    LegendText = "#VALX"
                };

                var distribucion = _context.Votaciones
                    .Where(v => v.PlanchaId != null)
                    .GroupBy(v => v.Plancha.PartidoId)
                    .Select(g => new
                    {
                        PartidoId = g.Key,
                        Cantidad = g.Count()
                    })
                    .ToList();

                foreach (var d in distribucion)
                {
                    string nombrePartido = _context.Partidos
                        .Where(p => p.Id == d.PartidoId)
                        .Select(p => p.Nombre)
                        .FirstOrDefault();

                    seriePastel.Points.AddXY(nombrePartido, d.Cantidad);
                }

                chartVotos.Series.Add(seriePastel);

                mostrandoComparacion = false;
                btnComparacion.Text = "Comparar Emitidos vs Nulos";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datosform frmDatos = new Datosform(_context, _horaCierre);
            frmDatos.ShowDialog();
        }
    }
}

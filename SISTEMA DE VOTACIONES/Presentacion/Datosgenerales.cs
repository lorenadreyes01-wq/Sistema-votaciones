using Microsoft.EntityFrameworkCore;
using SISTEMA_DE_VOTACIONES.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    public partial class Datosgenerales : Form
    {
        private readonly SistemaVotacionesContext _context;
        private readonly DateTime _horaCierre;
        public Datosgenerales(SistemaVotacionesContext context, DateTime horaCierre)
        {
            InitializeComponent();
            _context = context;
            _horaCierre = horaCierre;
        }

        private void Datosgenerales_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
            timerTiempoRestante.Interval = 1000; // cada segundo
            timerTiempoRestante.Tick += TimerTiempoRestante_Tick;
            timerTiempoRestante.Start();
        }
    

      private void RefrescarDatos()
        {
            int votosEmitidos = _context.Votaciones.Count();
            int padronElectoral = _context.Usuarios.Count(); // todos pueden votar
            int participantes = _context.Votaciones.Select(v => v.UsuarioId).Distinct().Count();
            int votosNulos = _context.Votaciones.Count(v => v.PlanchaId == null);

            lblVotosEmitidos.Text = $"Votos Emitidos: {votosEmitidos}";
            lblPadronElectoral.Text = $"Padrón Electoral: {padronElectoral}";
            lblParticipantes.Text = $"Participantes: {participantes}";
            lblTotales.Text = $"Totales (incl. nulos): {votosEmitidos}";

            var ranking = _context.Votaciones
                .Where(v => v.PlanchaId != null)
                .GroupBy(v => v.Plancha.Partido.Nombre)
                .Select(g => new
                {
                    Partido = g.Key,
                    Votos = g.Count(),
                    Porcentaje = padronElectoral > 0
                        ? Math.Round((double)g.Count() / padronElectoral * 100, 2)
                        : 0
                })
                .OrderByDescending(r => r.Votos)
                .ToList();

            dgvRankingPartidos.DataSource = ranking;
        }

        private void TimerTiempoRestante_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoRestante = _horaCierre - DateTime.Now;
            if (tiempoRestante.TotalSeconds <= 0)
            {
                lblTiempoRestante.Text = "Tiempo Restante: Finalizado";
                timerTiempoRestante.Stop();
            }
            else
            {
                lblTiempoRestante.Text = $"Tiempo Restante: {tiempoRestante.Hours:D2}:{tiempoRestante.Minutes:D2}:{tiempoRestante.Seconds:D2}";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

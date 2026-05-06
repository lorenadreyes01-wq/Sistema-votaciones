using Microsoft.EntityFrameworkCore;
using SISTEMA_DE_VOTACIONES.Conexion;
using SISTEMA_DE_VOTACIONES.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    public partial class Votaciones : Form
    {
        private readonly SistemaVotacionesContext _context;
        private readonly Usuario _usuarioActual;
        public Votaciones(SistemaVotacionesContext context, Usuario usuarioActual)
        {
            InitializeComponent();
            _context = context;
            _usuarioActual = usuarioActual;

            // Cargar datos iniciales
            RefrescarVotaciones();

            btnVotarA.Tag = 1; // Plancha A
            btnVotarB.Tag = 2; // Plancha B

            // Enganchar eventos
            btnVotarA.Click += btnVotarPlancha_Click;
            btnVotarB.Click += btnVotarPlancha_Click;
            btnNulo.Click += btnNulo_Click;
        }

        private void RegistrarVoto(int? planchaId)
        {
            int usuarioId = _usuarioActual.Id;

            // Validar si ya votó
            bool yaVoto = _context.Votaciones.Any(v => v.UsuarioId == usuarioId);
            if (yaVoto)
            {
                MessageBox.Show("Ya has ejercido tu voto. No puedes votar más de una vez.",
                                "Voto no permitido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var voto = new Votacion
            {
                UsuarioId = usuarioId,
                PlanchaId = planchaId, 
                Fecha = DateTime.Now
            };

            _context.Votaciones.Add(voto);
            _context.SaveChanges(); 

            MessageBox.Show("Tu voto ha sido registrado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.Close(); 
        }

        private void btnVotarPlancha_Click(object sender, EventArgs e)
        {
            int planchaId = Convert.ToInt32(((Button)sender).Tag);
            int usuarioId = _usuarioActual.Id;

            bool yaVoto = _context.Votaciones.Any(v => v.UsuarioId == usuarioId);
            if (yaVoto)
            {
                MessageBox.Show("Ya has ejercido tu voto. No puedes votar más de una vez.",
                                "Voto no permitido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var voto = new Votacion
            {
                UsuarioId = usuarioId,
                PlanchaId = planchaId,
                Fecha = DateTime.Now
            };

            _context.Votaciones.Add(voto);
            _context.SaveChanges();

            RefrescarVotaciones();

            MessageBox.Show("Tu voto ha sido registrado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            this.Close();
        }

        private void btnNulo_Click(object sender, EventArgs e)
        {
            int usuarioId = _usuarioActual.Id;

            bool yaVoto = _context.Votaciones.Any(v => v.UsuarioId == usuarioId);
            if (yaVoto)
            {
                MessageBox.Show("Ya has ejercido tu voto. No puedes votar más de una vez.",
                                "Voto no permitido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var voto = new Votacion
            {
                UsuarioId = usuarioId,
                PlanchaId = null,
                Fecha = DateTime.Now
            };

            _context.Votaciones.Add(voto);
            _context.SaveChanges();

            RefrescarVotaciones();

            MessageBox.Show("Tu voto nulo ha sido registrado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            this.Close();

        }
        private void RefrescarVotaciones()
        {
            var planchas = _context.Planchas.ToList();

            var planchaA = planchas.FirstOrDefault(p => p.Id == 1);
            if (planchaA != null)
            {
                lblPresidenteA.Text = planchaA.Presidente;
                lblVicepresidenteA.Text = planchaA.Vicepresidente;
                lblSecretarioA.Text = planchaA.Secretario;
                lblLemaA.Text = planchaA.Lema;

                if (!string.IsNullOrEmpty(planchaA.PresidenteFoto) && File.Exists(planchaA.PresidenteFoto))
                    pictureBoxPresidenteA.Image = Image.FromFile(planchaA.PresidenteFoto);

                if (!string.IsNullOrEmpty(planchaA.VicepresidenteFoto) && File.Exists(planchaA.VicepresidenteFoto))
                    pictureBoxVicepresidenteA.Image = Image.FromFile(planchaA.VicepresidenteFoto);

                if (!string.IsNullOrEmpty(planchaA.SecretarioFoto) && File.Exists(planchaA.SecretarioFoto))
                    pictureBoxSecretarioA.Image = Image.FromFile(planchaA.SecretarioFoto);

                var partidoA = _context.Partidos.FirstOrDefault(pa => pa.Id == planchaA.PartidoId);
                if (partidoA != null && !string.IsNullOrEmpty(partidoA.Logo) && File.Exists(partidoA.Logo))
                    pictureBoxLogoA.Image = Image.FromFile(partidoA.Logo);
            }

            var planchaB = planchas.FirstOrDefault(p => p.Id == 2);
            if (planchaB != null)
            {
                lblPresidenteB.Text = planchaB.Presidente;
                lblVicepresidenteB.Text = planchaB.Vicepresidente;
                lblSecretarioB.Text = planchaB.Secretario;
                lblLemaB.Text = planchaB.Lema;

                if (!string.IsNullOrEmpty(planchaB.PresidenteFoto) && File.Exists(planchaB.PresidenteFoto))
                    pictureBoxPresidenteB.Image = Image.FromFile(planchaB.PresidenteFoto);

                if (!string.IsNullOrEmpty(planchaB.VicepresidenteFoto) && File.Exists(planchaB.VicepresidenteFoto))
                    pictureBoxVicepresidenteB.Image = Image.FromFile(planchaB.VicepresidenteFoto);

                if (!string.IsNullOrEmpty(planchaB.SecretarioFoto) && File.Exists(planchaB.SecretarioFoto))
                    pictureBoxSecretarioB.Image = Image.FromFile(planchaB.SecretarioFoto);

                var partidoB = _context.Partidos.FirstOrDefault(pb => pb.Id == planchaB.PartidoId);
                if (partidoB != null && !string.IsNullOrEmpty(partidoB.Logo) && File.Exists(partidoB.Logo))
                    pictureBoxLogoB.Image = Image.FromFile(partidoB.Logo);
            }

            AplicarStretchEnImagenes();
        }
        private void AplicarStretchEnImagenes()
        {
            pictureBoxPresidenteA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVicepresidenteA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSecretarioA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogoA.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxPresidenteB.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVicepresidenteB.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSecretarioB.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogoB.SizeMode = PictureBoxSizeMode.StretchImage;
        }



        private void Votaciones_Load(object sender, EventArgs e)
        {
            RefrescarVotaciones();
        }

        private void btnNulo_Click_1(object sender, EventArgs e)
        {
            RegistrarVoto(null);
        }

        private void btnVotarA_Click(object sender, EventArgs e)
        {
            RegistrarVoto(1);
        }

        private void btnVotarB_Click(object sender, EventArgs e)
        {
            RegistrarVoto(2);
        }
    }
}

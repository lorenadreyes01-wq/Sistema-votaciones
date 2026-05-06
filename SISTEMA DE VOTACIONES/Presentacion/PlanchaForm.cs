using Microsoft.EntityFrameworkCore;
using SISTEMA_DE_VOTACIONES.Conexion;
using SISTEMA_DE_VOTACIONES.Entidades;
using SISTEMA_DE_VOTACIONES.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SISTEMA_DE_VOTACIONES.Presentacion
{
    public partial class PlanchaForm : Form
    {
        private readonly SistemaVotacionesContext _context;
        private readonly PlanchaService _planchaService;
        private readonly Usuario _usuarioActual;
        public PlanchaForm(SistemaVotacionesContext context, Usuario usuarioActual)
        {
            InitializeComponent();
            _context = context;
            _usuarioActual = usuarioActual;
            _planchaService = new PlanchaService(context);

            CargarPlanchasGrid();

            BloquearFilasNoAutorizadas(_usuarioActual.Id);

            RefrescarPaneles();
        }


        private void RefrescarPaneles()
        {
            var planchas = _planchaService.ObtenerPlanchas();

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

                var partidoA = _context.Partidos.FirstOrDefault(p => p.Id == planchaA.PartidoId);
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

                var partidoB = _context.Partidos.FirstOrDefault(p => p.Id == planchaB.PartidoId);
                if (partidoB != null && !string.IsNullOrEmpty(partidoB.Logo) && File.Exists(partidoB.Logo))
                    pictureBoxLogoB.Image = Image.FromFile(partidoB.Logo);
            }

            AplicarStretchEnImagenes();
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private int? planchaSeleccionadaId = null;

        private void panel2_Click(object sender, EventArgs e)
        {
            if (panel2.Tag != null)
            {

            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (panel3.Tag != null)
            {

            }
        }


        private void lblpresiA_Click(object sender, EventArgs e)
        {

        }

        private void BloquearFilasNoAutorizadas(int usuarioId)
        {
            foreach (DataGridViewRow row in dgvPlanchas.Rows)
            {
                var fila = row.DataBoundItem as PlanchaDTO;
                if (fila != null)
                {
                    if (_usuarioActual.Id == 6 && fila.Id == 1)
                    {
                        row.ReadOnly = false;
                    }
                    else if (_usuarioActual.Id == 7 && fila.Id == 2)
                    {
                        row.ReadOnly = false;
                    }
                    else
                    {
                        row.ReadOnly = true; // 🔒 bloquea edición
                    }
                }
            }
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



        private void CargarPlanchasGrid()
        {
            var planchas = (from pl in _context.Planchas
                            join pa in _context.Partidos on pl.PartidoId equals pa.Id
                            select new PlanchaDTO
                            {
                                Id = pl.Id,
                                PartidoId = pl.PartidoId,
                                Presidente = pl.Presidente,
                                Vicepresidente = pl.Vicepresidente,
                                Secretario = pl.Secretario,
                                Lema = pl.Lema,
                                PresidenteFoto = pl.PresidenteFoto,
                                VicepresidenteFoto = pl.VicepresidenteFoto,
                                SecretarioFoto = pl.SecretarioFoto,
                                CreadorId = pl.CreadorId,
                                PartidoNombre = pa.Nombre,
                                PartidoLogo = pa.Logo
                            }).ToList();

            dgvPlanchas.DataSource = planchas;

            dgvPlanchas.ReadOnly = false;
            foreach (DataGridViewColumn col in dgvPlanchas.Columns)
            {
                col.ReadOnly = false;
            }

        }

        private void dgvPlanchas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlanchas.CurrentRow != null)
            {
                var logoPath = dgvPlanchas.CurrentRow.Cells["PartidoLogo"].Value?.ToString();
                var planchaId = Convert.ToInt32(dgvPlanchas.CurrentRow.Cells["Id"].Value);

                if (!string.IsNullOrEmpty(logoPath) && File.Exists(logoPath))
                {
                    if (planchaId == 1)
                    {
                        pictureBoxLogoA.Image = Image.FromFile(logoPath);
                        pictureBoxLogoA.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else if (planchaId == 2)
                    {
                        pictureBoxLogoB.Image = Image.FromFile(logoPath);
                        pictureBoxLogoB.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    if (planchaId == 1)
                        pictureBoxLogoA.Image = null;
                    else if (planchaId == 2)
                        pictureBoxLogoB.Image = null;
                }
            }
        }




        private void PlanchaForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvPlanchas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dgvPlanchas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvPlanchas.Rows[e.RowIndex].DataBoundItem as PlanchaDTO;
                if (fila != null)
                {
                    // Actualizar plancha
                    var plancha = _context.Planchas.FirstOrDefault(p => p.Id == fila.Id);
                    if (plancha != null)
                    {
                        plancha.Presidente = fila.Presidente;
                        plancha.Vicepresidente = fila.Vicepresidente;
                        plancha.Secretario = fila.Secretario;
                        plancha.Lema = fila.Lema;
                        plancha.PresidenteFoto = fila.PresidenteFoto;
                        plancha.VicepresidenteFoto = fila.VicepresidenteFoto;
                        plancha.SecretarioFoto = fila.SecretarioFoto;
                    }

                    // Actualizar logo del partido
                    var partido = _context.Partidos.FirstOrDefault(p => p.Id == fila.PartidoId);
                    if (partido != null)
                    {
                        partido.Logo = fila.PartidoLogo;
                    }

                    // Guardar cambios en BD
                    _context.SaveChanges();

                    // Refrescar paneles
                    RefrescarPaneles();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvPlanchas.CurrentRow != null)
            {
                var fila = dgvPlanchas.CurrentRow.DataBoundItem as PlanchaDTO;
                if (fila != null)
                {
                    bool permitido = (_usuarioActual.Id == 6 && fila.Id == 1) ||
                                     (_usuarioActual.Id == 7 && fila.Id == 2);

                    if (!permitido)
                    {
                        MessageBox.Show("No tienes permiso para editar esta plancha.",
                                        "Acceso denegado",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }

                    var plancha = _context.Planchas.FirstOrDefault(p => p.Id == fila.Id);
                    if (plancha != null)
                    {
                        plancha.Presidente = fila.Presidente;
                        plancha.Vicepresidente = fila.Vicepresidente;
                        plancha.Secretario = fila.Secretario;
                        plancha.Lema = fila.Lema;
                        plancha.PresidenteFoto = fila.PresidenteFoto;
                        plancha.VicepresidenteFoto = fila.VicepresidenteFoto;
                        plancha.SecretarioFoto = fila.SecretarioFoto;
                    }

                    var partido = _context.Partidos.FirstOrDefault(p => p.Id == fila.PartidoId);
                    if (partido != null)
                    {
                        partido.Logo = fila.PartidoLogo;
                    }

                    _context.SaveChanges();

                    RefrescarPaneles();

                    MessageBox.Show("Cambios guardados correctamente.",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }
    }
}


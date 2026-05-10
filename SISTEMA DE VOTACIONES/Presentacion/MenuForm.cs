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
    public partial class MenuForm : Form
    {
        private Usuario _usuario;
        private readonly UsuarioService _usuarioService;
        private readonly SistemaVotacionesContext _context;
        private readonly Usuario _usuarioActual;

        public MenuForm(Usuario usuario, UsuarioService usuarioService)
        {
            InitializeComponent();

            _usuario = usuario;
            _usuarioActual = usuario;
            _usuarioService = usuarioService;
            _context = new SistemaVotacionesContext();

            ConfigurarMenuPorRol();
            btnVotaciones.Click += BtnVotaciones_Click;

        }

        private void ConfigurarMenuPorRol()
        {
            btnVotaciones.Visible = true;
            btnPanel.Visible = true;
            btnDatos.Visible = true;
            btnCerrar.Visible = true;
            btnSalir.Visible = true;

            if (_usuario.Rol == "Administrador")
            {
                btnUsuarios.Visible = true;
                btnPlancha.Visible = true;
            }
            else if (_usuario.Rol == "Creador de Plancha")
            {
                btnUsuarios.Visible = false;
                btnPlancha.Visible = true;
            }
            else
            {
                btnUsuarios.Visible = false;
                btnPlancha.Visible = false;
            }
        }

        private void BtnVotaciones_Click(object sender, EventArgs e)
        {
            bool yaVoto = _context.Votaciones.Any(v => v.UsuarioId == _usuarioActual.Id);

            if (yaVoto)
            {
                MessageBox.Show("Ya has ejercido tu voto. No puedes volver a votar.",
                                "Acceso denegado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var votacionesForm = new Votaciones(_context, _usuarioActual);
            votacionesForm.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosForm usuariosForm = new UsuariosForm(_usuarioService);
            usuariosForm.ShowDialog();
        }

        private void btnPlancha_Click(object sender, EventArgs e)
        {
            var form = new PlanchaForm(_context, _usuarioActual);
            form.ShowDialog();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            DateTime horaCierre = new DateTime(2026, 5, 12, 18, 0, 0);


            var formDatos = new Datosform(_context, horaCierre);
            formDatos.ShowDialog();
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            var panel = new Panelform(_context);
            panel.ShowDialog();
        }
    }
}

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

        public MenuForm(Usuario usuario, UsuarioService usuarioService)
        {
            InitializeComponent();

            _usuario = usuario;
            _usuarioService = usuarioService;
            ConfigurarMenuPorRol();
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
    }
}

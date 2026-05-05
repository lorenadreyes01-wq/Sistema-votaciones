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
    public partial class RegistroAdminForm : Form
    {
        private readonly UsuarioService _usuarioService;
        public RegistroAdminForm(UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
        }

        private void RegistroAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _usuarioService.RegistrarUsuario(
               txtNombre.Text,
               txtCurso.Text,
               txtSeccion.Text,
               txtMatricula.Text,
               "Administrador",
               txtContraseña.Text
               );

            MessageBox.Show("✅ Administrador registrado correctamente.");
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

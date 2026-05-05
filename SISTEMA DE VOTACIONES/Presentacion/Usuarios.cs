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
    public partial class UsuariosForm : Form
    {
        private readonly UsuarioService _usuarioService;
        public UsuariosForm(UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            CargarUsuarios();

        }

        private void CargarUsuarios()
        {
            var usuarios = _usuarioService.ObtenerUsuarios();
            dgvUsuarios.DataSource = usuarios;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistroUVForm registroForm = new RegistroUVForm(_usuarioService);
            registroForm.ShowDialog();

            CargarUsuarios();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroAdminForm adminForm = new RegistroAdminForm(_usuarioService);
            adminForm.ShowDialog();
            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int id = (int)dgvUsuarios.CurrentRow.Cells["Id"].Value;

                _usuarioService.EliminarUsuario(id);

                MessageBox.Show("✅ Usuario eliminado correctamente.");

                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Selecciona un usuario primero.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int id = (int)dgvUsuarios.CurrentRow.Cells["Id"].Value;
                string nombre = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                string matricula = dgvUsuarios.CurrentRow.Cells["Matricula"].Value.ToString();
                string clave = dgvUsuarios.CurrentRow.Cells["Clave"].Value.ToString();
                string rol = dgvUsuarios.CurrentRow.Cells["Rol"].Value.ToString();

                Usuario usuario = new Usuario
                {
                    Id = id,
                    Nombre = nombre,
                    Matricula = matricula,
                    Clave = clave,
                    Rol = rol
                };

                _usuarioService.ActualizarUsuario(usuario);
                MessageBox.Show("✅ Usuario actualizado correctamente.");
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Selecciona un usuario primero.");
            }
        }
    }
}

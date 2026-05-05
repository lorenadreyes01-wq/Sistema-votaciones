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
    public partial class RegistroUVForm : Form
    {
        private UsuarioService _usuarioService;
        public RegistroUVForm(UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;


            cmbRol.Items.Add("Votante");
            cmbRol.SelectedIndex = 0;
        }

        private void RegistroUsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _usuarioService.RegistrarUsuario(
                    txtNombre.Text,
                    txtCurso.Text,
                    txtSeccion.Text,
                    txtMatricula.Text,
                    "Votante", // 🔹 Rol fijo
                    txtContraseña.Text
                );

                MessageBox.Show("✅ Su registro ha sido completado. Vaya a Login nuevamente.");
                this.Close(); // Cierra el form después de guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
             this.Close(); 
        }
    }
}

using SISTEMA_DE_VOTACIONES.Conexion;
using SISTEMA_DE_VOTACIONES.Logica;
using SISTEMA_DE_VOTACIONES.Presentacion;

namespace SISTEMA_DE_VOTACIONES
{
    public partial class LoginForm : Form
    {

        private UsuarioService _usuarioService;

        public LoginForm()
        {
            InitializeComponent();

            var context = new SistemaVotacionesContext();
            var usuarioRepo = new UsuarioRepository(context);
            _usuarioService = new UsuarioService(usuarioRepo);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroUVForm registro = new RegistroUVForm(_usuarioService);
            registro.ShowDialog();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var usuario = _usuarioService.ObtenerUsuarios()
                                 .FirstOrDefault(u => u.Matricula == txtUsuario.Text
                                                   && u.Clave == txtClave.Text);

            if (usuario != null)
            {
                MenuForm menu = new MenuForm(usuario, _usuarioService);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ups, no existes, ¡regístrate!");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

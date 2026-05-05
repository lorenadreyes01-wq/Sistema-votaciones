using SISTEMA_DE_VOTACIONES.Conexion;
using SISTEMA_DE_VOTACIONES.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_VOTACIONES.Logica
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepo;

        public UsuarioService(UsuarioRepository usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
        }

        public void RegistrarUsuario(string nombre, string curso, string seccion, string matricula, string rol, string clave)
        {
            var existe = _usuarioRepo.BuscarPorMatricula(matricula);
            if (existe != null)
            {
                throw new Exception("La matrícula ya está registrada.");
            }

            var usuario = new Usuario
            {
                Nombre = nombre,
                Curso = curso,
                Seccion = seccion,
                Matricula = matricula,
                Rol = rol,
                Clave = clave
            };

            _usuarioRepo.Agregar(usuario);
        }

        public Usuario ValidarUsuario(string matricula, string clave)
        {
            return _usuarioRepo.BuscarPorCredenciales(matricula, clave);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return _usuarioRepo.Listar();
        }

        public void EliminarUsuario(int id)
        {
            _usuarioRepo.Eliminar(id);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            _usuarioRepo.Actualizar(usuario);
        }

    }
}

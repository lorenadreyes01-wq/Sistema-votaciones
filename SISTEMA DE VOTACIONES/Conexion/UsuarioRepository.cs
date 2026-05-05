using System;
using System.Collections.Generic;
using System.Text;
using SISTEMA_DE_VOTACIONES.Entidades;


namespace SISTEMA_DE_VOTACIONES.Conexion
{
    public class UsuarioRepository
    {
        private readonly SistemaVotacionesContext _context;

        public UsuarioRepository(SistemaVotacionesContext context)
        {
            _context = context;
        }

        public void Agregar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public Usuario BuscarPorMatricula(string matricula)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Matricula == matricula);
        }

        public Usuario BuscarPorCredenciales(string matricula, string clave)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Matricula == matricula && u.Clave == clave);
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public void Eliminar(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }

        public void Actualizar(Usuario usuario)
        {
            var existente = _context.Usuarios.FirstOrDefault(u => u.Id == usuario.Id);
            if (existente != null)
            {
                existente.Nombre = usuario.Nombre;
                existente.Matricula = usuario.Matricula;
                existente.Clave = usuario.Clave;
                existente.Rol = usuario.Rol;
                _context.SaveChanges();
            }
        }

    }
}

using SISTEMA_DE_VOTACIONES.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_VOTACIONES.Conexion
{
    public class PartidoRepository
    {
        private readonly SistemaVotacionesContext _context;

        public PartidoRepository(SistemaVotacionesContext context)
        {
            _context = context;
        }

        // Crear
        public void Agregar(Partido partido)
        {
            _context.Partidos.Add(partido);
            _context.SaveChanges();
        }

        // Leer (todos)
        public List<Partido> Listar()
        {
            return _context.Partidos.ToList();
        }

        // Leer (por Id)
        public Partido BuscarPorId(int id)
        {
            return _context.Partidos.FirstOrDefault(p => p.Id == id);
        }

        // Actualizar
        public void Actualizar(Partido partido)
        {
            var existente = _context.Partidos.FirstOrDefault(p => p.Id == partido.Id);
            if (existente != null)
            {
                existente.Nombre = partido.Nombre;
                existente.Logo = partido.Logo;
                _context.SaveChanges();
            }
        }

        // Eliminar
        public void Eliminar(int id)
        {
            var partido = _context.Partidos.FirstOrDefault(p => p.Id == id);
            if (partido != null)
            {
                _context.Partidos.Remove(partido);
                _context.SaveChanges();
            }
        }
    }

}



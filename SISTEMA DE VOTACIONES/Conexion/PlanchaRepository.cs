using SISTEMA_DE_VOTACIONES.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_VOTACIONES.Conexion
{

    public class PlanchaRepository
    {
        private readonly SistemaVotacionesContext _context;

        // Constructor recibe el contexto
        public PlanchaRepository(SistemaVotacionesContext context)
        {
            _context = context;
        }

        // Crear
        public void Agregar(Plancha plancha)
        {
            _context.Planchas.Add(plancha);
            _context.SaveChanges();
        }

        // Leer (todos)
        public List<Plancha> Listar()
        {
            return _context.Planchas.ToList();
        }

        // Leer (por Id)
        public Plancha BuscarPorId(int id)
        {
            return _context.Planchas.FirstOrDefault(p => p.Id == id);
        }

        // Actualizar
        public void Actualizar(Plancha plancha)
        {
            var existente = _context.Planchas.FirstOrDefault(p => p.Id == plancha.Id);
            if (existente != null)
            {
                existente.PartidoId = plancha.PartidoId;
                existente.Presidente = plancha.Presidente;
                existente.Vicepresidente = plancha.Vicepresidente;
                existente.Secretario = plancha.Secretario;
                existente.Lema = plancha.Lema;
                existente.PresidenteFoto = plancha.PresidenteFoto;
                existente.VicepresidenteFoto = plancha.VicepresidenteFoto;
                existente.SecretarioFoto = plancha.SecretarioFoto;
                _context.SaveChanges();
            }
        }

        // Eliminar
        public void Eliminar(int id)
        {
            var plancha = _context.Planchas.FirstOrDefault(p => p.Id == id);
            if (plancha != null)
            {
                _context.Planchas.Remove(plancha);
                _context.SaveChanges();
            }
        }
    }
}


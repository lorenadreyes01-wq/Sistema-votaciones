using SISTEMA_DE_VOTACIONES.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_VOTACIONES.Conexion
{
    public class VotacionRepository
    {
        private readonly SistemaVotacionesContext _context;

        public VotacionRepository(SistemaVotacionesContext context)
        {
            _context = context;
        }

        public void RegistrarVoto(Votacion votacion)
        {
            _context.Votaciones.Add(votacion);
            _context.SaveChanges();
        }

        public List<Votacion> Listar()
        {
            return _context.Votaciones.ToList();
        }

        public Votacion BuscarPorId(int id)
        {
            return _context.Votaciones.FirstOrDefault(v => v.Id == id);
        }

        public int ContarVotosPorPlancha(int planchaId)
        {
            return _context.Votaciones.Count(v => v.PlanchaId == planchaId);
        }

        public int ContarVotosNulos()
        {
            return _context.Votaciones.Count(v => v.PlanchaId == null);
        }
    }
}

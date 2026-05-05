using SISTEMA_DE_VOTACIONES.Conexion;
using SISTEMA_DE_VOTACIONES.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_VOTACIONES.Logica
{
    public class VotacionService
    {
        private readonly VotacionRepository _votacionRepo;

        public VotacionService(VotacionRepository votacionRepo)
        {
            _votacionRepo = votacionRepo;
        }

        // Registrar voto válido
        public void RegistrarVoto(int usuarioId, int planchaId)
        {
            var voto = new Votacion
            {
                UsuarioId = usuarioId,
                PlanchaId = planchaId,
                Fecha = DateTime.Now
            };

            _votacionRepo.RegistrarVoto(voto);
        }

        // Registrar voto nulo
        public void RegistrarVotoNulo(int usuarioId)
        {
            var voto = new Votacion
            {
                UsuarioId = usuarioId,
                PlanchaId = null,   // null indica voto nulo
                Fecha = DateTime.Now
            };

            _votacionRepo.RegistrarVoto(voto);
        }

        // Consultas
        public int ContarVotosPorPlancha(int planchaId)
        {
            return _votacionRepo.ContarVotosPorPlancha(planchaId);
        }

        public int ContarVotosNulos()
        {
            return _votacionRepo.ContarVotosNulos();
        }

        public List<Votacion> ObtenerTodas()
        {
            return _votacionRepo.Listar();
        }
    }
}

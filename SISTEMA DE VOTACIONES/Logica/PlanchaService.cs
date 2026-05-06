using SISTEMA_DE_VOTACIONES.Conexion;
using SISTEMA_DE_VOTACIONES.Entidades;
using SISTEMA_DE_VOTACIONES.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_VOTACIONES.Logica
{

    public class PlanchaService
    {

        private readonly PlanchaRepository _planchaRepo;

        public PlanchaService(SistemaVotacionesContext context)
        {
            _planchaRepo = new PlanchaRepository(context);
        }


        public void RegistrarPlancha(int partidoId, string presidente, string vicepresidente, string secretario, int creadorId, string lema, string presidenteFoto, string viceFoto, string secretarioFoto)
        {
            var plancha = new Plancha
            {
                PartidoId = partidoId,
                Presidente = presidente,
                Vicepresidente = vicepresidente,
                Secretario = secretario,
                CreadorId = creadorId,
                Lema = lema,
                PresidenteFoto = presidenteFoto,
                VicepresidenteFoto = viceFoto,
                SecretarioFoto = secretarioFoto
            };

            _planchaRepo.Agregar(plancha);
        }

        // Actualizar plancha existente
        public void ActualizarPlancha(int id, int partidoId, string presidente, string vicepresidente, string secretario, string lema, string presidenteFoto, string viceFoto, string secretarioFoto)
        {
            var plancha = new Plancha
            {
                Id = id,
                PartidoId = partidoId,
                Presidente = presidente,
                Vicepresidente = vicepresidente,
                Secretario = secretario,
                Lema = lema,
                PresidenteFoto = presidenteFoto,
                VicepresidenteFoto = viceFoto,
                SecretarioFoto = secretarioFoto
            };

            _planchaRepo.Actualizar(plancha);
        }

        // Listar todas las planchas
        public List<Plancha> ObtenerPlanchas()
        {
            return _planchaRepo.Listar();
        }

        // Buscar plancha por Id
        public Plancha BuscarPorId(int id)
        {
            return _planchaRepo.BuscarPorId(id);
        }

        // Eliminar plancha
        public void EliminarPlancha(int id)
        {
            _planchaRepo.Eliminar(id);
        }
    }
}


